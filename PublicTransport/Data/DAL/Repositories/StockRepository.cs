namespace Data.DAL.Repositories
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        public StockRepository(DbContext context) : base(context) { }

        public ICollection<Stock> GetAll()
            => BikeStoresContext
            .Stocks
            .ToList();

        public Stock GetSingle(Func<Stock, bool> condition)
            => BikeStoresContext
            .Stocks
            .FirstOrDefault(condition);
    }
}
