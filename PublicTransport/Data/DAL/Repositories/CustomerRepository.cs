namespace Data.DAL.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context) { }

        public ICollection<Customer> GetAll()
            => BikeStoresContext
            .Customers
            .Include(c => c.Orders)
            .ToList();

        public ICollection<Order> GetOrdersByCustomerId(int customerId)
            => BikeStoresContext
            .Customers
            .Include(c => c.Orders)
            .FirstOrDefault(c => c.CustomerId == customerId)
            .Orders;

        public Customer GetSingle(Func<Customer, bool> condition)
            => BikeStoresContext
            .Customers
            .Include(c => c.Orders)
            .FirstOrDefault(condition);
    }
}
