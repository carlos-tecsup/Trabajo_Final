using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;

namespace INFRAESTRUCTURE
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext() : base("name = MyContextDB")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Invoice_detail> Invoice_Details { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
