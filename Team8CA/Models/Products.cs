﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team8CA.Models
{
    public class Products
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }        
        public string ProductPic { get; set; }
        public double ProductPrice { get; set; }
        public bool ProductAvailability { get; set; }
        public string ProductDescription { get; set; }
        public virtual Category Category { get; set; }

      
    }
}
