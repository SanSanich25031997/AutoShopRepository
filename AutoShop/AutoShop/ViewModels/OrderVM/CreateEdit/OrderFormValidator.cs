using Microsoft.AspNetCore.Mvc.ModelBinding;
using AutoShop.Core.Validation;
using DataLayer;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderFormValidator : IOrderFormValidator
    {
        private readonly IModelStateViewModelBuilder modelStateViewModelBuilder;
        private readonly AutoShopCart autoShopCart;

        public OrderFormValidator(IModelStateViewModelBuilder modelStateViewModelBuilder, AutoShopCart autoShopCart)
        {
            this.modelStateViewModelBuilder = modelStateViewModelBuilder;
            this.autoShopCart = autoShopCart;
        }

        public OrderValidationResult ValidateOnCheckout(ModelStateDictionary modelState)
        {
            autoShopCart.ListAutoShopItems = autoShopCart.GetAutoShopItems();

            if (autoShopCart.ListAutoShopItems.Count == 0)
            {
                modelState.AddModelError("EmptyCart", "Корзина не должна быть пустой!");
            }

            return new OrderValidationResult(modelStateViewModelBuilder.Build(modelState));
        }

        public OrderValidationResult ValidateOnCheckout(OrderForm form, ModelStateDictionary modelState)
        {
            if (form.Address.Length < 3)
            {
                modelState.AddModelError("LengthError", "Адрес должен содержать минимум 3 символа!");
            }

            if (form.Phone.Length < 3)
            {
                modelState.AddModelError("LengthError", "Длина номера телефона должна составлять минимум 3 символа!");
            }

            if (form.Email.Length < 5)
            {
                modelState.AddModelError("LengthError", "Длина email должна составлять минимум 5 символов!");
            }

            return new OrderValidationResult(modelStateViewModelBuilder.Build(modelState));
        }
    }
}
