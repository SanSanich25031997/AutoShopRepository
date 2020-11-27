namespace DataLayer.Entities
{
    public class AutoShopCartItem
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public int Price { get; set; }
        public string AutoShopCartId { get; set; }
    }
}
