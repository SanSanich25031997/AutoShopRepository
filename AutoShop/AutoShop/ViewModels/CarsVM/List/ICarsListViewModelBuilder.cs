using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.CarsVM.List
{
    public interface ICarsListViewModelBuilder
    {
        CarsListViewModel Build(string category);
    }
}
