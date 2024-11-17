namespace Term_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initModelContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Bonus",
                c => new
                    {
                        BonusId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BonusDate = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BonusId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                        Position = c.String(nullable: false, maxLength: 100),
                        DateOfJoining = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Deductions",
                c => new
                    {
                        DeductionId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeductionDate = c.DateTime(nullable: false),
                        Reason = c.String(maxLength: 255),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DeductionId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        SalaryId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        BasicSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalaryId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Payrolls",
                c => new
                    {
                        PayrollId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        NetSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PayrollId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payrolls", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Bonus", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Salaries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Deductions", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Payrolls", new[] { "EmployeeId" });
            DropIndex("dbo.Salaries", new[] { "EmployeeId" });
            DropIndex("dbo.Deductions", new[] { "EmployeeId" });
            DropIndex("dbo.Bonus", new[] { "EmployeeId" });
            DropTable("dbo.Payrolls");
            DropTable("dbo.Salaries");
            DropTable("dbo.Deductions");
            DropTable("dbo.Employees");
            DropTable("dbo.Bonus");
            DropTable("dbo.Admins");
        }
    }
}
