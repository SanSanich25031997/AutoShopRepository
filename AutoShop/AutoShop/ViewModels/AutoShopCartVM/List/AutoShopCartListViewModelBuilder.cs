using System.Linq;
using DataLayer.Entities.Cars;
using DataLayer.Entities.AutoShopCarts;

namespace AutoShop.ViewModels.AutoShopCartVM.List
{
    public class AutoShopCartListViewModelBuilder : IAutoShopCartListViewModelBuilder
    {
        private readonly ICarRepository carRepository;
        private readonly IAutoShopCartRepository autoShopCartRepository;

        public AutoShopCartListViewModelBuilder(ICarRepository carRepository, IAutoShopCartRepository autoShopCartRepository)
        {
            this.carRepository = carRepository;
            this.autoShopCartRepository = autoShopCartRepository;
        }

        public AutoShopCartListViewModel Build()
        {
            return new AutoShopCartListViewModel
            {
                AutoShopCartItems = autoShopCartRepository.GetAutoShopItems()
        };
        }

        public void AddToCart(int id)
        {
            var item = carRepository.Cars.FirstOrDefault(i => i.Id == id);

            if (item != null)
            {
                autoShopCartRepository.AddToCart(item);
            }
        }
    }
}
