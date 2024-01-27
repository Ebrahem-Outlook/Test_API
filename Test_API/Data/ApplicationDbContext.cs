using Microsoft.EntityFrameworkCore;
using Test_API.Models;

namespace Test_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
