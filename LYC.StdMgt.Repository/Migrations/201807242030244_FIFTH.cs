namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FIFTH : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CreatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subjects", "CreatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subjects", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teachers", "CreatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teachers", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Enrollments", "CreatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Enrollments", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "CreatedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "LastModifiedDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "LastModifiedDateTime");
            DropColumn("dbo.Students", "CreatedDateTime");
            DropColumn("dbo.Enrollments", "LastModifiedDateTime");
            DropColumn("dbo.Enrollments", "CreatedDateTime");
            DropColumn("dbo.Teachers", "LastModifiedDateTime");
            DropColumn("dbo.Teachers", "CreatedDateTime");
            DropColumn("dbo.Subjects", "LastModifiedDateTime");
            DropColumn("dbo.Subjects", "CreatedDateTime");
            DropColumn("dbo.Courses", "LastModifiedDateTime");
            DropColumn("dbo.Courses", "CreatedDateTime");
        }
    }
}
