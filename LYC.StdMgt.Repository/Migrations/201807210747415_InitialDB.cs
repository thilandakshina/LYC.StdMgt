namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 10, unicode: false),
                        ParentName = c.String(nullable: false, maxLength: 50, unicode: false),
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
            DropTable("dbo.Students");
        }
    }
}
