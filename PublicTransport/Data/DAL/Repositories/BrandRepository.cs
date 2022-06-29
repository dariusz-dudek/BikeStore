namespace Data.DAL.Repositories
{

    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(DbContext context) : base(context) { }

        public ICollection<Brand> GetAll()
            => BikeStoresContext
            .Brands
            .Include(br => br.Products)
            .ToList();


        public ICollection<Product> GetProductsByBrandId(int brandId)
            => BikeStoresContext
            .Brands
            .Include(br => br.Products)
            .FirstOrDefault(br => br.BrandId == brandId)
            .Products;

        public Brand? GetSingle(Func<Brand, bool> condition)
            => BikeStoresContext
            .Brands
            .Include(br => br.Products)
            .FirstOrDefault(condition);
    }
}
