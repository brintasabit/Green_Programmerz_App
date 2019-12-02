namespace GreenProgrammerz.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Code = c.String(),
                        Name = c.String(),
                        ReOrderLevel = c.String(),
                        Description = c.String(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.PurchaseDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        BillInvoice = c.String(),
                        SupplierName = c.String(),
                        Category = c.String(),
                        Products = c.String(),
                        Code = c.String(),
                        AvailableQuantity = c.Double(nullable: false),
                        ManufacturedDate = c.String(),
                        ExpireDate = c.String(),
                        Remarks = c.String(),
                        Quantity = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        PreviousUnitPrice = c.Double(nullable: false),
                        PreviousMRP = c.Double(nullable: false),
                        MRP = c.Double(nullable: false),
                        Purchase_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        BillInvoiceNo = c.String(),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        ContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseDetails", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.Products", "Product_Id", "dbo.Products");
            DropIndex("dbo.PurchaseDetails", new[] { "Purchase_Id" });
            DropIndex("dbo.Products", new[] { "Product_Id" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Purchases");
            DropTable("dbo.PurchaseDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
