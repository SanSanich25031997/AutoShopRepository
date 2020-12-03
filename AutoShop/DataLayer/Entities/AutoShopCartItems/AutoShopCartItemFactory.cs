using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.AutoShopCartItems
{
    public class AutoShopCartItemFactory : IAutoShopCartItemFactory
    {
        public AutoShopCartItem Create(int price, string autoShopCartId)
        {
            return new AutoShopCartItem
            {
                Id = Guid.NewGuid().ToString(),
                Price = price,
                AutoShopCartId = autoShopCartId
            };
        }
    }
}
