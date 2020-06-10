namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingAddition2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eatery", "AverageScore", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eatery", "AverageScore");
        }
    }
}
