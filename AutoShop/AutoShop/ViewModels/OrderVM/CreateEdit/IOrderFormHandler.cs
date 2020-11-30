namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public interface IOrderFormHandler
    {
        void HandleCheckout(OrderForm form, OrderValidationResult validationResult);
    }
}
