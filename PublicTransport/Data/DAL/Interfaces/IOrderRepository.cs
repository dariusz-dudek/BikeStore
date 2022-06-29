namespace Data.DAL.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        ICollection<OrderItem> GetOrderItemsByOrderId(int orderId);
        ICollection<Order> GetAll();
        Order GetSingle(Func<Order, bool> condition);
    }
}
