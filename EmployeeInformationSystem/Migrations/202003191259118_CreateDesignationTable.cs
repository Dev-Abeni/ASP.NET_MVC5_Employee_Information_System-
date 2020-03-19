namespace EmployeeInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDesignationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Department_Id = c.Int(),
                        Salary_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Salaries", t => t.Salary_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Salary_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Designations", "Salary_Id", "dbo.Salaries");
            DropForeignKey("dbo.Designations", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Designations", new[] { "Salary_Id" });
            DropIndex("dbo.Designations", new[] { "Department_Id" });
            DropTable("dbo.Designations");
        }
    }
}
