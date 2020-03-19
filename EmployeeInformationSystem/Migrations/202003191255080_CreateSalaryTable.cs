namespace EmployeeInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSalaryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Salaries");
        }
    }
}
