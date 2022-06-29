namespace Data.DAL.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context) { }

        public ICollection<Product> GetAll()
            => BikeStoresContext
            .Products
            .Include(p => p.OrderItems)
            .Include(p => p.Stocks)
            .ToList();


        public ICollection<OrderItem> GetOrderItemsByProductId(int productId)
            => BikeStoresContext
            .Products
            .Include(p => p.OrderItems)
            .Include(p => p.Stocks)
            .FirstOrDefault(p => p.ProductId == productId)
            .OrderItems;

        public Product GetSingle(Func<Product, bool> condition)
            => BikeStoresContext
            .Products
            .Include(p => p.OrderItems)
            .Include(p => p.Stocks)
            .FirstOrDefault(condition);

        public ICollection<Stock> GetStocksByProductId(int productId)
        => BikeStoresContext
            .Products
            .Include(p => p.OrderItems)
            .Include(p => p.Stocks)
            .FirstOrDefault(p => p.ProductId == productId)
            .Stocks;
    }
}
