using DataLayer.Interfaces;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using AutoShop.ViewModels.OrderVM;

namespace AutoShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrdersRepository ordersRepository;
        private readonly IOrderFormValidator orderFormValidator;
        private readonly IOrderFormHandler orderFormHandler;
        private readonly AutoShopCart autoShopCart;

        public OrderController(IOrdersRepository ordersRepository, IOrderFormValidator orderFormValidator,
            IOrderFormHandler orderFormHandler, AutoShopCart autoShopCart)
        {
            this.ordersRepository = ordersRepository;
            this.orderFormValidator = orderFormValidator;
            this.orderFormHandler = orderFormHandler;
            this.autoShopCart = autoShopCart;
        }

        public IActionResult Checkout()
        {
            ViewBag.Title = "Заказ";

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(OrderFormHolder holder)
        {
            autoShopCart.ListAutoShopItems = autoShopCart.GetAutoShopItems();

            if (autoShopCart.ListAutoShopItems.Count == 0)
            {
                ModelState.AddModelError("EmptyCart", "Корзина не должна быть пустой!");
            }

            var validationResult = orderFormValidator.ValidateOnCheckout(holder.Form, ModelState);

            if (validationResult.ModelStateViewModel.IsValid)
            {
                orderFormHandler.HandleCheckout(holder.Form, validationResult);
                return RedirectToAction("Complete");
            }

            return View(holder.Form);
        }

        public IActionResult Complete()
        {
            ViewBag.Title = "Заказ";
            ViewBag.Message = "Заказ успешно обработан!";
            return View();
        }
    }
}
