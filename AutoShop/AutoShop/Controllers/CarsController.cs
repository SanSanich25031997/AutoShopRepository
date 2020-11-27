using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Dictonaries;
using AutoShop.ViewModels.CarsVM;

namespace AutoShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsRepository carsRepository;
        private readonly ICarCategoriesRepository carCategoriesRepository;

        public CarsController(ICarsRepository carsRepository, ICarCategoriesRepository carCategoriesRepository)
        {
            this.carsRepository = carsRepository;
            this.carCategoriesRepository = carCategoriesRepository;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string carCategory = string.IsNullOrEmpty(category) ? "" :
                CarsMathing.CarsMatchingDictionary[category];
            IEnumerable<Car> cars = carsRepository.FindCarsByCategory(carCategory);
            var carObject = new CarsListViewModel
            {
                AllCars = cars,
                CarCategory = carCategory
            };

            ViewBag.Title = string.IsNullOrEmpty(carCategory) 
                ? "Автомобили" : carCategory;

            return View(carObject);
        }
    }
}
