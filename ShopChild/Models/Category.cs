using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopChild.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}