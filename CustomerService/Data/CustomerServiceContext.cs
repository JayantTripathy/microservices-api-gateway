using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace CustomerService.Data
{
    public class CustomerServiceContext : DbContext
    {
        public CustomerServiceContext (DbContextOptions<CustomerServiceContext> options)
            : base(options)
        {
        }

        public DbSet<BusinessObjects.Customer>? Customer { get; set; }
    }
}
