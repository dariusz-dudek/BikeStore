namespace Data.DAL.Interfaces
{
    public interface IStoreRepository : IRepository<Store>
    {
        ICollection<Order> GetOrdersByStoreId(int storeId);
        ICollection<Stock> GetStockByStoreId(int storeId);
        ICollection<Staff> GetStaffsByStoreId(int storeId);
        ICollection<Store> GetAll();
        Store GetSingle(Func<Store, bool> condition);
    }
}
