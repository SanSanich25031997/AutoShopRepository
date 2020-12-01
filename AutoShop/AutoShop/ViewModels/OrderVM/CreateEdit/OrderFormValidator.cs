using Microsoft.AspNetCore.Mvc.ModelBinding;
using AutoShop.Core.Validation;
using DataLayer.Entities.AutoShopCarts;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderFormValidator : IOrderFormValidator
    {
        private readonly IModelStateViewModelBuilder modelStateViewModelBuilder;
        private readonly IAutoShopCartRepository autoShopCartRepository;

        public OrderFormValidator(IModelStateViewModelBuilder modelStateViewModelBuilder, IAutoShopCartRepository autoShopCartRepository)
        {
            this.modelStateViewModelBuilder = modelStateViewModelBuilder;
            this.autoShopCartRepository = autoShopCartRepository;
        }

        public OrderValidationResult ValidateOnCheckout(OrderForm form, ModelStateDictionary modelState)
        {
            if (autoShopCartRepository.GetAutoShopItems().Count == 0)
            {
                modelState.AddModelError("EmptyCart", "Корзина не должна быть пустой!");
            }

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
