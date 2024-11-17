using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.Model
{
    public class Deduction
    {
        [Key] public int DeductionId { get; set; }
        [ForeignKey("Employee")] 
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required] 
        public decimal Amount { get; set; }
        [Required] 
        public DateTime DeductionDate { get; set; }
        [StringLength(255)] 
        public string Reason { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

        [NotMapped]
        public string EmployeeLastName => Employee?.LastName;
    }
}
