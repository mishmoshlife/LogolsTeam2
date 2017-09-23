using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeNow.Entities
{
    class OrderItem
    {
        public int order_item_id { get; set; }
        public int order_id { get; set; }
        public int quantity { get; set; }
        public decimal item_price_total { get; set; }
	
    }
}
