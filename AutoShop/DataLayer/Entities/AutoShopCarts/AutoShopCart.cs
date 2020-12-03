using System.Collections.Generic;
using DataLayer.Entities.AutoShopCartItems;

namespace DataLayer.Entities.AutoShopCarts
{
    public class AutoShopCart
    {
        public string AutoShopCartId { get; set; }
        public List<AutoShopCartItem> ListAutoShopItems { get; set; }
    }
}
