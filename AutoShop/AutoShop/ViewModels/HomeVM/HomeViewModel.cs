using System.Collections.Generic;
using DataLayer.Entities;

namespace AutoShop.ViewModels.HomeVM
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavoriteCars { get; set; }
    }
}
