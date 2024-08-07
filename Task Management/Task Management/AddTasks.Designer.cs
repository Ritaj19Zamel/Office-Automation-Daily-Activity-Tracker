
namespace Task_Management
{
    partial class AddTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTasks));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.lb_weclcome = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btn_Messages = new System.Windows.Forms.Button();
            this.btn_Analytics = new System.Windows.Forms.Button();
            this.btn_AddTasks = new System.Windows.Forms.Button();
            this.btn_AllTasks = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo_picbox = new System.Windows.Forms.PictureBox();
            this.lb_header = new System.Windows.Forms.Label();
            this.paneldata = new System.Windows.Forms.Panel();
            this.cmb_AssignTo = new Task_Management.CustomControls.CustomComboBox();
            this.btn_Submit = new Task_Management.CustomControls.CustomButtons();
            this.txt_TaskName = new Task_Management.CustomControls.CustomTextBox();
            this.txt_TaskDesc = new Task_Management.CustomControls.CustomTextBox();
            this.pnl_main.SuspendLayout();
            this.pnl_search.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).BeginInit();
            this.paneldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_main.Controls.Add(this.paneldata);
            this.pnl_main.Controls.Add(this.pnl_search);
            this.pnl_main.Controls.Add(this.sidebarPanel);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(932, 553);
            this.pnl_main.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(355, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Assign To";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(496, 51);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(93, 24);
            this.dtp_EndDate.TabIndex = 11;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(355, 51);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(93, 24);
            this.dtp_StartDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(495, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(355, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Task Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Name";
            // 
            // pnl_search
            // 
            this.pnl_search.Controls.Add(this.lb_weclcome);
            this.pnl_search.Controls.Add(this.lb_Date);
            this.pnl_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_search.Location = new System.Drawing.Point(250, 0);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(682, 72);
            this.pnl_search.TabIndex = 4;
            // 
            // lb_weclcome
            // 
            this.lb_weclcome.AutoSize = true;
            this.lb_weclcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lb_weclcome.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_weclcome.Location = new System.Drawing.Point(163, 18);
            this.lb_weclcome.Name = "lb_weclcome";
            this.lb_weclcome.Size = new System.Drawing.Size(218, 41);
            this.lb_weclcome.TabIndex = 0;
            this.lb_weclcome.Text = "Add New Task";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Date.ForeColor = System.Drawing.Color.Silver;
            this.lb_Date.Location = new System.Drawing.Point(7, 45);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(46, 23);
            this.lb_Date.TabIndex = 2;
            this.lb_Date.Text = "date";
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
            this.sidebarPanel.TabIndex = 19;
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
            // paneldata
            // 
            this.paneldata.Controls.Add(this.cmb_AssignTo);
            this.paneldata.Controls.Add(this.dtp_EndDate);
            this.paneldata.Controls.Add(this.dtp_StartDate);
            this.paneldata.Controls.Add(this.btn_Submit);
            this.paneldata.Controls.Add(this.txt_TaskName);
            this.paneldata.Controls.Add(this.label5);
            this.paneldata.Controls.Add(this.txt_TaskDesc);
            this.paneldata.Controls.Add(this.label1);
            this.paneldata.Controls.Add(this.label2);
            this.paneldata.Controls.Add(this.label4);
            this.paneldata.Controls.Add(this.label3);
            this.paneldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldata.Location = new System.Drawing.Point(250, 72);
            this.paneldata.Name = "paneldata";
            this.paneldata.Size = new System.Drawing.Size(682, 481);
            this.paneldata.TabIndex = 20;
            // 
            // cmb_AssignTo
            // 
            this.cmb_AssignTo.BackColor = System.Drawing.Color.LightGray;
            this.cmb_AssignTo.BorderColor = System.Drawing.Color.DarkGreen;
            this.cmb_AssignTo.BorderSize = 1;
            this.cmb_AssignTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_AssignTo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmb_AssignTo.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_AssignTo.IconColor = System.Drawing.Color.DarkGreen;
            this.cmb_AssignTo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_AssignTo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_AssignTo.Location = new System.Drawing.Point(355, 128);
            this.cmb_AssignTo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_AssignTo.Name = "cmb_AssignTo";
            this.cmb_AssignTo.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_AssignTo.Size = new System.Drawing.Size(209, 30);
            this.cmb_AssignTo.TabIndex = 16;
            this.cmb_AssignTo.Texts = "";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Submit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Submit.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Submit.BorderColor = System.Drawing.Color.DarkCyan;
            this.btn_Submit.BorderRadius = 20;
            this.btn_Submit.BorderSize = 0;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(231, 310);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(150, 40);
            this.btn_Submit.TabIndex = 15;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.TextColor = System.Drawing.Color.White;
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // txt_TaskName
            // 
            this.txt_TaskName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TaskName.BorderColor = System.Drawing.Color.DarkGreen;
            this.txt_TaskName.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txt_TaskName.BorderRadius = 10;
            this.txt_TaskName.BorderSize = 2;
            this.txt_TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TaskName.Location = new System.Drawing.Point(30, 51);
            this.txt_TaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaskName.Multiline = false;
            this.txt_TaskName.Name = "txt_TaskName";
            this.txt_TaskName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TaskName.PasswordChar = false;
            this.txt_TaskName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TaskName.PlaceholderText = "";
            this.txt_TaskName.Size = new System.Drawing.Size(246, 35);
            this.txt_TaskName.TabIndex = 17;
            this.txt_TaskName.Texts = "";
            this.txt_TaskName.UnderlinedStyle = false;
            // 
            // txt_TaskDesc
            // 
            this.txt_TaskDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TaskDesc.BorderColor = System.Drawing.Color.DarkGreen;
            this.txt_TaskDesc.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txt_TaskDesc.BorderRadius = 10;
            this.txt_TaskDesc.BorderSize = 2;
            this.txt_TaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaskDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TaskDesc.Location = new System.Drawing.Point(30, 128);
            this.txt_TaskDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaskDesc.Multiline = true;
            this.txt_TaskDesc.Name = "txt_TaskDesc";
            this.txt_TaskDesc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TaskDesc.PasswordChar = false;
            this.txt_TaskDesc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TaskDesc.PlaceholderText = "";
            this.txt_TaskDesc.Size = new System.Drawing.Size(246, 103);
            this.txt_TaskDesc.TabIndex = 18;
            this.txt_TaskDesc.Texts = "";
            this.txt_TaskDesc.UnderlinedStyle = false;
            // 
            // AddTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.pnl_main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "AddTasks";
            this.Text = "AddTasks";
            this.pnl_main.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).EndInit();
            this.paneldata.ResumeLayout(false);
            this.paneldata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.Label lb_weclcome;
        private System.Windows.Forms.Label lb_Date;
        private CustomControls.CustomButtons btn_Submit;
        private CustomControls.CustomComboBox cmb_AssignTo;
        private CustomControls.CustomTextBox txt_TaskName;
        private CustomControls.CustomTextBox txt_TaskDesc;
        private System.Windows.Forms.Panel paneldata;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.Button btn_Analytics;
        private System.Windows.Forms.Button btn_AddTasks;
        private System.Windows.Forms.Button btn_AllTasks;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Logo_picbox;
        private System.Windows.Forms.Label lb_header;
    }
}