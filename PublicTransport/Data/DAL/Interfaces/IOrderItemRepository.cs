namespace Data.DAL.Interfaces
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
        ICollection<OrderItem> GetAll();
        OrderItem GetSingle(Func<OrderItem, bool> condition);
    }
}
