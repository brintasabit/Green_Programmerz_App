namespace GreenProgrammerz.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SearchRemoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "Search");
            DropColumn("dbo.Products", "Search");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Search", c => c.String());
            AddColumn("dbo.Categories", "Search", c => c.String());
        }
    }
}
