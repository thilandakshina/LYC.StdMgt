namespace LYC.StdMgt.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Teacher_Column_Code_Add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Code", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Code");
        }
    }
}
