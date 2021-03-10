namespace T1908EOnlineCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAspusers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "balance", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "balance", c => c.Int(nullable: false));
        }
    }
}
