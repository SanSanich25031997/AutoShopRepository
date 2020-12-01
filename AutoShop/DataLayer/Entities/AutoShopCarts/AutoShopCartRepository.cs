using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities.Cars;
using DataLayer.Entities.AutoShopCartItems;

namespace DataLayer.Entities.AutoShopCarts
{
    public class AutoShopCartRepository : IAutoShopCartRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;
        private static string autoShopCartId;

        public AutoShopCartRepository(AutoShopDbContext autoShopDbContext)
        {
            this.autoShopDbContext = autoShopDbContext;
        }

        public static AutoShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            autoShopCartId = cartId;

            return new AutoShopCart { AutoShopCartId = cartId };
        }

        public void AddToCart(Car car)
        {
            autoShopDbContext.AutoShopCartItem.Add(new AutoShopCartItem
            {
                AutoShopCartId = autoShopCartId,
                Car = car,
                Price = car.Price
            });

            autoShopDbContext.SaveChanges();
        }

        public List<AutoShopCartItem> GetAutoShopItems()
        {
            return autoShopDbContext.AutoShopCartItem.Where(c => c.AutoShopCartId == autoShopCartId).Include(s => s.Car).ToList();
        }
    }
}
