using Microsoft.AspNetCore.Mvc;
using AutoShop.ViewModels.AutoShopCartVM.List;

namespace AutoShop.Controllers
{
    public class AutoShopCartController : Controller
    {
        private readonly IAutoShopCartListViewModelBuilder autoShopCartListViewModelBuilder;

        public AutoShopCartController(IAutoShopCartListViewModelBuilder autoShopCartListViewModelBuilder)
        {
            this.autoShopCartListViewModelBuilder = autoShopCartListViewModelBuilder;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Корзина";

            return View(autoShopCartListViewModelBuilder.Build());
        }

        public RedirectToActionResult AddToCart(int id)
        {
            autoShopCartListViewModelBuilder.AddToCart(id);

            return RedirectToAction("Index");
        }
    }
}
