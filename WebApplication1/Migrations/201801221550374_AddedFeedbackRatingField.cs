namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFeedbackRatingField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "FeedbackRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "FeedbackRating");
        }
    }
}
