using IBTFull.Models;
using System.Web.Mvc;

namespace IBTFull.Controllers
{
    public class HomeController : BaseController
    { 
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/faq")]
        public ActionResult Faq()
        {
            return View();
        }

        [Route("/contacts")]
        public ActionResult Contacts()
        {
            return View();
        }

        [Route("/advantages")]
        public ActionResult Advantages()
        {
            return View();
        }

        [Route("/engineering")]
        public ActionResult Engineering()
        {
            return View();
        }

        [Route("/abu/{id}")]
        public ActionResult Abu(int id)
        {
            Abu model = AbuFactory.Produce(id) ?? AbuFactory.Produce(5);
            return View(model);
        }
    }
}