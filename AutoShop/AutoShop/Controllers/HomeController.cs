using Microsoft.AspNetCore.Mvc;
using AutoShop.ViewModels.HomeVM.List;

namespace AutoShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeListViewModelBuilder homeListViewModelBuilder;

        public HomeController(IHomeListViewModelBuilder homeListViewModelBuilder)
        {
            this.homeListViewModelBuilder = homeListViewModelBuilder;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Главная страница";

            return View(homeListViewModelBuilder.Build());
        }
    }
}
