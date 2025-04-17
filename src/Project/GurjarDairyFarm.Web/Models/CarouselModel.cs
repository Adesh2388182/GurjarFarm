using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GurjarDairyFarm.Web.Models
{
	public class CarouselModel
	{
        public List<ImageField> Images { get; set; }
        public List<string> Captions { get; set; }
    }
}