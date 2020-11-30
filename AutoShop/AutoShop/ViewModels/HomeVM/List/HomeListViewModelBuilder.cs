using DataLayer.Entities.Cars;

namespace AutoShop.ViewModels.HomeVM.List
{
    public class HomeListViewModelBuilder : IHomeListViewModelBuilder
    {
        private readonly ICarRepository carRepository;

        public HomeListViewModelBuilder(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public HomeListViewModel Build()
        {
            return new HomeListViewModel
            {
                FavoriteCars = carRepository.GetFavoriteCars
            };
        }
    }
}
