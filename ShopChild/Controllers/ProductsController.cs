using ShopChild.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopChild.Controllers
{
    public class ProductsController : Controller
    {
        MyDBConfig db = new MyDBConfig();
        // GET: Products
        public ActionResult List()
        {
            var products = db.Product.Include(p => p.Category);
            ViewBag.ListCategory = db.Category.ToList();
            return View(products.ToList());
        }

        public PartialViewResult FinProductByNameAndCate()
        {
            var products = db.Product.AsQueryable();
            if (Request.QueryString["categoryId"] != null)
            {
                string categoryId = this.Request.QueryString["categoryId"];
                if (!string.IsNullOrEmpty(categoryId))
                {
                    products = products.Where(s => s.CategoryId.Contains(categoryId)).Include(p => p.Category);
                }
            }

            if (Request.QueryString["SearchName"] != null)
            {
                string QueryName = this.Request.QueryString["SearchName"];
                if (!String.IsNullOrEmpty(QueryName))
                {
                    products = products.Where(s => s.Name.Contains(QueryName)).Include(p => p.Category);
                }
            }
            return PartialView("FinProduct", products.ToList());
        }
    }
}