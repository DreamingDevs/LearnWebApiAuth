﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnWebApiAuth.API.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }
    }
}