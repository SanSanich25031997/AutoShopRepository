using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public interface IOrderFormBuilder
    {
        OrderForm Build(OrderFormHolder holder);
    }
}
