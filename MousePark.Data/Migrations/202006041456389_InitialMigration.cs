namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eatery",
                c => new
                    {
                        EateryId = c.Int(nullable: false, identity: true),
                        EateryName = c.String(nullable: false, maxLength: 100),
                        CuisineType = c.String(nullable: false),
                        DineIn = c.Boolean(nullable: false),
                        Tier = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EateryId)
                .ForeignKey("dbo.Area", t => t.AreaId, cascadeDelete: true)
                .Index(t => t.AreaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eatery", "AreaId", "dbo.Area");
            DropIndex("dbo.Eatery", new[] { "AreaId" });
            DropTable("dbo.Eatery");
        }
    }
}
