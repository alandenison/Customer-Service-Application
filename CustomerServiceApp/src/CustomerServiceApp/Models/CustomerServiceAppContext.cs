using Microsoft.EntityFrameworkCore;

namespace CustomerServiceApp.Models
{
    public class CustomerServiceAppContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CustomerServiceApp;integrated security=True");
        }
    }
}