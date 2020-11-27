using Microsoft.AspNetCore.Mvc.ModelBinding;
using AutoShop.ViewModels.ModelStateVM;

namespace AutoShop.ViewModels.OrderVM
{
    public class OrderFormValidator : IOrderFormValidator
    {
        private readonly IModelStateViewModelBuilder modelStateViewModelBuilder;

        public OrderFormValidator(IModelStateViewModelBuilder modelStateViewModelBuilder)
        {
            this.modelStateViewModelBuilder = modelStateViewModelBuilder;
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

            if(form.Email.Length < 5)
            {
                modelState.AddModelError("LengthError", "Длина email должна составлять минимум 5 символов!");
            }

            return new OrderValidationResult(modelStateViewModelBuilder.Build(modelState));
        }
    }
}
