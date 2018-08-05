namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Enrollement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnrollementDateTime = c.DateTime(nullable: false),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropTable("dbo.Enrollments");
        }
    }
}
