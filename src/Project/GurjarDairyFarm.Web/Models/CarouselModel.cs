﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GurjarDairyFarm.Web.Models
{

    public class Product
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Availability { get; set; }
    }

}