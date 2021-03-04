namespace T1908EOnlineCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "image");
        }
    }
}
