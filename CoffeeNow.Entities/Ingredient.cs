using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeNow.Entities
{
    public class Ingredient
    {
        public int ingredient_id { get; set; }
        public string ingredient_name { get; set; }
        public decimal calories { get; set; }
        public decimal sodium { get; set; }
        public decimal fat { get; set; }
        public decimal carb { get; set; }
        public decimal sugars { get; set; }
        public decimal measure_id { get; set; }
    }
}
