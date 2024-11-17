using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.ContextDb;


namespace Term_Project.AddUserControl
{
    public partial class UCEmployee : UserControl
    {
        public UCEmployee()
        {
            InitializeComponent();
            GenSortCmb.SelectedIndexChanged += GenSortCmb_SelectedIndexChanged;
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext()) 
            {
                employeeBindingSource.DataSource = db.Employees.ToList();
            }
            Employee obj = employeeBindingSource.Current as Employee;
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeBindingSource.Add(new Employee());
            employeeBindingSource.MoveLast();

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            employeeBindingSource.ResetBindings(false);
            UCEmployee_Load(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (ModelContext db = new ModelContext())
                {
                    Employee obj = employeeBindingSource.Current as Employee;
                    if (obj != null)
                    {
                        if (db.Entry(obj).State == EntityState.Detached)
                            db.Set<Employee>().Attach(obj);

                        db.Entry(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        MessageBox.Show("Delete Successfully");
                        employeeBindingSource.RemoveCurrent();
                    }
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNametxb.Text) ||
                string.IsNullOrWhiteSpace(LastNametxb.Text) ||
                string.IsNullOrEmpty(PositionCmb.Text) ||
                DateOfBirthDtp.Value.ToString() == "" ||
                DateOfJoiningDtp.Value.ToString() == "")
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ModelContext db = new ModelContext())
            {
                Employee obj = employeeBindingSource.Current as Employee;
                if (obj != null)
                {
                    obj.Updated = DateTime.Now;

                    try
                    {
                        if (db.Entry(obj).State == EntityState.Detached)
                            db.Set<Employee>().Attach(obj);

                        if (obj.EmployeeId == 0)
                            db.Entry(obj).State = EntityState.Added;
                        else
                            db.Entry(obj).State = EntityState.Modified;

                        db.SaveChanges();
                        MessageBox.Show("Save Successfully");
                        dataGridView1.Refresh();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var validationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                MessageBox.Show($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        //MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show($"An error occurred: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = SearchTxb.Text.ToLower();
            using (ModelContext db = new ModelContext())
            {
                var employees = db.Employees.ToList();
                var result = employees
                    .Where(b => b.FirstName.ToLower().Contains(searchText)
                             || b.LastName.ToLower().Contains(searchText)
                             || b.Position.ToLower().Contains(searchText))
                    .ToList();

                // Update the data source and refresh the DataGridView
                employeeBindingSource.DataSource = result;
                dataGridView1.Refresh();
            }
        }

        private void GenSortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortOption = GenSortCmb.SelectedItem.ToString().ToLower();

            using (ModelContext db = new ModelContext())
            {
                List<Employee> employees;

                switch (selectedSortOption)
                {
                    case "no ( ascending )":
                        employees = db.Employees.OrderBy(b => b.EmployeeId).ToList();
                        break;
                    case "no ( descending )":
                        employees = db.Employees.OrderByDescending(b => b.EmployeeId).ToList();
                        break;
                    case "first name ( a-z )":
                        employees = db.Employees.OrderBy(b => b.FirstName).ToList();
                        break;
                    case "first name ( z-a )":
                        employees = db.Employees.OrderByDescending(b => b.FirstName).ToList();
                        break;
                    case "last name ( a-z )":
                        employees = db.Employees.OrderBy(b => b.LastName).ToList();
                        break;
                    case "last name ( z-a )":
                        employees = db.Employees.OrderByDescending(b => b.LastName).ToList();
                        break;
                    default:
                        employees = db.Employees.ToList(); // No sorting applied
                        break;
                }

                // Update the data source and refresh the DataGridView
                employeeBindingSource.DataSource = employees;
                dataGridView1.Refresh();
            }
        }

        private void PositionSortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPosition = PositionSortCmb.SelectedItem.ToString();

            using (ModelContext db = new ModelContext())
            {
                List<Employee> employees;

                switch (selectedPosition)
                {
                    case "UX/UI Designer":
                        employees = db.Employees.Where(b => b.Position == "UX/UI Designer").ToList();
                        break;
                    case "Blockchain Developer":
                        employees = db.Employees.Where(b => b.Position == "Blockchain Developer").ToList();
                        break;
                    case "AI Engineer":
                        employees = db.Employees.Where(b => b.Position == "AI Engineer").ToList();
                        break;
                    case "Cybersecurity Analyst":
                        employees = db.Employees.Where(b => b.Position == "Cybersecurity Analyst").ToList();
                        break;
                    case "DevOps Engineer":
                        employees = db.Employees.Where(b => b.Position == "DevOps Engineer").ToList();
                        break;
                    case "Cloud Engineer":
                        employees = db.Employees.Where(b => b.Position == "Cloud Engineer").ToList();
                        break;
                    case "Data Scientist":
                        employees = db.Employees.Where(b => b.Position == "Data Scientist").ToList();
                        break;
                    case "Machine Learning Engineer":
                        employees = db.Employees.Where(b => b.Position == "Machine Learning Engineer").ToList();
                        break;
                    case "Mobile App Developer":
                        employees = db.Employees.Where(b => b.Position == "Mobile App Developer").ToList();
                        break;
                    case "Fullstack Developer":
                        employees = db.Employees.Where(b => b.Position == "Fullstack Developer").ToList();
                        break;
                    case "Software Developer":
                        employees = db.Employees.Where(b => b.Position == "Software Developer").ToList();
                        break;
                    case "IoT Engineer":
                        employees = db.Employees.Where(b => b.Position == "IoT Engineer").ToList();
                        break;
                    default:
                        employees = db.Employees.ToList(); // No filtering applied
                        break;
                }

                // Update the data source and refresh the DataGridView
                employeeBindingSource.DataSource = employees;
                dataGridView1.Refresh();
            }
        }

    }
}
