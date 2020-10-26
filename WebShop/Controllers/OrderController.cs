using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "You must have products");
            }

            if (ModelState.IsValid)
            {
                allOrders.CreatOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order is sucsess";
            return View();
        }
    }
}
