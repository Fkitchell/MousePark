namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingAddition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rating",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RatingId = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        Eatery_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Eatery", t => t.Eatery_ID)
                .Index(t => t.Eatery_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rating", "Eatery_ID", "dbo.Eatery");
            DropIndex("dbo.Rating", new[] { "Eatery_ID" });
            DropTable("dbo.Rating");
        }
    }
}
