namespace MousePark.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRatingToIncludeUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rating", "UserId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rating", "UserId");
        }
    }
}
