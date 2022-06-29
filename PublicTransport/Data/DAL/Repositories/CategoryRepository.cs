namespace Data.DAL.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context) { }

        public ICollection<Category> GetAll()
            => BikeStoresContext
            .Categories
            .Include(c => c.Products)
            .ToList();

        public ICollection<Product> GetProductsByCategoryId(int categoryId)
            => BikeStoresContext
            .Categories
            .Include(c => c.Products)
            .FirstOrDefault(c => c.CategoryId == categoryId)
            .Products;

        public Category? GetSingle(Func<Category, bool> condition)
            => BikeStoresContext
            .Categories
            .Include(c => c.Products)
            .FirstOrDefault(condition);
    }
}
