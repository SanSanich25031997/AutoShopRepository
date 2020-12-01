using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public interface IOrderFormValidator
    {
        OrderValidationResult ValidateOnCheckout(OrderForm form, ModelStateDictionary modelState);
    }
}
