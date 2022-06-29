namespace Data.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected BikeStoresContext BikeStoresContext { get => (BikeStoresContext)_context; }
        public Repository(DbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
            => _context.Set<T>().Add(entity);

        public void Delete(T entity)
            => _context.Set<T>().Remove(entity);

        public void Update(T entity)
            => _context.Set<T>().Update(entity);
    }
}
