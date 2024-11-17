using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Term_Project.Model;

namespace Term_Project
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required, StringLength(100)]
        public string Position { get; set; }

        [Required]
        public DateTime DateOfJoining { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Bonus> Bonuses { get; set; }
        public virtual ICollection<Deduction> Deductions { get; set; }
    }
}
