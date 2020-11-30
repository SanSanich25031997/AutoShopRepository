using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace AutoShop.Core.Validation
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
