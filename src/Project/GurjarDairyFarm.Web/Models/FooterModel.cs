using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GurjarDairyFarm.Web.Models
{
    public class FooterModel
    {
        public string CopyrightText { get; set; }
        public IEnumerable<string> SocialMediaLinks { get; set; }
    }
}