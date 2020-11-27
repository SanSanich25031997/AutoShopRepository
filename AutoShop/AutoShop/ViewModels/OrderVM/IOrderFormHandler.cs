namespace AutoShop.ViewModels.OrderVM
{
    public interface IOrderFormHandler
    {
        void HandleCheckout(OrderForm form, OrderValidationResult validationResult);
    }
}
