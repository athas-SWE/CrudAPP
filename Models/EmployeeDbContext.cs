using Microsoft.EntityFrameworkCore;

namespace Task_EMPLOYEE.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=employee; User Id=admin; password=Kalmunai123*; TrustServerCertificate= True");
        }
    }
}
