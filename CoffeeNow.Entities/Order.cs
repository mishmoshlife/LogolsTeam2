using System;

namespace ClassLibrary1
{
    public class Order
    {
        public int order_id { get; set; }
        public DateTime order_date { get; set; }
        public int user_id { get; set; }
        public int payment_type_id { get; set; }
        public decimal amount_paid { get; set; }
        public string order_code { get; set; }
    }
    
}
