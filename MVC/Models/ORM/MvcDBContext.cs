using Microsoft.EntityFrameworkCore;
using MVC.Models.ORM;

namespace MVC.Models.ORM
{
    public class MvcDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=MVCDB; trusted_connection=true;");
        }

        public DbSet<Client> Clients { get; set; }
    }
}
