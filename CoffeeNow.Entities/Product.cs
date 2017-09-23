using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeNow.Entities
{
    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string description { get; set; }
	    public string imagefile { get; set; }
        public decimal price { get; set; }
	
    }
}
