using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDbLib
{
    public class PersonalContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Order_Details { get; set; }

        public PersonalContext() { }
        public PersonalContext(string NameOrConnectionString) : base("PersonalContext") { }
    }
}
