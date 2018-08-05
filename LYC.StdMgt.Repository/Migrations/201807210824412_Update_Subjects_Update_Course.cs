namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Subjects_Update_Course : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 30, unicode: false),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        StartDateTime = c.DateTime(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 10, unicode: false),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        Description = c.String(nullable: false, maxLength: 70, unicode: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Courses", "SubjectId", "dbo.Subjects");
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Courses", new[] { "SubjectId" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Courses");
        }
    }
}
