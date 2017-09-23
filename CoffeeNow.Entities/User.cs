using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeNow.Entities
{
    class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime date_created { get; set; }
    
    }
}
