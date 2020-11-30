using System.Collections.Generic;
using DataLayer.Entities.Cars;

namespace AutoShop.ViewModels.HomeVM.List
{
    public class HomeListViewModel
    {
        public IEnumerable<Car> FavoriteCars { get; set; }
    }
}
