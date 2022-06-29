

namespace Data.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly BikeStoresContext _context;
        public IBrandRepository Brand { get; }

        public ICategoryRepository Category { get; }

        public ICustomerRepository Customer { get; }

        public IOrderItemRepository OrderItem { get; }

        public IOrderRepository Order { get; }

        public IProductRepository Product { get; }

        public IStaffRepository Staff { get; }

        public IStockRepository Stock { get; }

        public IStoreRepository Store { get; }

        public UnitOfWork(BikeStoresContext context)
        {
            _context = context;
            Brand = new BrandRepository(_context);
            Category = new CategoryRepository(_context);
            Customer = new CustomerRepository(_context);
            OrderItem = new OrderItemRepository(_context);
            Order = new OrderRepository(_context);
            Product = new ProductRepository(_context);
            Staff = new StaffRepository(_context);
            Stock = new StockRepository(_context);
            Store = new StoreRepository(_context);
        }

        public int CompleteUnit()
            => _context.SaveChanges();

        public void Dispose()
        {
            _context.ChangeTracker.Clear();
            GC.SuppressFinalize(this);
        }
    }
}
