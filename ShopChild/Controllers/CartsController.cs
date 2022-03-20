using ShopChild.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopChild.Controllers
{
    public class CartsController : Controller
    {
        // GET: Carts
        public ActionResult Index()
        {
            if(Session["carts"] == null)
            {
                return View();
            }
            Cart carts = (Cart)Session["carts"];
            List<Item> items = new List<Item>();
            foreach (Item i in carts.ListItem.Values)
            {
                items.Add(i);
            }
            ViewBag.TotalPrice = carts.TotalPrice;
            return View(items);
        }


        public ActionResult AddToCart(Item item)
        {
            if (Session["carts"] == null)
            {
                Session["carts"] = new Cart();
            }

            Cart carts = (Cart)Session["carts"];
            var existItem = carts.ListItem.ContainsKey(item.ProductId);
            if (!existItem)
            {
                item.Quantity = 1;
                carts.ListItem.Add(item.ProductId, item);
            }
            else
            {
                carts.ListItem[item.ProductId].Quantity++;
            }

            carts.TotalPrice = GetTotalPrice(carts.ListItem);
            Session["carts"] = carts;
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCart(Item item)
        {
            Cart carts = (Cart)Session["carts"];
            if (!carts.ListItem.ContainsKey(item.ProductId))
            {
                throw new Exception("Sản phẩm không tồn tại");
            }
            Item existItem = carts.ListItem[item.ProductId];
            existItem.Quantity = item.Quantity;
            carts.ListItem[existItem.ProductId]= existItem;

            carts.TotalPrice = GetTotalPrice(carts.ListItem);
            Session["carts"] = carts;
            return RedirectToAction("Index");
        }

        public ActionResult RemoveItemFromCart(string ProductId)
        {
            Cart carts = (Cart)Session["carts"];
            if (!carts.ListItem.ContainsKey(ProductId))
            {
                throw new Exception("Sản phẩm không tồn tại");
            }
            carts.ListItem.Remove(ProductId);
            carts.TotalPrice = GetTotalPrice(carts.ListItem);
            Session["carts"] = carts;
            return RedirectToAction("Index");
        }

        public double GetTotalPrice(Dictionary<string, Item> Items)
        {
            double total = 0;
            foreach (var i in Items.Values)
            {
                total += i.Quantity * i.UnitPrice;
            }
            return total;
        }
    }
}