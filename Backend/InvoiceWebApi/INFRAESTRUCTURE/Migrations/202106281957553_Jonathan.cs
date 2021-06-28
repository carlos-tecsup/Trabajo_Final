namespace INFRAESTRUCTURE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Jonathan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        lastname = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        creation_date = c.DateTime(nullable: false),
                        state = c.String(),
                        total = c.Double(nullable: false),
                        address = c.String(),
                        folio = c.String(),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Invoice_detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        sub_total = c.Double(nullable: false),
                        price = c.Double(nullable: false),
                        ProductID = c.Int(nullable: false),
                        InvoiceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.InvoiceID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoice_detail", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Invoice_detail", "InvoiceID", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Invoice_detail", new[] { "InvoiceID" });
            DropIndex("dbo.Invoice_detail", new[] { "ProductID" });
            DropIndex("dbo.Invoices", new[] { "CustomerID" });
            DropTable("dbo.Products");
            DropTable("dbo.Invoice_detail");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
        }
    }
}
