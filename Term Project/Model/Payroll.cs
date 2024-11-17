using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Term_Project.Model;
using System.Linq;

namespace Term_Project
{
    public class Payroll
    {
        [Key]
        public int PayrollId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public decimal NetSalary { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

        [NotMapped]
        public string EmployeeLastName => Employee?.LastName;

        [NotMapped]
        public decimal BasicSalary => Employee?.Salaries?.AsEnumerable().OrderByDescending(s => s.PaymentDate).FirstOrDefault()?.BasicSalary ?? 0;

        [NotMapped]
        public decimal BonusAmount => Employee?.Bonuses?.AsEnumerable().OrderByDescending(b => b.BonusDate).FirstOrDefault()?.Amount ?? 0;

        [NotMapped]
        public decimal DeductionAmount => Employee?.Deductions?.AsEnumerable().OrderByDescending(d => d.DeductionDate).FirstOrDefault()?.Amount ?? 0;

        [NotMapped]
        public decimal CalculatedNetSalary => BasicSalary + BonusAmount - DeductionAmount;
    }
}
