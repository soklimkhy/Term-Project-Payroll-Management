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

namespace Term_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxb.Text;
            string password = PasswordTxb.Text;

            using (ModelContext db = new ModelContext())
            {
                var admin = db.Admins.FirstOrDefault(a => a.Username == username && a.Password == password);
                if (admin != null)
                {
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
