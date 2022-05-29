using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace ProductService.Data
{
    public class ProductServiceContext : DbContext
    {
        public ProductServiceContext (DbContextOptions<ProductServiceContext> options)
            : base(options)
        {
        }

        public DbSet<BusinessObjects.Product>? Product { get; set; }
    }
}
