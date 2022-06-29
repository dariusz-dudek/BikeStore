namespace Data.DAL.Interfaces
{
    public interface IBrandRepository : IRepository<Brand>
    {
        ICollection<Product> GetProductsByBrandId(int categoryId);
        ICollection<Brand> GetAll();
        Brand GetSingle(Func<Brand, bool> condition);

    }
}