namespace Data.DAL.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        ICollection<OrderItem> GetOrderItemsByProductId(int productId);
        ICollection<Stock> GetStocksByProductId(int productId);
        ICollection<Product> GetAll();
        Product GetSingle(Func<Product, bool> condition);
    }
}
