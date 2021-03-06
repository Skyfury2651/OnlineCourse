namespace T1908EOnlineCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveLimit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Result", "link", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Result", "link", c => c.String(maxLength: 255, unicode: false));
        }
    }
}
