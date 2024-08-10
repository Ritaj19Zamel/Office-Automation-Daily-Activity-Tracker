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
    public partial class ChatForm : Form
    {
        private User currentUser;
        private int contactId;
        private string contactName;

        public ChatForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadContacts();
        }
        private void LoadContacts()
        {
            DataTable users = UserManager.GetUsersWithUnreadCount(currentUser.UserId);

            foreach (DataRow row in users.Rows)
            {
                string userName = row["e_name_en"].ToString();
                int userId = (int)row["user_id"];
                int unreadCount = (int)row["UnreadCount"];

                string displayText = userName;
                if (unreadCount > 0)
                {
                    displayText += $" ({unreadCount} unread)";
                }

                ListBoxItem item = new ListBoxItem(displayText, userId, unreadCount);
                lstContacts.Items.Add(item);
            }
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem is ListBoxItem selectedItem)
            {
                contactId = selectedItem.UserId;
                contactName = selectedItem.DisplayText.Split('(')[0].Trim();

                lblContactName.Text = contactName;
                LoadMessages();
            }
        }

        // Custom ListBoxItem class to handle the display text and data
        public class ListBoxItem
        {
            public string DisplayText { get; set; }
            public int UserId { get; set; }
            public int UnreadCount { get; set; }

            public ListBoxItem(string displayText, int userId, int unreadCount)
            {
                DisplayText = displayText;
                UserId = userId;
                UnreadCount = unreadCount;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }
        private void lstContacts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = (ListBox)sender;
            ListBoxItem item = (ListBoxItem)listBox.Items[e.Index];

            // Determine the color to draw the item in.
            Color textColor = (item.UnreadCount > 0) ? Color.Red : Color.Black;

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            // Create a brush for the text color.
            using (Brush textBrush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(item.DisplayText, e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);
            }

            // Draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }



        private void LoadMessages()
        {
            // Retrieve messages between the current user and the selected contact
            DataTable messages = UserManager.GetChatMessages(currentUser.UserId, contactId);

            if (messages.Rows.Count == 0)
            {

                flowLayoutPanelMessages.Controls.Clear();
                return;

            }

            foreach (DataRow row in messages.Rows)
            {
                int senderId = (int)row["sender_id"];
                string messageText = row["message_text"].ToString();
                DateTime timestamp = (DateTime)row["timestamp"];

                // Add the message to the chat form
                AddMessage(senderId == currentUser.UserId ? "right" : "left", messageText, timestamp);
            }

            // Mark all received messages as read
            UserManager.MarkMessagesAsRead(currentUser.UserId, contactId);
        }



        private void AddMessage(string alignment, string messageText, DateTime timestamp)
        {
            Label lblMessage = new Label();
            lblMessage.Text = $"{messageText}\n{timestamp.ToString("hh:mm tt")}";
            lblMessage.AutoSize = true;
            lblMessage.Padding = new Padding(10);
            lblMessage.BackColor = alignment == "right" ? Color.LightBlue : Color.LightGray;
            lblMessage.TextAlign = alignment == "right" ? ContentAlignment.TopRight : ContentAlignment.TopLeft;

            // Create a Panel to hold the message
            Panel messagePanel = new Panel();
            messagePanel.Size = new Size(flowLayoutPanelMessages.ClientSize.Width - 20, lblMessage.Height + 20);
            messagePanel.Controls.Add(lblMessage);

            if (alignment == "right")
            {
                messagePanel.Dock = DockStyle.Right;
                lblMessage.Dock = DockStyle.Right;
            }
            else
            {
                messagePanel.Dock = DockStyle.Left;
                lblMessage.Dock = DockStyle.Left;
            }

            flowLayoutPanelMessages.Controls.Add(messagePanel);
            flowLayoutPanelMessages.SetFlowBreak(messagePanel, true);

            // Scroll to the bottom of the panel
            flowLayoutPanelMessages.ScrollControlIntoView(messagePanel);
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            string messageText = txtMessage.Text;
            if (!string.IsNullOrWhiteSpace(messageText))
            {
                // Save the message to the database
                UserManager.SendMessage(currentUser.UserId, contactId, messageText);

                // Add the message to the chat form (display it)
                AddMessage("right", messageText, DateTime.Now);

                // Clear the text box after sending the message
                txtMessage.Clear();
            }
        }

    }
}
