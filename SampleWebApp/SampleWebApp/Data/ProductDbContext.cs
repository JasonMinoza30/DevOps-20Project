using Microsoft.EntityFrameworkCore;
using SampleWebApp.Models;
using System.Collections.Generic;

namespace SampleWebApp.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Products> Product { get; set; }
    }
}
