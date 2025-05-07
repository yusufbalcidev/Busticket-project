namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkattribte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "DateTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
