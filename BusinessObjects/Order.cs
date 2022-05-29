using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public Product Product { get; set; }
    }
}
