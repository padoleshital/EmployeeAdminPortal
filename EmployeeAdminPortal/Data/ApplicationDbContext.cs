using Microsoft.EntityFrameworkCore;
using EmployeeAdminPortal.Models.Entities;
namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext  // inherits from DbContext
    {
        // create a constructor that accepts DbContextOptions
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        // property to represent the Employees table
        public DbSet<Employee> Employees { get; set; }
    }
}
