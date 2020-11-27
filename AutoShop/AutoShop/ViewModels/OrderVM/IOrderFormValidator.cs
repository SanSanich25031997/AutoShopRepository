using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AutoShop.ViewModels.OrderVM
{
    public interface IOrderFormValidator
    {
        OrderValidationResult ValidateOnCheckout(OrderForm form, ModelStateDictionary modelState);
    }
}
