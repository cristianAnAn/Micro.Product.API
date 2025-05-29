using Microsoft.EntityFrameworkCore;
using Micro.Product.API.Models;
namespace Micro.Product.API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        { }
        public DbSet<Micro.Product.API.Models.Product> Productos { get; set; }
    }
}
