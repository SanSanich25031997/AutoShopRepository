namespace DataLayer.Entities.Categories
{
    public interface ICategoryFactory
    {
        Category Create(string name, string description);
    }
}
