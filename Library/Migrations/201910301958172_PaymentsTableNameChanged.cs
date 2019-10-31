namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentsTableNameChanged : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Payments", newName: "Reports");
            RenameColumn(table: "dbo.Reports", name: "UserId", newName: "ClientId");
            RenameIndex(table: "dbo.Reports", name: "IX_UserId", newName: "IX_ClientId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Reports", name: "IX_ClientId", newName: "IX_UserId");
            RenameColumn(table: "dbo.Reports", name: "ClientId", newName: "UserId");
            RenameTable(name: "dbo.Reports", newName: "Payments");
        }
    }
}
