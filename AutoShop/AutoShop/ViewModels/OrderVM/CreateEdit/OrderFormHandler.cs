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
            orderRepository.CreateOrder(form.Id, form.FirstName, form.FirstName, form.Address, form.Phone, form.Email);
        }
    }
}
