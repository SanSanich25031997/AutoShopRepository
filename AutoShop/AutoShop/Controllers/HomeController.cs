using Microsoft.AspNetCore.Mvc;
using DataLayer.Interfaces;
using AutoShop.ViewModels.HomeVM;

namespace AutoShop.Controllers
{
    public class HomeController : Controller
    {
        private ICarsRepository carsRepository;

        public HomeController(ICarsRepository carsRepository)
        {
            this.carsRepository = carsRepository;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavoriteCars = carsRepository.GetFavoriteCars
            };

            ViewBag.Title = "Главная страница";

            return View(homeCars);
        }
    }
}
