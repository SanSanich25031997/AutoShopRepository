using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.ModelStateVM
{
    public interface IModelStateViewModelBuilder
    {
        ModelStateViewModel Build(ModelStateDictionary modelState);
    }
}
