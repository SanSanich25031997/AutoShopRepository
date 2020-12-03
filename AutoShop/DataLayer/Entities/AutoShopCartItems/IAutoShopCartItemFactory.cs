using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.AutoShopCartItems
{
    public interface IAutoShopCartItemFactory
    {
        AutoShopCartItem Create(int price, string autoShopCartId);
    }
}
