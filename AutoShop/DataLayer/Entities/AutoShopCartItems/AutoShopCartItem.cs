using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities.Cars;

namespace DataLayer.Entities.AutoShopCartItems
{
    public class AutoShopCartItem
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Price { get; set; }
        public string AutoShopCartId { get; set; }
    }
}
