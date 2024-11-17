using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Term_Project.AddUserControl;

namespace Term_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            UCDashboard uCDashboard = new UCDashboard();
            addUserControl(uCDashboard);
        }
        private void addUserControl(UserControl UserControl)
        {
            UserControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(UserControl);
            UserControl.BringToFront();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.Gainsboro;
            SalaryBtn.BackColor = Color.Transparent;
            EmployeeBtn.BackColor = Color.Transparent;
            BonusBtn.BackColor = Color.Transparent;
            DeductionBtn.BackColor = Color.Transparent;
            PayrollBtn.BackColor = Color.Transparent;

            UCDashboard uCDashboard = new UCDashboard();
            addUserControl (uCDashboard);
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            SalaryBtn.BackColor = Color.Gainsboro;
            DashboardBtn.BackColor = Color.Transparent;
            EmployeeBtn.BackColor = Color.Transparent;
            BonusBtn.BackColor = Color.Transparent;
            DeductionBtn.BackColor = Color.Transparent;
            PayrollBtn.BackColor = Color.Transparent;

            UCSalary uCProject = new UCSalary();
            addUserControl (uCProject);

        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeBtn.BackColor = Color.Gainsboro;
            DashboardBtn.BackColor = Color.Transparent;
            SalaryBtn.BackColor = Color.Transparent;
            BonusBtn.BackColor = Color.Transparent;
            DeductionBtn.BackColor = Color.Transparent;
            PayrollBtn.BackColor = Color.Transparent;

            UCEmployee uCEmployee = new UCEmployee();
            addUserControl (uCEmployee);
        }

        private void BonusBtn_Click(object sender, EventArgs e)
        {
            BonusBtn.BackColor = Color.Gainsboro;
            DeductionBtn.BackColor = Color.Transparent;
            PayrollBtn.BackColor = Color.Transparent;
            DashboardBtn.BackColor = Color.Transparent;
            SalaryBtn.BackColor = Color.Transparent;
            EmployeeBtn.BackColor = Color.Transparent;
            
            UCBonus uCBonus = new UCBonus();
            addUserControl (uCBonus);
        }

        private void DeductionBtn_Click(object sender, EventArgs e)
        {
            DeductionBtn.BackColor = Color.Gainsboro;
            BonusBtn.BackColor = Color.Transparent;
            PayrollBtn.BackColor = Color.Transparent;
            DashboardBtn.BackColor = Color.Transparent;
            SalaryBtn.BackColor = Color.Transparent;
            EmployeeBtn.BackColor = Color.Transparent;

            UCDeduction uCDeduction = new UCDeduction();
            addUserControl (uCDeduction);
        }

        private void PayrollBtn_Click(object sender, EventArgs e)
        {
            PayrollBtn.BackColor = Color.Gainsboro;
            BonusBtn.BackColor = Color.Transparent;
            DeductionBtn.BackColor = Color.Transparent;
            DashboardBtn.BackColor = Color.Transparent;
            SalaryBtn.BackColor = Color.Transparent;
            EmployeeBtn.BackColor = Color.Transparent;

            UCPayroll uCPayroll = new UCPayroll();
            addUserControl (uCPayroll);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Login login = new Login(); 
            login.Show();  
            this.Close();


           
        }
    }
}
