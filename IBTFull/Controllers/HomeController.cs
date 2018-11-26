using IBTFull.Resources;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IBTFull.Controllers
{
    public class HomeController : BaseController
    { 
        public ActionResult Index()
        {
            ViewData["keywords"] = GetKeywords();
            ViewData["desc"] = SharedResource.ResourceManager.GetString("HomeDesc");
            return View();
        }

        public ActionResult Faq()
        {
            ViewData["keywords"] = GetKeywords();
            ViewData["desc"] = SharedResource.ResourceManager.GetString("FAQDesc");
            return View();
        }

        public ActionResult Contacts()
        {
            ViewData["keywords"] = GetKeywords();
            ViewData["desc"] = SharedResource.ResourceManager.GetString("ContactDesc");
            return View();
        }

        public ActionResult Advantages()
        {
            ViewData["keywords"] = GetKeywords();
            ViewData["desc"] = SharedResource.ResourceManager.GetString("AdvantagesDesc");
            return View();
        }

        public ActionResult Engineering()
        {
            ViewData["keywords"] = GetKeywords();
            ViewData["desc"] = SharedResource.ResourceManager.GetString("SpecDesc");
            return View();
        }

        public ActionResult Abu(int id)
        {
            ViewData["keywords"] = GetKeywords();
            ViewData["desc"] = SharedResource.ResourceManager.GetString("SpecDesc");
            Models.Abu model = AbuFactory.Produce(id) ?? AbuFactory.Produce(5);
            return View(model);
        }

        private string GetKeywords()
        {
            List<string> output = new List<string>();
            for (int i = 1; i <= 25; i++)
            {
                output.Add(SharedResource.ResourceManager.GetString("keyword" + i));
            }

            output.Shuffle();

            return string.Join(",", output); ;
        }
    }
}