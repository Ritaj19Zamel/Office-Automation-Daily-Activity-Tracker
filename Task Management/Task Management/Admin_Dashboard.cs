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
    public partial class Admin_Dashboard : Form
    {
        DatabaseHelper dh = new DatabaseHelper();
        DataTable dt, dtStatus, dtEmployee;
        DateTime? dtStart = null;
        DateTime? dtEnd = null;

        private void CustomizeDataGridView()
        {
            // Remove grid lines
            dgv_Tasks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Tasks.GridColor = Color.White;

            // Set header and row styles
            dgv_Tasks.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv_Tasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_Tasks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Tasks.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_Tasks.Font, FontStyle.Bold);
            dgv_Tasks.EnableHeadersVisualStyles = false;

            dgv_Tasks.DefaultCellStyle.BackColor = Color.White;
            dgv_Tasks.DefaultCellStyle.ForeColor = Color.Black;
            dgv_Tasks.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv_Tasks.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set alternating row styles
            dgv_Tasks.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Add an "Action" column if it doesn't exist
            if (!dgv_Tasks.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn();
                actionColumn.Name = "Action";
                actionColumn.HeaderText = "Action";
                actionColumn.Text = "...";
                actionColumn.UseColumnTextForButtonValue = true;
                dgv_Tasks.Columns.Add(actionColumn);
            }

            // Check if the required columns exist before formatting
            if (!dgv_Tasks.Columns.Contains("Status"))
            {
                MessageBox.Show("The 'Status' column does not exist in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Format cells based on status
            foreach (DataGridViewRow row in dgv_Tasks.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();
                    switch (status)
                    {
                        case "Complete":
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "InProgress":
                            row.DefaultCellStyle.BackColor = Color.Blue;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "NotStarted":
                            row.DefaultCellStyle.BackColor = Color.Gray;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "Review":
                            row.DefaultCellStyle.BackColor = Color.Orange;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "NeedChanges":
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "PendingReview":
                            row.DefaultCellStyle.BackColor = Color.Purple;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {
            dtStart = dtp_StartDate.Value;
        }

        private void dtp_EndDate_ValueChanged(object sender, EventArgs e)
        {
            dtEnd = dtp_EndDate.Value;
        }

        public Admin_Dashboard(string userName)
        {
            InitializeComponent();
            lb_name.Text = userName;
            lb_Date.Text = DateTime.Now.ToString("dd MMMM yyyy");
           
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                dtStatus = new DataTable();
                dtStatus = dh.GetTable("SELECT status_id ,status_name FROM Status");
                cmb_status.LoadItems(dtStatus, "status_name", "status_id");
                dtEmployee = new DataTable();
                dtEmployee = dh.GetTable("SELECT e.e_id [e_id], e_name_en FROM Employees e LEFT JOIN users u on e.e_id =  u.e_id where isadmin = 0");
                cmb_Employee.LoadItems(dtEmployee, "e_name_en", "e_id");
                dt = new DataTable();
                dt = dh.GetTable(@"SELECT task_name AS [Task Name], 
                                        task_end_date AS [Deadline], 
                                        s.status_name AS [Status], 
                                        ABS(DATEDIFF(HOUR, task_start_date, task_end_date)) AS [Working Hours],
                                        e_name_en AS [Assignee]
                                 FROM Tasks t
                                 LEFT JOIN Status s ON t.status_id = s.status_id
                                 LEFT JOIN Employees e ON t.user_id = e.e_id
                                 WHERE e.e_id = e.e_id 
                                 AND t.status_id = t.status_id");
                dgv_Tasks.DataSource = dt;
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dgv_Tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                string query = @"SELECT task_name [Task name], task_end_date [Deadline], s.status_name [Status], ABS(DATEDIFF(HOUR, task_start_date, task_end_date)) [Working Hours]
                            ,e_name_en [Assignee]
                            FROM Tasks t
                            LEFT join Status s on t.status_id = s.status_id
                            LEFT Join Employees e on t.user_id = e.e_id
                             WHERE e.e_id = " + ((int)cmb_Employee.SelectedValue != -1 ? cmb_Employee.SelectedValue.ToString() : "e.e_id")
                                 + " AND t.status_id = " + ((int)cmb_status.SelectedValue != -1 ? cmb_status.SelectedValue.ToString() : "t.status_id ")
                                 + (dtStart != null ? " AND t.task_start_date = ' " + dtStart?.ToString("yyyy-MM-dd") + "'" : "")
                                 + (dtEnd != null ? " AND t.task_end_date = ' " + dtEnd?.ToString("yyyy-MM-dd") + "'" : "")
                                 + (txt_srchTaskName.Texts != "" ? " AND t.task_name LIKE '"+ txt_srchTaskName.Texts + "%'" : "");
                dt = dh.GetTable(query);
                dgv_Tasks.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddTasks_Click(object sender, EventArgs e)
        {
            try
            {
                AddTasks addTasks = new AddTasks();
                addTasks.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
