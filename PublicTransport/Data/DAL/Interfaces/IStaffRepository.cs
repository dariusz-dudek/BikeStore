namespace Data.DAL.Interfaces
{
    public interface IStaffRepository : IRepository<Staff>
    {
        ICollection<Order> GetOrderByStaffId(int staffId);
        ICollection<Staff> GetManagersByStaffId(int staffId);
        ICollection<Staff> GetAll();
        Staff GetSingle(Func<Staff, bool> condition);
    }
}
