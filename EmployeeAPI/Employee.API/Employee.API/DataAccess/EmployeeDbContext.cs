using Microsoft.EntityFrameworkCore;

namespace Employee.API.DataAccess
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Employee> Employees { get; set; }
    }
}
