using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDbLib
{
    public partial class Customer
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
