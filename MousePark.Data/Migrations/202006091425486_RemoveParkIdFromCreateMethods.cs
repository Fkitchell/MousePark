namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveParkIdFromCreateMethods : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Eatery", "ParkId", "dbo.Park");
            DropForeignKey("dbo.Ride", "ParkId", "dbo.Park");
            DropForeignKey("dbo.Show", "ParkId", "dbo.Park");
            DropIndex("dbo.Eatery", new[] { "ParkId" });
            DropIndex("dbo.Ride", new[] { "ParkId" });
            DropIndex("dbo.Show", new[] { "ParkId" });
            DropColumn("dbo.Eatery", "ParkId");
            DropColumn("dbo.Ride", "ParkId");
            DropColumn("dbo.Show", "ParkId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Show", "ParkId", c => c.Int(nullable: false));
            AddColumn("dbo.Ride", "ParkId", c => c.Int(nullable: false));
            AddColumn("dbo.Eatery", "ParkId", c => c.Int(nullable: false));
            CreateIndex("dbo.Show", "ParkId");
            CreateIndex("dbo.Ride", "ParkId");
            CreateIndex("dbo.Eatery", "ParkId");
            AddForeignKey("dbo.Show", "ParkId", "dbo.Park", "ParkId", cascadeDelete: true);
            AddForeignKey("dbo.Ride", "ParkId", "dbo.Park", "ParkId", cascadeDelete: true);
            AddForeignKey("dbo.Eatery", "ParkId", "dbo.Park", "ParkId", cascadeDelete: true);
        }
    }
}
