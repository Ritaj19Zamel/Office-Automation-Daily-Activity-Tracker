
namespace Task_Management
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.txt_pass = new Task_Management.CustomControls.CustomTextBox();
            this.txt_username = new Task_Management.CustomControls.CustomTextBox();
            this.btn_login = new Task_Management.CustomControls.CustomButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_header = new System.Windows.Forms.Label();
            this.Logo_picbox = new System.Windows.Forms.PictureBox();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidebarPanel.Controls.Add(this.txt_pass);
            this.sidebarPanel.Controls.Add(this.txt_username);
            this.sidebarPanel.Controls.Add(this.btn_login);
            this.sidebarPanel.Controls.Add(this.label1);
            this.sidebarPanel.Controls.Add(this.lb_header);
            this.sidebarPanel.Controls.Add(this.Logo_picbox);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(950, 600);
            this.sidebarPanel.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_pass.BorderColor = System.Drawing.Color.DimGray;
            this.txt_pass.BorderFocusColor = System.Drawing.Color.Gray;
            this.txt_pass.BorderRadius = 10;
            this.txt_pass.BorderSize = 2;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_pass.Location = new System.Drawing.Point(462, 225);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_pass.PasswordChar = true;
            this.txt_pass.PlaceholderColor = System.Drawing.Color.DarkGreen;
            this.txt_pass.PlaceholderText = "Password";
            this.txt_pass.Size = new System.Drawing.Size(295, 35);
            this.txt_pass.TabIndex = 8;
            this.txt_pass.Texts = "";
            this.txt_pass.UnderlinedStyle = false;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_username.BorderColor = System.Drawing.Color.DimGray;
            this.txt_username.BorderFocusColor = System.Drawing.Color.Gray;
            this.txt_username.BorderRadius = 10;
            this.txt_username.BorderSize = 2;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_username.Location = new System.Drawing.Point(462, 171);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_username.PasswordChar = false;
            this.txt_username.PlaceholderColor = System.Drawing.Color.DarkGreen;
            this.txt_username.PlaceholderText = "User Name";
            this.txt_username.Size = new System.Drawing.Size(295, 35);
            this.txt_username.TabIndex = 7;
            this.txt_username.Texts = "";
            this.txt_username.UnderlinedStyle = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkGray;
            this.btn_login.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btn_login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_login.BorderRadius = 20;
            this.btn_login.BorderSize = 0;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_login.Location = new System.Drawing.Point(530, 299);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(150, 40);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.TextColor = System.Drawing.Color.DarkGreen;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to";
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lb_header.ForeColor = System.Drawing.Color.White;
            this.lb_header.Location = new System.Drawing.Point(524, 81);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(253, 32);
            this.lb_header.TabIndex = 0;
            this.lb_header.Text = "WorkStream Tracker!";
            // 
            // Logo_picbox
            // 
            this.Logo_picbox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_picbox.Image")));
            this.Logo_picbox.Location = new System.Drawing.Point(24, 21);
            this.Logo_picbox.Name = "Logo_picbox";
            this.Logo_picbox.Size = new System.Drawing.Size(416, 401);
            this.Logo_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo_picbox.TabIndex = 0;
            this.Logo_picbox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.sidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo_picbox;
        private CustomControls.CustomButtons btn_login;
        private CustomControls.CustomTextBox txt_pass;
        private CustomControls.CustomTextBox txt_username;
    }
}