using System.Collections.Generic;
using DataLayer.Entities.Cars;
using DataLayer.Entities.Categories;
using DataLayer.Dictonaries;

namespace AutoShop.ViewModels.CarsVM.List
{
    public class CarsListViewModelBuilder : ICarsListViewModelBuilder
    {
        private readonly ICarRepository carRepository;
        private readonly ICategoryRepository categoryRepository;

        public CarsListViewModelBuilder(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            this.carRepository = carRepository;
            this.categoryRepository = categoryRepository;
        }

        public CarsListViewModel Build(string category)
        {
            string carCategory = string.IsNullOrEmpty(category) ? "" :
                CarsMathing.CarsMatchingDictionary[category];
            IEnumerable<Car> cars = carRepository.FindCarsByCategory(carCategory);

            return new CarsListViewModel
            {
                AllCars = cars,
                CarCategory = carCategory
            };
        }
    }
}
