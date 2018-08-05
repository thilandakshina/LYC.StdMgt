namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Teacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YearsOfExperience = c.Int(nullable: false),
                        Address = c.String(),
                        FirstName = c.String(nullable: false, maxLength: 30, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 8000, unicode: false),
                        DOB = c.DateTime(nullable: false, storeType: "date"),
                        Gender = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        LastModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}
