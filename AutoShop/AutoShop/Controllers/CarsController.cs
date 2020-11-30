using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Entities.Cars;
using DataLayer.Dictonaries;
using AutoShop.ViewModels.CarsVM.List;

namespace AutoShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsListViewModelBuilder carsListViewModelBuilder;

        public CarsController(ICarsListViewModelBuilder carsListViewModelBuilder)
        {
            this.carsListViewModelBuilder = carsListViewModelBuilder;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            ViewBag.Title = string.IsNullOrEmpty(category) 
                ? "Автомобили" : CarsMathing.CarsMatchingDictionary[category];

            return View(carsListViewModelBuilder.Build(category));
        }
    }
}
