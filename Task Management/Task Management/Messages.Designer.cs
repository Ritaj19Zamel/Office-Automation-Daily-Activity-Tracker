namespace Task_Management
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.lst_Users = new System.Windows.Forms.ListBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btn_Messages = new System.Windows.Forms.Button();
            this.btn_Analytics = new System.Windows.Forms.Button();
            this.btn_AddTasks = new System.Windows.Forms.Button();
            this.btn_AllTasks = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo_picbox = new System.Windows.Forms.PictureBox();
            this.lb_header = new System.Windows.Forms.Label();
            this.pnl_Chats = new System.Windows.Forms.Panel();
            this.textBoxNewMessage = new Task_Management.CustomControls.CustomTextBox();
            this.pnl_SearchUser = new System.Windows.Forms.Panel();
            this.customTextBox1 = new Task_Management.CustomControls.CustomTextBox();
            this.pnl_users = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).BeginInit();
            this.pnl_Chats.SuspendLayout();
            this.pnl_SearchUser.SuspendLayout();
            this.pnl_users.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Users
            // 
            this.lst_Users.BackColor = System.Drawing.Color.LightGray;
            this.lst_Users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Users.FormattingEnabled = true;
            this.lst_Users.ItemHeight = 16;
            this.lst_Users.Location = new System.Drawing.Point(0, 0);
            this.lst_Users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_Users.Name = "lst_Users";
            this.lst_Users.Size = new System.Drawing.Size(236, 630);
            this.lst_Users.TabIndex = 0;
            this.lst_Users.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(472, 3);
            this.textBoxMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(652, 452);
            this.textBoxMessages.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(762, 580);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(87, 28);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
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
            this.sidebarPanel.Size = new System.Drawing.Size(230, 681);
            this.sidebarPanel.TabIndex = 4;
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
            this.btn_Messages.Size = new System.Drawing.Size(230, 45);
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
            this.btn_Analytics.Size = new System.Drawing.Size(230, 45);
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
            this.btn_AddTasks.Size = new System.Drawing.Size(230, 45);
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
            this.btn_AllTasks.Size = new System.Drawing.Size(230, 45);
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
            this.panelLogo.Size = new System.Drawing.Size(230, 113);
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
            // pnl_Chats
            // 
            this.pnl_Chats.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Chats.Controls.Add(this.pnl_users);
            this.pnl_Chats.Controls.Add(this.pnl_SearchUser);
            this.pnl_Chats.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Chats.Location = new System.Drawing.Point(230, 0);
            this.pnl_Chats.Name = "pnl_Chats";
            this.pnl_Chats.Size = new System.Drawing.Size(236, 681);
            this.pnl_Chats.TabIndex = 5;
            // 
            // textBoxNewMessage
            // 
            this.textBoxNewMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNewMessage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxNewMessage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxNewMessage.BorderRadius = 0;
            this.textBoxNewMessage.BorderSize = 2;
            this.textBoxNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNewMessage.Location = new System.Drawing.Point(472, 463);
            this.textBoxNewMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewMessage.Multiline = true;
            this.textBoxNewMessage.Name = "textBoxNewMessage";
            this.textBoxNewMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxNewMessage.PasswordChar = false;
            this.textBoxNewMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxNewMessage.PlaceholderText = "";
            this.textBoxNewMessage.Size = new System.Drawing.Size(652, 89);
            this.textBoxNewMessage.TabIndex = 6;
            this.textBoxNewMessage.Texts = "";
            this.textBoxNewMessage.UnderlinedStyle = false;
            // 
            // pnl_SearchUser
            // 
            this.pnl_SearchUser.Controls.Add(this.customTextBox1);
            this.pnl_SearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SearchUser.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchUser.Name = "pnl_SearchUser";
            this.pnl_SearchUser.Size = new System.Drawing.Size(236, 51);
            this.pnl_SearchUser.TabIndex = 1;
            // 
            // customTextBox1
            // 
            this.customTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customTextBox1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.Green;
            this.customTextBox1.BorderRadius = 12;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox1.Location = new System.Drawing.Point(5, 8);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "Search...";
            this.customTextBox1.Size = new System.Drawing.Size(227, 35);
            this.customTextBox1.TabIndex = 1;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // pnl_users
            // 
            this.pnl_users.Controls.Add(this.lst_Users);
            this.pnl_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_users.Location = new System.Drawing.Point(0, 51);
            this.pnl_users.Name = "pnl_users";
            this.pnl_users.Size = new System.Drawing.Size(236, 630);
            this.pnl_users.TabIndex = 2;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 681);
            this.Controls.Add(this.textBoxNewMessage);
            this.Controls.Add(this.pnl_Chats);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessages);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Messages";
            this.Text = "Messages";
            this.sidebarPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).EndInit();
            this.pnl_Chats.ResumeLayout(false);
            this.pnl_SearchUser.ResumeLayout(false);
            this.pnl_users.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Users;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.Button btn_Analytics;
        private System.Windows.Forms.Button btn_AddTasks;
        private System.Windows.Forms.Button btn_AllTasks;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Logo_picbox;
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Panel pnl_Chats;
        private CustomControls.CustomTextBox textBoxNewMessage;
        private System.Windows.Forms.Panel pnl_users;
        private System.Windows.Forms.Panel pnl_SearchUser;
        private CustomControls.CustomTextBox customTextBox1;
    }
}
