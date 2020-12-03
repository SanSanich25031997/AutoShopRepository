using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderModelBuilder : IOrderModelBuilder
    {
        public OrderModel BuildByForm(OrderForm form)
        {
            return new OrderModel(form);
        }
    }
}
