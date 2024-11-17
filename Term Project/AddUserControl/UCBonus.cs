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
    public partial class UCBonus : UserControl
    {
        public UCBonus()
        {
            InitializeComponent();
        }

        private void UCBonus_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var bonuses = db.Bonuses.Include(s => s.Employee).ToList();
                bonusBindingSource.DataSource = bonuses;
            }
            Bonus obj = bonusBindingSource.Current as Bonus;


        }

        private void AddBonusBtn_Click(object sender, EventArgs e)
        {
            bonusBindingSource.Add(new Bonus());
            bonusBindingSource.MoveLast();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            bonusBindingSource.ResetBindings(false);
            UCBonus_Load(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Bonus obj = bonusBindingSource.Current as Bonus;
                    if (obj != null)
                    {
                        if (db.Entry(obj).State == EntityState.Detached)
                            db.Set<Bonus>().Attach(obj);

                        db.Entry(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show("Delete Successfully");
                        bonusBindingSource.RemoveCurrent();
                    }
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(EmployeeIdTxt.Text) ||
                !float.TryParse(BonusAmountTxt.Text, out float bonusAmountFloat) ||
                !DateTime.TryParse(BonusDateDtp.Text, out DateTime bonusDate))
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

                // Check if a bonus for this employee already exists
                var existingBonus = db.Bonuses.Any(b => b.EmployeeId == employeeId);
                if (existingBonus)
                {
                    MessageBox.Show("A bonus for this employee already exists. You cannot add another bonus for the same employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Bonus obj = bonusBindingSource.Current as Bonus;
                if (obj != null)
                {
                    obj.EmployeeId = employeeId;
                    obj.Amount = (decimal)bonusAmountFloat; // Explicit conversion
                    obj.BonusDate = bonusDate;
                    obj.Updated = DateTime.Now;

                    if (db.Entry(obj).State == EntityState.Detached)
                        db.Bonuses.Attach(obj);

                    if (obj.BonusId == 0)
                        db.Entry(obj).State = EntityState.Added;
                    else
                        db.Entry(obj).State = EntityState.Modified;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Save Successfully");
                        bonusBindingSource.DataSource = db.Bonuses.Include(b => b.Employee).ToList();
                        dataGridView1.Refresh();
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
