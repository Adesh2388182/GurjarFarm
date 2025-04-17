using System.Collections.Generic;
using System.Web.Mvc;
using GurjarDairyFarm.Web.Models;

namespace GurjarDairyFarm.Web.Controllers
{
    public class FooterController : Controller
    {
        public ActionResult Index()
        {
            var model = new FooterModel
            {
                CopyrightText = "© 2025 Gurjar Dairy Farm. All rights reserved.",
                SocialMediaLinks = new List<string> { "Facebook", "Twitter", "Instagram" }
            };
            return View("~/Views/GurjarFarm/Footer/Index.cshtml", model);
        }
    }
}
