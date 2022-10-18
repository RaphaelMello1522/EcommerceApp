using Ecommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData
        //}

        public DbSet<Product> Products { get; set; }
    }
}
