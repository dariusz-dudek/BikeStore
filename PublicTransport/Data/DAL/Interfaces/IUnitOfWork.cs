namespace Data.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBrandRepository Brand { get; }
        ICategoryRepository Category { get; }
        ICustomerRepository Customer { get; }
        IOrderItemRepository OrderItem { get; }
        IOrderRepository Order { get; }
        IProductRepository Product { get; }
        IStaffRepository Staff { get; }
        IStockRepository Stock { get; }
        IStoreRepository Store { get; }
        int CompleteUnit();
    }
}
