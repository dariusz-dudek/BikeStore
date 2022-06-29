namespace Data.DAL.Repositories
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(DbContext context) : base(context) { }

        public ICollection<Store> GetAll()
            => BikeStoresContext
            .Stores
            .Include(s => s.Orders)
            .Include(s => s.Stocks)
            .Include(s => s.staff)
            .ToList();

        public ICollection<Order> GetOrdersByStoreId(int storeId)
            => BikeStoresContext
            .Stores
            .Include(s => s.Orders)
            .Include(s => s.Stocks)
            .Include(s => s.staff)
            .FirstOrDefault(s => s.StoreId == storeId)
            .Orders;

        public Store GetSingle(Func<Store, bool> condition)
            => BikeStoresContext
            .Stores
            .Include(s => s.Orders)
            .Include(s => s.Stocks)
            .Include(s => s.staff)
            .FirstOrDefault(condition);

        public ICollection<Staff> GetStaffsByStoreId(int storeId)
            => BikeStoresContext
            .Stores
            .Include(s => s.Orders)
            .Include(s => s.Stocks)
            .Include(s => s.staff)
            .FirstOrDefault(s => s.StoreId == storeId)
            .staff;

        public ICollection<Stock> GetStockByStoreId(int storeId)
            => BikeStoresContext
            .Stores
            .Include(s => s.Orders)
            .Include(s => s.Stocks)
            .Include(s => s.staff)
            .FirstOrDefault(s => s.StoreId == storeId)
            .Stocks;
    }
}
