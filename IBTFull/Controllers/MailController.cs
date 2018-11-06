using IBTFull.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IBTFull.Controllers
{
    public class MailController : Controller
    {
        [HttpPost]
        public async Task<ActionResult> SendEmail(EmailMessage message, List<HttpPostedFileBase> files)
        {
            var destination = ConfigurationManager.AppSettings["RecepientEmail"];
            var token = ConfigurationManager.AppSettings["SendGridApiToken"];

            var client = new SendGridClient(token);
            var from = new EmailAddress("noreply@ibtbiotechnology.com", Consts.COMPANY_NAME);
            var to = new EmailAddress(destination, Consts.COMPANY_NAME);

            var msg = MailHelper.CreateSingleEmail(
                from,
                to,
                Consts.EMAIL_TITLE,
                BuildPlainBody(message),
                BuildHtmlBody(message));

            msg.ReplyTo = new EmailAddress(message.Email);

            foreach (var file in files.Where(q => q != null))
            {
                using (var stream = new MemoryStream())
                {
                    file.InputStream.CopyTo(stream);
                    var encoded = Convert.ToBase64String(stream.ToArray());
                    msg.AddAttachment(file.FileName, encoded, file.ContentType);
                }
            }

            await client.SendEmailAsync(msg);

            return RedirectToAction("Contacts", "Home", new { q = "messagesend" });
        }

        private string BuildPlainBody(EmailMessage message)
        {
            var bodyPlain = "";

            bodyPlain += $"От: {message.Name}{Environment.NewLine}";
            bodyPlain += $"Email: {message.Email}{Environment.NewLine}";
            bodyPlain += $"Сообщение: {message.Body}{Environment.NewLine}";

            return bodyPlain;
        }

        private string BuildHtmlBody(EmailMessage message)
        {
            var bodyHtml = "";
            bodyHtml += $"<p>От: {message.Name}{Environment.NewLine}</p>";
            bodyHtml += $"<p>Email: {message.Email}{Environment.NewLine}</p>";
            bodyHtml += $"<p>Сообщение: {message.Body}{Environment.NewLine}</p>";

            return bodyHtml;
        }
    }
}