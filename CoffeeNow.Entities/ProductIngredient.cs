using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeNow.Entities
{
    public class ProductIngredient
    {
        public int product_ingredient_id { get; set; }
        public int product_id { get; set; }
        public int ingredient_id { get; set; }
        public decimal quantity { get; set; }
	    public int measure_id { get; set; }
	
    }
}
