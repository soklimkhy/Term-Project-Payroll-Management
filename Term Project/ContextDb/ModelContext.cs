using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.Model;

namespace Term_Project.ContextDb
{
    internal class ModelContext : DbContext
    {
        public ModelContext() : base("name=PayrollManagementConnection") { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<Deduction> Deductions { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
    }
}
