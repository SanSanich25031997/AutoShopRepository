using AutoShop.Core.Validation;

namespace AutoShop.ViewModels.OrderVM.CreateEdit
{
    public class OrderValidationResult
    {
        public ModelStateViewModel ModelStateViewModel { get; set; }

        public OrderValidationResult(ModelStateViewModel modelStateViewModel)
        {
            ModelStateViewModel = modelStateViewModel;
        }
    }
}
