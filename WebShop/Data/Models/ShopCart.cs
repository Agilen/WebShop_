using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }
        
        public List<ShopStaffItems> listShopItems { get; set; }

        public static ShopCart getCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetRequiredService < AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };


        }

        public void AddToCard(Staff staff)
        {
            this.appDBContent.shopStaffItems.Add(new ShopStaffItems
            {
                shopStaffIf = ShopCartId,
                staff=staff,
                price=staff.price
            }) ;
            appDBContent.SaveChanges();
        }

        public List<ShopStaffItems> getShopItems()
        {
            return appDBContent.shopStaffItems.Where(c => c.shopStaffIf == ShopCartId).Include(s => s.staff).ToList();
        }
    }
}
