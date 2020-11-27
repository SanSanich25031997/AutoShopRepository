using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.ModelStateVM
{
    public class ModelStateViewModelBuilder : IModelStateViewModelBuilder
    {
        public ModelStateViewModel Build(ModelStateDictionary modelState)
        {
            return new ModelStateViewModel(modelState.IsValid,
               modelState.ToDictionary(x => x.Key,
               x => string.Join(", ", x.Value.Errors.Select(y => y.ErrorMessage).ToList())));
        }
    }
}
