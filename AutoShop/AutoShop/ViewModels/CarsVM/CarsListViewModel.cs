using System.Collections.Generic;
using DataLayer.Entities;

namespace AutoShop.ViewModels.CarsVM
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string CarCategory { get; set; }
    }
}
