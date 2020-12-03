using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderModel
    {
        public OrderForm Form { get; set; }

        public OrderModel(OrderForm form)
        {
            Form = form;
        }
    }
}
