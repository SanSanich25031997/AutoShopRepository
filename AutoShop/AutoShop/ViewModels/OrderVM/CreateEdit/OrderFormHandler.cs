using DataLayer.Entities.Orders;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderFormHandler : IOrderFormHandler
    {
        private readonly OrderRepository orderRepository;

        public OrderFormHandler(OrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void HandleCheckout(OrderForm form, OrderValidationResult validationResult)
        {
            orderRepository.CreateOrder(form.FirstName, form.LastName, form.Address, form.Phone, form.Email);
        }
    }
}
