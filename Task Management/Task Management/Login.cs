using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task_Management
{
    public partial class Login : Form
    {
        DatabaseHelper dh = new DatabaseHelper();
        public Login()
        {
            InitializeComponent();
            

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Texts == "")
                {
                    MessageBox.Show("Please Enter a User Name.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_pass.Texts == "")
                {
                    MessageBox.Show("Please Enter a Password.", "Data Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Convert.ToInt32(dh.GetValue(@"SELECT Case WHEN password = '" + txt_pass.Texts + @"' 
                                            THEN 1 ELSE 0 END FROM users where username = '" + txt_username.Texts + "'")) == 0)
                {
                    MessageBox.Show("Invalid Username or Password.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int isAdmin = Convert.ToInt32(dh.GetValue("SELECT isadmin FROM users where username = '" + txt_username.Texts + "'"));
                string userName = dh.GetValue("SELECT e.e_name_en FROM users u LEFT JOIN Employees e ON e.e_id = u.e_id WHERE username = '" + txt_username.Texts + "'").ToString();
                this.Hide();
                if (isAdmin == 1)
                {
                    Admin_Dashboard adminDashboard = new Admin_Dashboard(userName);
                    adminDashboard.Show();
                }
                else
                {
                    Emp_Dashboard empDashboard = new Emp_Dashboard();
                    empDashboard.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
