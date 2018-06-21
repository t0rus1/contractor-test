namespace LeonVanDyk.WMTestApp.SchoolContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Salutation = c.String(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
