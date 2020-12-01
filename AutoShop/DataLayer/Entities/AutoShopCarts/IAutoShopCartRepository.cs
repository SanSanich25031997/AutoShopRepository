using System.Collections.Generic;
using DataLayer.Entities.Cars;
using DataLayer.Entities.AutoShopCartItems;

namespace DataLayer.Entities.AutoShopCarts
{
    public interface IAutoShopCartRepository
    {
        void AddToCart(Car car);
        List<AutoShopCartItem> GetAutoShopItems();
    }
}
