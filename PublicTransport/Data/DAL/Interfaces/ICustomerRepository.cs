namespace Data.DAL.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        ICollection<Order> GetOrdersByCustomerId(int customerId);
        ICollection<Customer> GetAll();
        Customer GetSingle(Func<Customer, bool> condition);
    }
}
