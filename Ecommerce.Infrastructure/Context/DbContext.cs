// Dosya: Ecommerce.Infrastructure.Context/EcommerceDbContext.cs
using Microsoft.EntityFrameworkCore;
using Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.Infrastructure.Context
{
    public class EcommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public EcommerceDbContext() { }

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
        }
    }
}
