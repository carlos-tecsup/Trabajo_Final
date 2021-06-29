namespace InvoiceWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int ID { get; set; }

        public string name { get; set; }

        public string lastname { get; set; }

        public string address { get; set; }

    }
}
