using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management.Helpers;
using Task_Management.Models;

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
                User user = UserManager.Login(txt_username.Texts, txt_pass.Texts);
                if (user != null)
                {
                    Dashboard adminDashboard = new Dashboard(user);
                    adminDashboard.Show();
 
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
