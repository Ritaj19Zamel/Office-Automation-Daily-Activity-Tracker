
using System.Drawing;
using System.Windows.Forms;

namespace Task_Management
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btn_Messages = new System.Windows.Forms.Button();
            this.btn_Analytics = new System.Windows.Forms.Button();
            this.btn_AddTasks = new System.Windows.Forms.Button();
            this.btn_AllTasks = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo_picbox = new System.Windows.Forms.PictureBox();
            this.lb_header = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_summary = new System.Windows.Forms.Panel();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.dgv_Tasks = new System.Windows.Forms.DataGridView();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_weclcome = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.btn_Search = new Task_Management.CustomControls.CustomButtons();
            this.cmb_Employee = new Task_Management.CustomControls.CustomComboBox();
            this.txt_srchTaskName = new Task_Management.CustomControls.CustomTextBox();
            this.cmb_status = new Task_Management.CustomControls.CustomComboBox();
            this.sidebarPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.pnl_summary.SuspendLayout();
            this.gb_Search.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).BeginInit();
            this.pnl_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidebarPanel.Controls.Add(this.btn_Messages);
            this.sidebarPanel.Controls.Add(this.btn_Analytics);
            this.sidebarPanel.Controls.Add(this.btn_AddTasks);
            this.sidebarPanel.Controls.Add(this.btn_AllTasks);
            this.sidebarPanel.Controls.Add(this.panelLogo);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(250, 553);
            this.sidebarPanel.TabIndex = 0;
            // 
            // btn_Messages
            // 
            this.btn_Messages.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Messages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Messages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Messages.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Messages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Messages.ForeColor = System.Drawing.Color.White;
            this.btn_Messages.Image = ((System.Drawing.Image)(resources.GetObject("btn_Messages.Image")));
            this.btn_Messages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Messages.Location = new System.Drawing.Point(0, 248);
            this.btn_Messages.Name = "btn_Messages";
            this.btn_Messages.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Messages.Size = new System.Drawing.Size(250, 45);
            this.btn_Messages.TabIndex = 5;
            this.btn_Messages.Text = "  Messages";
            this.btn_Messages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Messages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Messages.UseVisualStyleBackColor = false;
            this.btn_Messages.Click += new System.EventHandler(this.btn_Messages_Click);
            // 
            // btn_Analytics
            // 
            this.btn_Analytics.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Analytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Analytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Analytics.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Analytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Analytics.ForeColor = System.Drawing.Color.White;
            this.btn_Analytics.Image = ((System.Drawing.Image)(resources.GetObject("btn_Analytics.Image")));
            this.btn_Analytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Analytics.Location = new System.Drawing.Point(0, 203);
            this.btn_Analytics.Name = "btn_Analytics";
            this.btn_Analytics.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Analytics.Size = new System.Drawing.Size(250, 45);
            this.btn_Analytics.TabIndex = 4;
            this.btn_Analytics.Text = "  Analytics";
            this.btn_Analytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Analytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Analytics.UseVisualStyleBackColor = false;
            this.btn_Analytics.Visible = false;
            // 
            // btn_AddTasks
            // 
            this.btn_AddTasks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_AddTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddTasks.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_AddTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_AddTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTasks.ForeColor = System.Drawing.Color.White;
            this.btn_AddTasks.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddTasks.Image")));
            this.btn_AddTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddTasks.Location = new System.Drawing.Point(0, 158);
            this.btn_AddTasks.Name = "btn_AddTasks";
            this.btn_AddTasks.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_AddTasks.Size = new System.Drawing.Size(250, 45);
            this.btn_AddTasks.TabIndex = 3;
            this.btn_AddTasks.Text = "  Add Tasks";
            this.btn_AddTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddTasks.UseVisualStyleBackColor = false;
            this.btn_AddTasks.Visible = false;
            this.btn_AddTasks.Click += new System.EventHandler(this.btn_AddTasks_Click);
            // 
            // btn_AllTasks
            // 
            this.btn_AllTasks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_AllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AllTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AllTasks.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_AllTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_AllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AllTasks.ForeColor = System.Drawing.Color.White;
            this.btn_AllTasks.Image = ((System.Drawing.Image)(resources.GetObject("btn_AllTasks.Image")));
            this.btn_AllTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AllTasks.Location = new System.Drawing.Point(0, 113);
            this.btn_AllTasks.Name = "btn_AllTasks";
            this.btn_AllTasks.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_AllTasks.Size = new System.Drawing.Size(250, 45);
            this.btn_AllTasks.TabIndex = 1;
            this.btn_AllTasks.Text = "  All Tasks";
            this.btn_AllTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AllTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AllTasks.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Logo_picbox);
            this.panelLogo.Controls.Add(this.lb_header);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 113);
            this.panelLogo.TabIndex = 9;
            // 
            // Logo_picbox
            // 
            this.Logo_picbox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_picbox.Image")));
            this.Logo_picbox.Location = new System.Drawing.Point(88, 3);
            this.Logo_picbox.Name = "Logo_picbox";
            this.Logo_picbox.Size = new System.Drawing.Size(74, 75);
            this.Logo_picbox.TabIndex = 0;
            this.Logo_picbox.TabStop = false;
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_header.ForeColor = System.Drawing.Color.White;
            this.lb_header.Location = new System.Drawing.Point(23, 81);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(204, 28);
            this.lb_header.TabIndex = 0;
            this.lb_header.Text = "WorkStream Tracker";
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_main.Controls.Add(this.pnl_summary);
            this.pnl_main.Controls.Add(this.pnl_data);
            this.pnl_main.Controls.Add(this.pnl_search);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(250, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(682, 553);
            this.pnl_main.TabIndex = 1;
            // 
            // pnl_summary
            // 
            this.pnl_summary.Controls.Add(this.gb_Search);
            this.pnl_summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_summary.Location = new System.Drawing.Point(0, 57);
            this.pnl_summary.Name = "pnl_summary";
            this.pnl_summary.Size = new System.Drawing.Size(682, 179);
            this.pnl_summary.TabIndex = 5;
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.btn_Search);
            this.gb_Search.Controls.Add(this.label2);
            this.gb_Search.Controls.Add(this.dtp_EndDate);
            this.gb_Search.Controls.Add(this.label1);
            this.gb_Search.Controls.Add(this.dtp_StartDate);
            this.gb_Search.Controls.Add(this.cmb_Employee);
            this.gb_Search.Controls.Add(this.txt_srchTaskName);
            this.gb_Search.Controls.Add(this.cmb_status);
            this.gb_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Search.Location = new System.Drawing.Point(0, 0);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Size = new System.Drawing.Size(682, 179);
            this.gb_Search.TabIndex = 1;
            this.gb_Search.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Date";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(105, 139);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(96, 24);
            this.dtp_EndDate.TabIndex = 8;
            this.dtp_EndDate.ValueChanged += new System.EventHandler(this.dtp_EndDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Date";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(105, 109);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(96, 24);
            this.dtp_StartDate.TabIndex = 6;
            this.dtp_StartDate.ValueChanged += new System.EventHandler(this.dtp_StartDate_ValueChanged);
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.dgv_Tasks);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_data.Location = new System.Drawing.Point(0, 236);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(682, 317);
            this.pnl_data.TabIndex = 6;
            // 
            // dgv_Tasks
            // 
            this.dgv_Tasks.AllowUserToAddRows = false;
            this.dgv_Tasks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.dgv_Tasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Tasks.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Tasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Tasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Tasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Tasks.GridColor = System.Drawing.Color.White;
            this.dgv_Tasks.Location = new System.Drawing.Point(0, 0);
            this.dgv_Tasks.Name = "dgv_Tasks";
            this.dgv_Tasks.ReadOnly = true;
            this.dgv_Tasks.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Tasks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Tasks.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_Tasks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Tasks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgv_Tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tasks.Size = new System.Drawing.Size(682, 317);
            this.dgv_Tasks.TabIndex = 0;
            this.dgv_Tasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tasks_CellClick);
            // 
            // pnl_search
            // 
            this.pnl_search.Controls.Add(this.lb_name);
            this.pnl_search.Controls.Add(this.lb_weclcome);
            this.pnl_search.Controls.Add(this.lb_Date);
            this.pnl_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_search.Location = new System.Drawing.Point(0, 0);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(682, 57);
            this.pnl_search.TabIndex = 4;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_name.Location = new System.Drawing.Point(161, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(64, 28);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "name";
            // 
            // lb_weclcome
            // 
            this.lb_weclcome.AutoSize = true;
            this.lb_weclcome.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_weclcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lb_weclcome.Location = new System.Drawing.Point(0, 0);
            this.lb_weclcome.Name = "lb_weclcome";
            this.lb_weclcome.Size = new System.Drawing.Size(161, 28);
            this.lb_weclcome.TabIndex = 0;
            this.lb_weclcome.Text = "Welcome back, ";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Date.ForeColor = System.Drawing.Color.Silver;
            this.lb_Date.Location = new System.Drawing.Point(6, 28);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(46, 23);
            this.lb_Date.TabIndex = 2;
            this.lb_Date.Text = "date";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Search.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Search.BorderColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.BorderRadius = 20;
            this.btn_Search.BorderSize = 0;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(520, 133);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(150, 40);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextColor = System.Drawing.Color.White;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Employee
            // 
            this.cmb_Employee.BackColor = System.Drawing.Color.LightGray;
            this.cmb_Employee.BorderColor = System.Drawing.Color.DarkGreen;
            this.cmb_Employee.BorderSize = 1;
            this.cmb_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_Employee.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmb_Employee.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Employee.IconColor = System.Drawing.Color.DarkGreen;
            this.cmb_Employee.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_Employee.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_Employee.Location = new System.Drawing.Point(283, 26);
            this.cmb_Employee.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_Employee.Name = "cmb_Employee";
            this.cmb_Employee.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_Employee.PlaceholderText = "Employees (All)";
            this.cmb_Employee.SelectedValue = null;
            this.cmb_Employee.Size = new System.Drawing.Size(200, 30);
            this.cmb_Employee.TabIndex = 5;
            this.cmb_Employee.Texts = "";
            // 
            // txt_srchTaskName
            // 
            this.txt_srchTaskName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txt_srchTaskName.BackColor = System.Drawing.Color.LightGray;
            this.txt_srchTaskName.BorderColor = System.Drawing.Color.DarkGreen;
            this.txt_srchTaskName.BorderFocusColor = System.Drawing.Color.DarkSlateGray;
            this.txt_srchTaskName.BorderRadius = 0;
            this.txt_srchTaskName.BorderSize = 2;
            this.txt_srchTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srchTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_srchTaskName.Location = new System.Drawing.Point(10, 24);
            this.txt_srchTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_srchTaskName.Multiline = false;
            this.txt_srchTaskName.Name = "txt_srchTaskName";
            this.txt_srchTaskName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_srchTaskName.PasswordChar = false;
            this.txt_srchTaskName.PlaceholderColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_srchTaskName.PlaceholderText = "Search by Task Name...";
            this.txt_srchTaskName.Size = new System.Drawing.Size(266, 35);
            this.txt_srchTaskName.TabIndex = 3;
            this.txt_srchTaskName.Texts = "";
            this.txt_srchTaskName.UnderlinedStyle = false;
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.LightGray;
            this.cmb_status.BorderColor = System.Drawing.Color.DarkGreen;
            this.cmb_status.BorderSize = 1;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_status.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmb_status.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_status.IconColor = System.Drawing.Color.DarkGreen;
            this.cmb_status.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_status.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_status.Location = new System.Drawing.Point(10, 71);
            this.cmb_status.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_status.PlaceholderText = "Status (All)";
            this.cmb_status.SelectedValue = null;
            this.cmb_status.Size = new System.Drawing.Size(200, 30);
            this.cmb_status.TabIndex = 4;
            this.cmb_status.Texts = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.sidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_summary.ResumeLayout(false);
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).EndInit();
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.PictureBox Logo_picbox;
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.Button btn_Analytics;
        private System.Windows.Forms.Button btn_AddTasks;
        private System.Windows.Forms.Button btn_AllTasks;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.Panel pnl_summary;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.Label lb_weclcome;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.Panel panelLogo;
        private CustomControls.CustomTextBox txt_srchTaskName;
        private System.Windows.Forms.DataGridView dgv_Tasks;
        private CustomControls.CustomComboBox cmb_status;
        private CustomControls.CustomComboBox cmb_Employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private CustomControls.CustomButtons btn_Search;
    }
}

