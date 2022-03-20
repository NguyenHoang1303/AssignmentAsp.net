﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopChild.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public double Price { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }

    }
}