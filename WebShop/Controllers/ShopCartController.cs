using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class ShopCartController:Controller
    {
        private readonly IAllStaffs _staffRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllStaffs staffRep,ShopCart shopCart)
        {
            _staffRep = staffRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _staffRep.Staffs.FirstOrDefault(i=>i.id==id);

            if (item != null)
            {
                _shopCart.AddToCard(item);
            }
            return RedirectToAction("Index");
        }
    }
}
