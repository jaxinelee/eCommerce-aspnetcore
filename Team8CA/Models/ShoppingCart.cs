﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Team8CA.Models
{
    public class ShoppingCart
    {
        //orderID, user id, product ID, count of the items, price (not addded to database)
        public ShoppingCart()
        {
            Quantity = 0;
        }

        public int OrderId { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderCreationTime { get; set; }

        public DateTime OrderTime {get;set;}

        public bool IsCheckOut { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double SubTotal { get; set; }

    }
}