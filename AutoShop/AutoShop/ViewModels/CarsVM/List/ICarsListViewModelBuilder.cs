namespace AutoShop.ViewModels.CarsVM.List
{
    public interface ICarsListViewModelBuilder
    {
        CarsListViewModel Build(string category);
    }
}
