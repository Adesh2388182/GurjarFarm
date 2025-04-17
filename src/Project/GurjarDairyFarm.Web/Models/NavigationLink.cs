using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GurjarDairyFarm.Web.Models
{
    public class NavigationLink
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public IEnumerable<NavigationLink> SubLinks { get; set; } // Sub-child links
    }
}