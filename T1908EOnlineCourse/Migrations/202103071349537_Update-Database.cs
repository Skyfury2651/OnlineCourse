namespace T1908EOnlineCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "balance", c => c.Int(nullable: false));
            AddColumn("dbo.Rate", "star", c => c.Decimal(precision: 18, scale: 0));
            DropColumn("dbo.Rate", "start");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rate", "start", c => c.Decimal(precision: 18, scale: 0));
            DropColumn("dbo.Rate", "star");
            DropColumn("dbo.AspNetUsers", "balance");
        }
    }
}
