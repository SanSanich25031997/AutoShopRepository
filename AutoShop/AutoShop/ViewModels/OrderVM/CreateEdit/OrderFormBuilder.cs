namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderFormBuilder : IOrderFormBuilder
    {
        private readonly IOrderFormValidator orderFormValidator;
        private readonly IOrderFormHandler orderFormHandler;

        public OrderFormBuilder(IOrderFormValidator orderFormValidator, IOrderFormHandler orderFormHandler)
        {
            this.orderFormValidator = orderFormValidator;
            this.orderFormHandler = orderFormHandler;
        }

        public OrderForm Build(OrderFormHolder holder)
        {
            return holder.Form;
        }
    }
}
