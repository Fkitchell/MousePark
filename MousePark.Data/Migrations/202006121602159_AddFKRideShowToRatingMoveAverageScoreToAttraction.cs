namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKRideShowToRatingMoveAverageScoreToAttraction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rating", "EateryId", "dbo.Eatery");
            DropIndex("dbo.Rating", new[] { "EateryId" });
            AddColumn("dbo.Rating", "RideId", c => c.Int());
            AddColumn("dbo.Rating", "ShowId", c => c.Int());
            AlterColumn("dbo.Rating", "EateryId", c => c.Int());
            CreateIndex("dbo.Rating", "EateryId");
            CreateIndex("dbo.Rating", "RideId");
            CreateIndex("dbo.Rating", "ShowId");
            AddForeignKey("dbo.Rating", "RideId", "dbo.Ride", "ID");
            AddForeignKey("dbo.Rating", "ShowId", "dbo.Show", "ID");
            AddForeignKey("dbo.Rating", "EateryId", "dbo.Eatery", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rating", "EateryId", "dbo.Eatery");
            DropForeignKey("dbo.Rating", "ShowId", "dbo.Show");
            DropForeignKey("dbo.Rating", "RideId", "dbo.Ride");
            DropIndex("dbo.Rating", new[] { "ShowId" });
            DropIndex("dbo.Rating", new[] { "RideId" });
            DropIndex("dbo.Rating", new[] { "EateryId" });
            AlterColumn("dbo.Rating", "EateryId", c => c.Int(nullable: false));
            DropColumn("dbo.Rating", "ShowId");
            DropColumn("dbo.Rating", "RideId");
            CreateIndex("dbo.Rating", "EateryId");
            AddForeignKey("dbo.Rating", "EateryId", "dbo.Eatery", "ID", cascadeDelete: true);
        }
    }
}
