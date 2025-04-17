using System.Collections.Generic;
using System.Web.Mvc;
using GurjarDairyFarm.Web.Models;

namespace GurjarDairyFarm.Web.Controllers
{
    public class HeaderController : Controller
    {
        public ActionResult Index()
        {
            var model = new HeaderModel
            {
                Logo = "/assets/images/logo.png",
                NavigationLinks = new List<NavigationLink>
                {
                    new NavigationLink
                    {
                        Text = "Home",
                        Url = "/home",
                        SubLinks = null // No sub-links for Home
                    },
                    new NavigationLink
                    {
                        Text = "Products",
                        Url = "/products",
                        SubLinks = new List<NavigationLink>
                        {
                            new NavigationLink { Text = "Milk", Url = "/products/milk" },
                            new NavigationLink { Text = "Cheese", Url = "/products/cheese" },
                            new NavigationLink { Text = "Butter", Url = "/products/butter" }
                        }
                    },
                    new NavigationLink
                    {
                        Text = "About Us",
                        Url = "/about",
                        SubLinks = null // No sub-links for About Us
                    },
                    new NavigationLink
                    {
                        Text = "Contact",
                        Url = "/contact",
                        SubLinks = null // No sub-links for Contact
                    }
                }
            };

            return View("~/Views/GurjarFarm/Header/Index.cshtml", model);
        }
    }
}
