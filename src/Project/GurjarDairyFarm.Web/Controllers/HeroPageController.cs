using System.Web.Mvc;
using GurjarDairyFarm.Web.Models;

namespace GurjarDairyFarm.Web.Controllers
{
    public class HeroPageController : Controller
    {
        // GET: HeroPage
        public ActionResult Index()
        {
            // Populate the HeroPageModel with data
            var model = new HeroPageModel
            {
                Title = "Welcome to Gurjar Dairy Farm",
                Subtitle = "Freshness Delivered Daily",
                BackgroundImageUrl = "/images/hero-background.jpg" // Replace with your actual image path
            };

            // Pass the model to the view
            return View("~/Views/GurjarFarm/HeroPage/Index.cshtml", model);
        }
    }
}
