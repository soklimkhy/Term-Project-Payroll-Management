using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.ContextDb;
using Term_Project.Model;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Term_Project.AddUserControl
{
    public partial class UCDeduction : UserControl
    {
        public UCDeduction()
        {
            InitializeComponent();
        }
        private void UCDeduction_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var deductions = db.Deductions.Include(s => s.Employee).ToList();
                deductionBindingSource.DataSource = deductions;
            }
            Deduction obj = deductionBindingSource.Current as Deduction;

        }
        private void AddDeductionBtn_Click(object sender, EventArgs e)
        {
          
            deductionBindingSource.Add(new Deduction());
            deductionBindingSource.MoveLast();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            deductionBindingSource.ResetBindings(false);
            UCDeduction_Load(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Deduction obj = deductionBindingSource.Current as Deduction;
                    if (obj != null)
                    {
                        if (db.Entry(obj).State == EntityState.Detached)
                            db.Set<Deduction>().Attach(obj);

                        db.Entry(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show("Delete Successfully");
                        deductionBindingSource.RemoveCurrent();
                    }
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmployeeIdTxt.Text) ||
                string.IsNullOrWhiteSpace(ReasonTxt.Text) ||
                !float.TryParse(DeductionAmountTxt.Text, out float deductionAmountFloat) ||
                !DateTime.TryParse(DeductionDateDtp.Text, out DateTime deductionDate))
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ModelContext db = new ModelContext())
            {
                int employeeId = int.Parse(EmployeeIdTxt.Text);

                // Check if the EmployeeId exists in the database
                var employee = db.Employees.FirstOrDefault(c => c.EmployeeId == employeeId);
                if (employee == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var existingDeduction = db.Deductions.Any(b => b.EmployeeId == employeeId);
                if (existingDeduction)
                {
                    MessageBox.Show("A deduction for this employee already exists. You cannot add another bonus for the same employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Deduction obj = deductionBindingSource.Current as Deduction;
                if (obj != null)
                {
                    obj.EmployeeId = employeeId;
                    obj.Reason = ReasonTxt.Text;
                    obj.Amount = (decimal)deductionAmountFloat; 
                    obj.DeductionDate = deductionDate;
                    obj.Updated = DateTime.Now;

                    if (db.Entry(obj).State == EntityState.Detached)
                        db.Deductions.Attach(obj);

                    if (obj.DeductionId == 0)
                        db.Entry(obj).State = EntityState.Added;
                    else
                        db.Entry(obj).State = EntityState.Modified;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Save Successfully");
                        deductionBindingSource.DataSource = db.Deductions.Include(b => b.Employee).ToList();
                        dataGridView1.Refresh();
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeductionDateDtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReasonTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
