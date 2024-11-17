using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.ContextDb;
using Term_Project.Model;

namespace Term_Project.AddUserControl
{
    public partial class UCSalary : UserControl
    {
        public UCSalary()
        {
            InitializeComponent();
        }
        private void UCSalary_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext()) 
            { 
                var salaries = db.Salaries.Include(s => s.Employee).ToList(); 
                salaryBindingSource.DataSource = salaries; 
            }
            Salary obj = salaryBindingSource.Current as Salary;
        }
        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            salaryBindingSource.Add(new Salary());
            salaryBindingSource.MoveLast();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Perform validations
            if (string.IsNullOrWhiteSpace(SalaEmployeeIdTxt.Text) ||
                !float.TryParse(BasicSalaryTxt.Text, out float basicSalaryFloat) ||
                !DateTime.TryParse(PaymentDateDtp.Text, out DateTime paymentDate))
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ModelContext db = new ModelContext())
            {
                int employeeId = int.Parse(SalaEmployeeIdTxt.Text);

                // Check if the EmployeeId exists in the database
                var employee = db.Employees.FirstOrDefault(c => c.EmployeeId == employeeId);
                if (employee == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Salary obj = salaryBindingSource.Current as Salary;
                if (obj != null)
                {
                    obj.EmployeeId = employeeId;
                    obj.BasicSalary = (decimal)basicSalaryFloat; // Explicit conversion
                    obj.PaymentDate = paymentDate;
                    obj.Updated = DateTime.Now;

                    if (db.Entry(obj).State == EntityState.Detached)
                        db.Salaries.Attach(obj);

                    if (obj.SalaryId == 0)
                        db.Entry(obj).State = EntityState.Added;
                    else
                        db.Entry(obj).State = EntityState.Modified;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Save Successfully");
                        salaryBindingSource.DataSource = db.Salaries.ToList();
                        dataGridView1.Refresh();
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            salaryBindingSource.ResetBindings(false);
            UCSalary_Load(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Salary obj = salaryBindingSource.Current as Salary;
                    if (obj != null)
                    {
                        if (db.Entry(obj).State == EntityState.Detached)
                            db.Set<Salary>().Attach(obj);

                        db.Entry(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show("Delete Successfully");
                        salaryBindingSource.RemoveCurrent();
                    }
                }
            }
        }
    }
}
