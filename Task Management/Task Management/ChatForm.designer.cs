
namespace Task_Management
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.ListBox lstContacts;

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
            this.lblContactName = new System.Windows.Forms.Label();
            this.flowLayoutPanelMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(192, 20);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(173, 29);
            this.lblContactName.TabIndex = 3;
            this.lblContactName.Text = "Contact Name";
            // 
            // flowLayoutPanelMessages
            // 
            this.flowLayoutPanelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMessages.AutoScroll = true;
            this.flowLayoutPanelMessages.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMessages.Location = new System.Drawing.Point(220, 60);
            this.flowLayoutPanelMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelMessages.Name = "flowLayoutPanelMessages";
            this.flowLayoutPanelMessages.Size = new System.Drawing.Size(556, 400);
            this.flowLayoutPanelMessages.TabIndex = 2;
            this.flowLayoutPanelMessages.WrapContents = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMessage.Location = new System.Drawing.Point(192, 480);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(473, 30);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(674, 480);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 30);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.sidePanel.Controls.Add(this.lstContacts);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(175, 540);
            this.sidePanel.TabIndex = 4;
            // 
            // lstContacts
            // 
            this.lstContacts.BackColor = System.Drawing.Color.White;
            this.lstContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstContacts.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 19;
            this.lstContacts.Location = new System.Drawing.Point(0, 0);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(175, 540);
            this.lstContacts.TabIndex = 0;
            this.lstContacts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstContacts_DrawItem);
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 540);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.flowLayoutPanelMessages);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.sidePanel);
            this.Name = "ChatForm";
            this.Text = "Chat";
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
    }
}