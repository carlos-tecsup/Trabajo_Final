using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public DateTime creation_date { get; set; }
        public string state { get; set; }
        public double total { get; set; }
        public string address { get; set; }
        public string folio { get; set; }
        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Invoice_detail> Invoice_details { get; set; }

    }
}
