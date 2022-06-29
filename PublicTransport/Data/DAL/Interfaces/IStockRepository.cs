namespace Data.DAL.Interfaces
{
    public interface IStockRepository : IRepository<Stock>
    {
        ICollection<Stock> GetAll();
        Stock GetSingle(Func<Stock, bool> condition);
    }
}
