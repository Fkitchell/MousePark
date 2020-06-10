namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingAddition3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Eatery", "AverageScore", c => c.Double(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Eatery", "AverageScore", c => c.Double());
        }
    }
}
