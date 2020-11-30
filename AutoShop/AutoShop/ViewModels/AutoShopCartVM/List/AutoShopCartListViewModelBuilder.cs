using System.Linq;
using DataLayer.Entities.Cars;
using DataLayer;

namespace AutoShop.ViewModels.AutoShopCartVM.List
{
    public class AutoShopCartListViewModelBuilder : IAutoShopCartListViewModelBuilder
    {
        private readonly ICarRepository carRepository;
        private readonly AutoShopCart autoShopCart;

        public AutoShopCartListViewModelBuilder(ICarRepository carRepository, AutoShopCart autoShopCart)
        {
            this.carRepository = carRepository;
            this.autoShopCart = autoShopCart;
        }

        public AutoShopCartListViewModel Build()
        {
            var items = autoShopCart.GetAutoShopItems();
            autoShopCart.ListAutoShopItems = items;

            return new AutoShopCartListViewModel
            {
                AutoShopCart = autoShopCart
            };
        }

        public void AddToCart(int id)
        {
            var item = carRepository.Cars.FirstOrDefault(i => i.Id == id);

            if (item != null)
            {
                autoShopCart.AddToCart(item);
            }
        }
    }
}
