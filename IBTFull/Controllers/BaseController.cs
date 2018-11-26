using System;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace IBTFull.Controllers
{
    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string languahe = RouteData.Values["language"] as string;
            string cultureName = languahe != null ? languahe : Consts.DEFAULT_CULTURE;

            if (!Consts.SUPPORTED_CULTURES.Any(q => q == cultureName))
            {
                cultureName = Consts.DEFAULT_CULTURE;
            }

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
    }
}