
namespace Task_Management
{
    partial class TaskDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetailsForm));
            this.lbTaskName = new System.Windows.Forms.Label();
            this.btn_Close = new Task_Management.CustomControls.CustomButtons();
            this.btn_min = new Task_Management.CustomControls.CustomButtons();
            this.lb_description = new System.Windows.Forms.Label();
            this.lbSatus = new System.Windows.Forms.Label();
            this.btn_status = new Task_Management.CustomControls.CustomButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_startdate = new System.Windows.Forms.Label();
            this.lb_endDate = new System.Windows.Forms.Label();
            this.lb_Assign = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTaskName
            // 
            this.lbTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTaskName.Location = new System.Drawing.Point(100, 20);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(280, 33);
            this.lbTaskName.TabIndex = 0;
            this.lbTaskName.Text = "label1";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Close.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Close.BorderRadius = 20;
            this.btn_Close.BorderSize = 0;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(759, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(38, 40);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TextColor = System.Drawing.Color.White;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_min.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btn_min.BorderColor = System.Drawing.Color.DimGray;
            this.btn_min.BorderRadius = 20;
            this.btn_min.BorderSize = 0;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(715, 2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(38, 40);
            this.btn_min.TabIndex = 2;
            this.btn_min.TextColor = System.Drawing.Color.White;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // lb_description
            // 
            this.lb_description.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.ForeColor = System.Drawing.Color.DimGray;
            this.lb_description.Location = new System.Drawing.Point(100, 81);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(527, 90);
            this.lb_description.TabIndex = 3;
            this.lb_description.Text = "label1";
            // 
            // lbSatus
            // 
            this.lbSatus.AutoSize = true;
            this.lbSatus.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSatus.ForeColor = System.Drawing.Color.DarkGray;
            this.lbSatus.Location = new System.Drawing.Point(100, 246);
            this.lbSatus.Name = "lbSatus";
            this.lbSatus.Size = new System.Drawing.Size(53, 17);
            this.lbSatus.TabIndex = 4;
            this.lbSatus.Text = "Status";
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_status.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_status.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_status.BorderRadius = 20;
            this.btn_status.BorderSize = 0;
            this.btn_status.FlatAppearance.BorderSize = 0;
            this.btn_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_status.ForeColor = System.Drawing.Color.White;
            this.btn_status.Location = new System.Drawing.Point(219, 232);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(123, 40);
            this.btn_status.TabIndex = 5;
            this.btn_status.Text = "customButtons1";
            this.btn_status.TextColor = System.Drawing.Color.White;
            this.btn_status.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(100, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(100, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Date";
            // 
            // lb_startdate
            // 
            this.lb_startdate.Location = new System.Drawing.Point(219, 273);
            this.lb_startdate.Name = "lb_startdate";
            this.lb_startdate.Size = new System.Drawing.Size(123, 34);
            this.lb_startdate.TabIndex = 8;
            this.lb_startdate.Text = "label3";
            this.lb_startdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_endDate
            // 
            this.lb_endDate.Location = new System.Drawing.Point(219, 308);
            this.lb_endDate.Name = "lb_endDate";
            this.lb_endDate.Size = new System.Drawing.Size(123, 34);
            this.lb_endDate.TabIndex = 9;
            this.lb_endDate.Text = "label4";
            this.lb_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Assign
            // 
            this.lb_Assign.Location = new System.Drawing.Point(219, 195);
            this.lb_Assign.Name = "lb_Assign";
            this.lb_Assign.Size = new System.Drawing.Size(123, 34);
            this.lb_Assign.TabIndex = 11;
            this.lb_Assign.Text = "label3";
            this.lb_Assign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(100, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Assigned To";
            // 
            // TaskDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Assign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_endDate);
            this.Controls.Add(this.lb_startdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.lbSatus);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskDetailsForm";
            this.Text = "Preview_Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaskName;
        private CustomControls.CustomButtons btn_Close;
        private CustomControls.CustomButtons btn_min;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lbSatus;
        private CustomControls.CustomButtons btn_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_startdate;
        private System.Windows.Forms.Label lb_endDate;
        private System.Windows.Forms.Label lb_Assign;
        private System.Windows.Forms.Label label4;
    }
}