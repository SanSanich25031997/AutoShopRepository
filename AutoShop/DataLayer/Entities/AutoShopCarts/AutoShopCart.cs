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
    public class AutoShopCart
    {
        public string AutoShopCartId { get; set; }
        public List<AutoShopCartItem> ListAutoShopItems { get; set; }
    }
}
