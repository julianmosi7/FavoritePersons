using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDbLib
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Amount { get; set; }

        public virtual Order Order { get; set; }
    }
}
