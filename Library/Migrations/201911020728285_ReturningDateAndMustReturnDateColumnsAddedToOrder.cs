namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturningDateAndMustReturnDateColumnsAddedToOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "ReturningDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "ReturningDate", c => c.DateTime(nullable: false));
        }
    }
}
