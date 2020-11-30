using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.AutoShopCartVM.List
{
    public interface IAutoShopCartListViewModelBuilder
    {
        AutoShopCartListViewModel Build();
        void AddToCart(int id);
    }
}
