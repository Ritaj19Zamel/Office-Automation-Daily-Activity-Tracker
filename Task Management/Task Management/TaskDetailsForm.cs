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
    public partial class TaskDetailsForm : Form
    {
        public TaskDetailsForm()
        {
            InitializeComponent();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void LoadData(DataTable data)
        {
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("There no Data", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            lbTaskName.Text = data.Rows[0]["Task Name"].ToString();
            lb_description.Text = data.Rows[0]["Description"].ToString();
            lb_Assign.Text = data.Rows[0]["Assignee"].ToString();
            lb_startdate.Text = DateTime.Parse(data.Rows[0]["Start Date"].ToString()).ToString("yyyy/MM/dd");
            lb_endDate.Text = DateTime.Parse(data.Rows[0]["End Date"].ToString()).ToString("yyyy/MM/dd");
            string status = data.Rows[0]["Status"].ToString();
            switch (status)
            {
                case "Complete":
                    btn_status.BackColor = Color.FromArgb(255, 224, 102);
                    btn_status.BackgroundColor = Color.FromArgb(255, 224, 102);
                    btn_status.BorderColor = Color.FromArgb(255, 224, 102);
                    btn_status.Text = "Complete";
                    break;
                case "InProgress":
                    btn_status.BackColor = Color.FromArgb(144, 238, 144);
                    btn_status.BackgroundColor = Color.FromArgb(144, 238, 144);
                    btn_status.BorderColor = Color.FromArgb(144, 238, 144);
                    btn_status.Text = "In Progress";
                    break;
                case "NotStarted":
                    btn_status.BackColor = Color.FromArgb(255, 160, 160);
                    btn_status.BackgroundColor = Color.FromArgb(255, 160, 160);
                    btn_status.BorderColor = Color.FromArgb(255, 160, 160);
                    btn_status.Text = "Not Started";
                    break;
                case "Review":
                    btn_status.BackColor = Color.FromArgb(173, 216, 230);
                    btn_status.BackgroundColor = Color.FromArgb(173, 216, 230);
                    btn_status.BorderColor = Color.FromArgb(173, 216, 230);
                    btn_status.Text = "Review";
                    break;
                case "PendingReview":
                    btn_status.BackColor = Color.FromArgb(216, 191, 216);
                    btn_status.BackgroundColor = Color.FromArgb(216, 191, 216);
                    btn_status.BorderColor = Color.FromArgb(216, 191, 216);
                    btn_status.Text = "Pending Review";
                    break;
            }

        }
    }
}
