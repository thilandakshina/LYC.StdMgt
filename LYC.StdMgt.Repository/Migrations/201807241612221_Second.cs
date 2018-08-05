namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "LastModifiedDateTime");
            DropColumn("dbo.Subjects", "LastModifiedDateTime");
            DropColumn("dbo.Teachers", "LastModifiedDateTime");
            DropColumn("dbo.Enrollments", "LastModifiedDateTime");
            DropColumn("dbo.Students", "LastModifiedDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Enrollments", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teachers", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subjects", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "LastModifiedDateTime", c => c.DateTime(nullable: false));
        }
    }
}
