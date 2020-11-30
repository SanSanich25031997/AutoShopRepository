using System.Collections.Generic;
using DataLayer.Entities.Cars;

namespace AutoShop.ViewModels.CarsVM.List
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string CarCategory { get; set; }
    }
}
