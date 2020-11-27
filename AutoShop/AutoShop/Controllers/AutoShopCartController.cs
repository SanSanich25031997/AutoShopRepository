using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Repository;
using DataLayer.Interfaces;
using DataLayer.Entities;
using AutoShop.ViewModels.AutoShopCartVM;

namespace AutoShop.Controllers
{
    public class AutoShopCartController : Controller
    {
        private readonly ICarsRepository carRepository;
        private readonly AutoShopCart autoShopCart;

        public AutoShopCartController(ICarsRepository carRepository, AutoShopCart autoShopCart)
        {
            this.carRepository = carRepository;
            this.autoShopCart = autoShopCart;
        }

        public ViewResult Index()
        {
            var items = autoShopCart.GetAutoShopItems();
            autoShopCart.ListAutoShopItems = items;
            var obj = new AutoShopCartViewModel
            {
                AutoShopCart = autoShopCart
            };

            ViewBag.Title = "Корзина";

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = carRepository.Cars.FirstOrDefault(i => i.Id == id);

            if (item != null)
            {
                autoShopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
