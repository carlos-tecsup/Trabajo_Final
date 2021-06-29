using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Invoice_detail
    {
        [Key]
        public int ID { get; set; }
        public double quantity { get; set; }
        public double sub_total { get; set; }
        public double price { get; set; }

        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public int InvoiceID { get; set; }

        [ForeignKey("InvoiceID")]
        public virtual Invoice Invoice { get; set; }


    }
}
