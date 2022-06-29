namespace Data.DAL.Repositories
{
    public class StaffRepository : Repository<Staff>, IStaffRepository
    {
        public StaffRepository(DbContext context) : base(context) { }

        public ICollection<Staff> GetAll()
            => BikeStoresContext
            .Staffs
            .Include(s => s.Orders)
            .Include(s => s.InverseManager)
            .ToList();

        public ICollection<Staff> GetManagersByStaffId(int staffId)
            => BikeStoresContext
            .Staffs
            .Include(s => s.Orders)
            .Include(s => s.InverseManager)
            .FirstOrDefault(s => s.StaffId == staffId)
            .InverseManager;

        public ICollection<Order> GetOrderByStaffId(int staffId)
            => BikeStoresContext
                .Staffs
                .Include(s => s.Orders)
                .Include(s => s.InverseManager)
                .FirstOrDefault(s => s.StaffId == staffId)
                .Orders;

        public Staff GetSingle(Func<Staff, bool> condition)
            => BikeStoresContext
            .Staffs
            .Include(s => s.Orders)
            .Include(s => s.InverseManager)
            .FirstOrDefault(condition);
    }
}
