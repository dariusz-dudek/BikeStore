namespace Data.DAL.Repositories
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(DbContext context) : base(context) { }

        public ICollection<OrderItem> GetAll()
            => BikeStoresContext
            .OrderItems
            .ToList();

        public OrderItem GetSingle(Func<OrderItem, bool> condition)
            => BikeStoresContext
            .OrderItems
            .FirstOrDefault(condition);
    }
}
