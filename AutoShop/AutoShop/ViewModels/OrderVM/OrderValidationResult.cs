using AutoShop.ViewModels.ModelStateVM;

namespace AutoShop.ViewModels.OrderVM
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
