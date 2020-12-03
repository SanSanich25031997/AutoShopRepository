namespace DataLayer.Entities.AutoShopCartItems
{
    public interface IAutoShopCartItemFactory
    {
        AutoShopCartItem Create(int price, string autoShopCartId);
    }
}
