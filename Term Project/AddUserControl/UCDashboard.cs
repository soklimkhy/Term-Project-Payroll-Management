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

namespace Term_Project.AddUserControl
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
            SalaSortCmb.SelectedIndexChanged += SalaSortCmb_SelectedIndexChanged; // Attach event handler
            BonusSortCmb.SelectedIndexChanged += BonusSortCmb_SelectedIndexChanged; // Attach event handler
            DeductionSortCmb.SelectedIndexChanged += DeductionSortCmb_SelectedIndexChanged; // Attach event handler
            PayrollSortCmb.SelectedIndexChanged += PayrollSortCmb_SelectedIndexChanged; // Attach event handler
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (ModelContext db = new ModelContext())
            {
                var payrolls = db.Payrolls
                                 .Include(p => p.Employee)
                                 .Include(p => p.Employee.Salaries)
                                 .Include(p => p.Employee.Bonuses)
                                 .Include(p => p.Employee.Deductions)
                                 .ToList();

                var salaries = db.Salaries.Include(s => s.Employee).ToList();
                var bonuses = db.Bonuses.Include(s => s.Employee).ToList();
                var deductions = db.Deductions.Include(s => s.Employee).ToList();

                salaryBindingSource.DataSource = salaries;
                bonusBindingSource.DataSource = bonuses;
                deductionBindingSource.DataSource = deductions;
                payrollBindingSource.DataSource = payrolls;
            }

            Salary obj1 = salaryBindingSource.Current as Salary;
            Bonus obj2 = bonusBindingSource.Current as Bonus;
            Deduction obj3 = deductionBindingSource.Current as Deduction;
            Payroll obj = payrollBindingSource.Current as Payroll;
        }

        private void SalaSortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortOption = SalaSortCmb.SelectedItem.ToString().ToLower();

            using (ModelContext db = new ModelContext())
            {
                List<Salary> sortedSalaries;

                switch (selectedSortOption)
                {
                    case "highest":
                        sortedSalaries = db.Salaries.Include(s => s.Employee).OrderByDescending(s => s.BasicSalary).ToList();
                        break;
                    case "lowest":
                        sortedSalaries = db.Salaries.Include(s => s.Employee).OrderBy(s => s.BasicSalary).ToList();
                        break;
                    default:
                        sortedSalaries = db.Salaries.Include(s => s.Employee).ToList();
                        break;
                }

                salaryBindingSource.DataSource = sortedSalaries;
                dataGridView1.Refresh();
            }
        }

        private void BonusSortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortOption = BonusSortCmb.SelectedItem.ToString().ToLower();

            using (ModelContext db = new ModelContext())
            {
                List<Bonus> sortedBonuses;

                switch (selectedSortOption)
                {
                    case "highest":
                        sortedBonuses = db.Bonuses.Include(b => b.Employee).OrderByDescending(b => b.Amount).ToList();
                        break;
                    case "lowest":
                        sortedBonuses = db.Bonuses.Include(b => b.Employee).OrderBy(b => b.Amount).ToList();
                        break;
                    default:
                        sortedBonuses = db.Bonuses.Include(b => b.Employee).ToList();
                        break;
                }

                bonusBindingSource.DataSource = sortedBonuses;
                dataGridView2.Refresh();
            }
        }
        private void DeductionSortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortOption = DeductionSortCmb.SelectedItem.ToString().ToLower();

            using (ModelContext db = new ModelContext())
            {
                List<Deduction> sortedDeductions;

                switch (selectedSortOption)
                {
                    case "highest":
                        sortedDeductions = db.Deductions.Include(d => d.Employee).OrderByDescending(d => d.Amount).ToList();
                        break;
                    case "lowest":
                        sortedDeductions = db.Deductions.Include(d => d.Employee).OrderBy(d => d.Amount).ToList();
                        break;
                    default:
                        sortedDeductions = db.Deductions.Include(d => d.Employee).ToList();
                        break;
                }

                deductionBindingSource.DataSource = sortedDeductions;
                dataGridView4.Refresh();
            }
        }
        private void PayrollSortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortOption = PayrollSortCmb.SelectedItem.ToString().ToLower();

            using (ModelContext db = new ModelContext())
            {
                List<Payroll> sortedPayrolls;

                switch (selectedSortOption)
                {
                    case "highest":
                        sortedPayrolls = db.Payrolls
                                           .Include(p => p.Employee)
                                           .Include(p => p.Employee.Salaries)
                                           .Include(p => p.Employee.Bonuses)
                                           .Include(p => p.Employee.Deductions)
                                           .OrderByDescending(p => p.NetSalary)
                                           .ToList();
                        break;
                    case "lowest":
                        sortedPayrolls = db.Payrolls
                                           .Include(p => p.Employee)
                                           .Include(p => p.Employee.Salaries)
                                           .Include(p => p.Employee.Bonuses)
                                           .Include(p => p.Employee.Deductions)
                                           .OrderBy(p => p.NetSalary)
                                           .ToList();
                        break;
                    default:
                        sortedPayrolls = db.Payrolls
                                           .Include(p => p.Employee)
                                           .Include(p => p.Employee.Salaries)
                                           .Include(p => p.Employee.Bonuses)
                                           .Include(p => p.Employee.Deductions)
                                           .ToList();
                        break;
                }

                payrollBindingSource.DataSource = sortedPayrolls;
                dataGridView3.Refresh();
            }
        }



        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Data error: {e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false; // Prevents the default error dialog from being shown
        }
    }
}
