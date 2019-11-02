namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakedReturningDateNullableTrue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "ReturningDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "ReturningDate", c => c.DateTime());
        }
    }
}
