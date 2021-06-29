using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

    }
}
