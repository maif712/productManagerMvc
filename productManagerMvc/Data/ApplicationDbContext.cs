using Microsoft.EntityFrameworkCore;
using productManagerMvc.Models;

namespace productManagerMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Making Product table into database
        public DbSet<Product> Products { get; set; }
    }
}
