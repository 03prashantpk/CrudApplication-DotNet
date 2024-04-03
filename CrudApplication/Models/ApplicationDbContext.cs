using Microsoft.EntityFrameworkCore;

namespace CrudApplication.Models
{
    public class ApplicationDbContext:DbContext
    {
        public  DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E1QKT31\\SQLEXPRESS;Database=CustCrudApp;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
