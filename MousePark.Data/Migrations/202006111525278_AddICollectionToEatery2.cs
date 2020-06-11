namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddICollectionToEatery2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Eatery", "AverageScore");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eatery", "AverageScore", c => c.Double(nullable: true));
        }
    }
}
