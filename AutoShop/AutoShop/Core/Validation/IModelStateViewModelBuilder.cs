using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AutoShop.Core.Validation
{
    public interface IModelStateViewModelBuilder
    {
        ModelStateViewModel Build(ModelStateDictionary modelState);
    }
}
