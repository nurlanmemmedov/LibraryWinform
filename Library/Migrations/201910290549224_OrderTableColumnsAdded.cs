namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderTableColumnsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "BookId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "ReturnDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "Cost", c => c.Decimal(nullable: false, storeType: "money"));
            AddColumn("dbo.Orders", "Returned", c => c.Boolean(nullable: false));
            AddColumn("dbo.Payments", "Pay", c => c.Decimal(nullable: false, storeType: "money"));
            CreateIndex("dbo.Orders", "ClientId");
            CreateIndex("dbo.Orders", "BookId");
            AddForeignKey("dbo.Orders", "BookId", "dbo.Books", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            DropColumn("dbo.Payments", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropColumn("dbo.Payments", "Pay");
            DropColumn("dbo.Orders", "Returned");
            DropColumn("dbo.Orders", "Cost");
            DropColumn("dbo.Orders", "ReturnDate");
            DropColumn("dbo.Orders", "OrderDate");
            DropColumn("dbo.Orders", "BookId");
            DropColumn("dbo.Orders", "ClientId");
        }
    }
}
