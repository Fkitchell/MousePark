namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddICollectionToEatery : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rating", "Eatery_ID", "dbo.Eatery");
            DropIndex("dbo.Rating", new[] { "Eatery_ID" });
            RenameColumn(table: "dbo.Rating", name: "Eatery_ID", newName: "EateryId");
            DropPrimaryKey("dbo.Rating");
            AlterColumn("dbo.Rating", "RatingId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Rating", "EateryId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Rating", "RatingId");
            CreateIndex("dbo.Rating", "EateryId");
            AddForeignKey("dbo.Rating", "EateryId", "dbo.Eatery", "ID", cascadeDelete: false);
            DropColumn("dbo.Rating", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rating", "ID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Rating", "EateryId", "dbo.Eatery");
            DropIndex("dbo.Rating", new[] { "EateryId" });
            DropPrimaryKey("dbo.Rating");
            AlterColumn("dbo.Rating", "EateryId", c => c.Int());
            AlterColumn("dbo.Rating", "RatingId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Rating", "ID");
            RenameColumn(table: "dbo.Rating", name: "EateryId", newName: "Eatery_ID");
            CreateIndex("dbo.Rating", "Eatery_ID");
            AddForeignKey("dbo.Rating", "Eatery_ID", "dbo.Eatery", "ID");
        }
    }
}
