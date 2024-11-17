using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.Model;
using System.Data.Entity;
using Term_Project.ContextDb;
using System.Data.Entity.Infrastructure;

namespace Term_Project.AddUserControl
{
    public partial class UCPayroll : UserControl
    {
        public UCPayroll()
        {
            InitializeComponent();
            dataGridView1.DataError += dataGridView1_DataError; // Add DataError event handler
        }

        private void UCPayroll_Load(object sender, EventArgs e)
        {
            LoadPayrollData();
        }

        private void LoadPayrollData()
        {
            using (ModelContext db = new ModelContext())
            {
                var payrolls = db.Payrolls
                                 .Include(p => p.Employee)
                                 .Include(p => p.Employee.Salaries)
                                 .Include(p => p.Employee.Bonuses)
                                 .Include(p => p.Employee.Deductions)
                                 .ToList();
                payrollBindingSource.DataSource = payrolls;
            }
            Payroll obj = payrollBindingSource.Current as Payroll;
        }

        private void AddPayrollBtn_Click(object sender, EventArgs e)
        {
            payrollBindingSource.Add(new Payroll());
            payrollBindingSource.MoveLast();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            payrollBindingSource.ResetBindings(false);
            LoadPayrollData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Payroll obj = payrollBindingSource.Current as Payroll;
                    if (obj != null)
                    {
                        try
                        {
                            if (db.Entry(obj).State == EntityState.Detached)
                                db.Set<Payroll>().Attach(obj);

                            db.Entry(obj).State = EntityState.Deleted;
                            db.SaveChanges();
                            MessageBox.Show("Delete Successfully");
                            payrollBindingSource.RemoveCurrent();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show($"A database update error occurred: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EmployeeIdTxt.Text) ||
                    !DateTime.TryParse(PaymentDateDtp.Text, out DateTime paymentDate))
                {
                    MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (ModelContext db = new ModelContext())
                {
                    int employeeId = int.Parse(EmployeeIdTxt.Text);

                    // Check if the EmployeeId exists in the database
                    var employee = db.Employees.Include(s => s.Salaries)
                                               .Include(s => s.Bonuses)
                                               .Include(s => s.Deductions)
                                               .FirstOrDefault(c => c.EmployeeId == employeeId);
                    if (employee == null)
                    {
                        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var existingPayroll = db.Payrolls.Any(b => b.EmployeeId == employeeId);
                    if (existingPayroll)
                    {
                        MessageBox.Show("A payroll for this employee already exists. You cannot add another payroll for the same employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Payroll obj = payrollBindingSource.Current as Payroll;
                    if (obj != null)
                    {
                        // Calculate NetSalary
                        decimal basicSalary = employee.Salaries?.AsEnumerable().OrderByDescending(s => s.PaymentDate).FirstOrDefault()?.BasicSalary ?? 0;
                        decimal bonusAmount = employee.Bonuses?.AsEnumerable().OrderByDescending(b => b.BonusDate).FirstOrDefault()?.Amount ?? 0;
                        decimal deductionAmount = employee.Deductions?.AsEnumerable().OrderByDescending(d => d.DeductionDate).FirstOrDefault()?.Amount ?? 0;
                        obj.NetSalary = basicSalary + bonusAmount - deductionAmount;

                        obj.EmployeeId = employeeId;
                        obj.PaymentDate = paymentDate;
                        obj.Updated = DateTime.Now;

                        if (db.Entry(obj).State == EntityState.Detached)
                            db.Payrolls.Attach(obj);

                        if (obj.PayrollId == 0)
                            db.Entry(obj).State = EntityState.Added;
                        else
                            db.Entry(obj).State = EntityState.Modified;

                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Save Successfully");
                            payrollBindingSource.DataSource = db.Payrolls.Include(b => b.Employee).ToList();
                            dataGridView1.Refresh();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show($"A database update error occurred: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Data error: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false; // Prevents the default error dialog from being shown
        }
    }
}
