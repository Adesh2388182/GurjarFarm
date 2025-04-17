using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GurjarDairyFarm.Web.Models
{
    public class HeaderModel
    {
        public string Logo { get; set; }
        public IEnumerable<NavigationLink> NavigationLinks { get; set; }
    }
}