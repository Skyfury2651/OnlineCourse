namespace T1908EOnlineCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveStringLimit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "description", c => c.String(unicode: false));
            AlterColumn("dbo.Lecture", "source", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lecture", "source", c => c.String(maxLength: 255, unicode: false));
            AlterColumn("dbo.Course", "description", c => c.String(maxLength: 255, unicode: false));
        }
    }
}
