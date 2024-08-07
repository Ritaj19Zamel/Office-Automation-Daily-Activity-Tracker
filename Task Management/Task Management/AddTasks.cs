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
    public partial class AddTasks : Form
    {
        DataTable dtEmp;
        DatabaseHelper dh = new DatabaseHelper();
        public AddTasks()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                dtEmp = new DataTable();
                dtEmp = dh.GetTable("SELECT e.e_id [e_id], e_name_en FROM Employees e LEFT JOIN users u on e.e_id =  u.e_id where isadmin = 0");
                cmb_AssignTo.LoadItems(dtEmp, "e_name_en", "e_id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
