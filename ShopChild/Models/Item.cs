using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopChild.Models
{
    public class Item
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductThumbnail { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}