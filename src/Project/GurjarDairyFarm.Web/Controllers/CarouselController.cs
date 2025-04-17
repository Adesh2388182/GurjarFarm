using System.Collections.Generic;
using System.Web.Mvc;
using GurjarDairyFarm.Web.Models;

namespace GurjarDairyFarm.Web.Controllers
    {
        public class CarouselController : Controller
        {
            public ActionResult Index()
            {
                // Create a sample model with images and captions
                var model = new CarouselModel
                {
                    Images = new List<ImageField>
                {
                    new ImageField { ImageUrl = "/images/carousel1.jpg", AltText = "Fresh Dairy Products" },
                    new ImageField { ImageUrl = "/images/carousel2.jpg", AltText = "Quality You Can Trust" },
                    new ImageField { ImageUrl = "/images/carousel3.jpg", AltText = "Farm to Table" }
                },
                    Captions = new List<string>
                {
                    "Fresh Dairy Products",
                    "Quality You Can Trust",
                    "Farm to Table"
                }
                };

                // Pass the model to the view
                return View("~/Views/Carousel/Index.cshtml", model);
            }
        }
    }
