using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFExample.cs
{
    class CustomerContext:DbContext
    {
        public CustomerContext() : base("CustomerContext") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
