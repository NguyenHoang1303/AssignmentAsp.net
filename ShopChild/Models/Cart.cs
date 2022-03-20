using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopChild.Models
{
    public class Cart
    {
        public Dictionary<string,Item> ListItem { get; set; }
        public double TotalPrice { get; set; }

        public Cart()
        {
            ListItem = new Dictionary<string, Item>();
        }
    }
}