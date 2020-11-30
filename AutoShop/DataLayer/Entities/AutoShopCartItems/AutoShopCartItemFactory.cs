using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.AutoShopCartItems
{
    public class AutoShopCartItemFactory : IAutoShopCartItemFactory
    {
        public AutoShopCartItem Create(int id, int price, string autoShopCartId)
        {
            return new AutoShopCartItem
            {
                Id = id,
                Price = price,
                AutoShopCartId = autoShopCartId
            };
        }
    }
}
