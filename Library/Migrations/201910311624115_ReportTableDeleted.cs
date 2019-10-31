namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReportTableDeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reports", "BookId", "dbo.Books");
            DropForeignKey("dbo.Reports", "ClientId", "dbo.Clients");
            DropIndex("dbo.Reports", new[] { "ClientId" });
            DropIndex("dbo.Reports", new[] { "BookId" });
            DropColumn("dbo.Orders", "OrderId");
            DropColumn("dbo.Orders", "MyProperty");
            DropTable("dbo.Reports");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Pay = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "MyProperty", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reports", "BookId");
            CreateIndex("dbo.Reports", "ClientId");
            AddForeignKey("dbo.Reports", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reports", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
