namespace Data.DAL.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        ICollection<Product> GetProductsByCategoryId(int categoryId);
        ICollection<Category> GetAll();
        Category GetSingle(Func<Category, bool> condition);
    }
}
