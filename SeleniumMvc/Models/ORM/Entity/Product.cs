using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeleniumMvc.Models.ORM.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}