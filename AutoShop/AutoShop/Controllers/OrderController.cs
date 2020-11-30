using Microsoft.AspNetCore.Mvc;
using AutoShop.ViewModels.OrderVM.CreateEdit;
using DataLayer;

namespace AutoShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderFormValidator orderFormValidator;
        private readonly IOrderFormHandler orderFormHandler;
        private readonly AutoShopCart autoShopCart;

        public OrderController(IOrderFormValidator orderFormValidator,
            IOrderFormHandler orderFormHandler, AutoShopCart autoShopCart)
        {
            this.orderFormValidator = orderFormValidator;
            this.orderFormHandler = orderFormHandler;
            this.autoShopCart = autoShopCart;
        }

        public IActionResult Checkout()
        {
            orderFormValidator.ValidateOnCheckout(ModelState);

            ViewBag.Title = "Заказ";

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(OrderFormHolder holder)
        {
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
