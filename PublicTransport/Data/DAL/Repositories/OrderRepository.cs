namespace Data.DAL.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context) { }

        public ICollection<Order> GetAll()
            => BikeStoresContext
            .Orders
            .Include(o => o.OrderItems)
            .ToList();

        public ICollection<OrderItem> GetOrderItemsByOrderId(int orderId)
            => BikeStoresContext
            .Orders
            .Include(o => o.OrderItems)
            .FirstOrDefault(o => o.OrderId == orderId)
            .OrderItems;

        public Order GetSingle(Func<Order, bool> condition)
            => BikeStoresContext
            .Orders
            .Include(o => o.OrderItems)
            .FirstOrDefault(condition);
    }
}
