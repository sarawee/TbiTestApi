using Microsoft.EntityFrameworkCore;
using TbiTestApi.Models;

namespace TbiTestApi.Entities
{
	public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
    }
}

