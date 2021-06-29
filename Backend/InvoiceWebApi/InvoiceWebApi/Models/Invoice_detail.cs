namespace InvoiceWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoice_detail
    {
        public int ID { get; set; }

        public double quantity { get; set; }

        public double sub_total { get; set; }

        public double price { get; set; }

        public int ProductID { get; set; }

        public int InvoiceID { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
