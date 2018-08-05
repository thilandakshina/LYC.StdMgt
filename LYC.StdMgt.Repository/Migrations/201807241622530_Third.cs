namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Subjects", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teachers", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Enrollments", "LastModifiedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "LastModifiedDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "LastModifiedDateTime");
            DropColumn("dbo.Enrollments", "LastModifiedDateTime");
            DropColumn("dbo.Teachers", "LastModifiedDateTime");
            DropColumn("dbo.Subjects", "LastModifiedDateTime");
            DropColumn("dbo.Courses", "LastModifiedDateTime");
        }
    }
}
