using DataLayer.Repository;

namespace AutoShop.ViewModels.OrderVM
{
    public class OrderFormHandler : IOrderFormHandler
    {
        private readonly OrdersRepository ordersRepository;

        public OrderFormHandler(OrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }

        public void HandleCheckout(OrderForm form, OrderValidationResult validationResult)
        {
            ordersRepository.CreateOrder(form.Id, form.Name, form.Name, form.Address, form.Phone, form.Email);
        }
    }
}
