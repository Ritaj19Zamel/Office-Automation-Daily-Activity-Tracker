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
    public partial class Messages : Form
    {
        private int _currentUserId;
        DatabaseHelper dh = new DatabaseHelper();
        DataTable dtUser, dtMessages;
        public Messages(int currentUserId)
        {
            _currentUserId = currentUserId;
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
             dtUser = new DataTable();
             string query = "SELECT user_id, username FROM users";
               dtUser =  dh.GetTable(query);
            foreach (DataRow row in dtUser.Rows)
            {
                lst_Users.Items.Add(new User
                {
                    UserId = Convert.ToInt32(row["user_id"]),
                    Username = row["username"].ToString()
                });
            }


        }
        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Users.SelectedItem is User selectedUser)
            {
                LoadMessages(selectedUser.UserId);
            }
        }

        private void LoadMessages(int userId)
        {

            textBoxMessages.Clear();
            dtMessages = new DataTable();
            string query = $"SELECT message_text, timestamp FROM messages WHERE receiver_id = {userId}";
            dtMessages = dh.GetTable(query);
            foreach (DataRow row in dtMessages.Rows)
            {
                textBoxMessages.AppendText($"{Convert.ToDateTime(row["timestamp"])}: {row["message_text"]}\r\n");
            }

        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (lst_Users.SelectedItem is User selectedUser)
            {
                SendMessage(selectedUser.UserId, textBoxNewMessage.Texts);
                textBoxNewMessage.Texts = "";
                LoadMessages(selectedUser.UserId);
            }
        }

        private void SendMessage(int receiverId, string messageText)
        {
           
                string query = $"INSERT INTO messages (sender_id, receiver_id, message_text) VALUES ({_currentUserId}, {receiverId}, '{messageText}')";
                dh.ExeCommand(query);
              
            
        }
        public class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }

            public override string ToString()
            {
                return Username;
            }
        }


    }
}
