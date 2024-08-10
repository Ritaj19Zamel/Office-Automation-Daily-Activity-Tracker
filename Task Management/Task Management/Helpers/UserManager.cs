using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management.Models;

namespace Task_Management.Helpers
{
    public static class UserManager
    {
        private static string connectionString = "data source= .;Integrated Security=true;Initial Catalog=Office_Automation_Daily_Activity_Tracker";

        public static User Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT u.user_id, u.e_id, u.isadmin, e.e_name_en FROM users u " +
                               "JOIN Employees e ON u.e_id = e.e_id " +
                               "WHERE u.username = @username AND u.password = @password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserId = (int)reader["user_id"],
                        EmployeeId = (int)reader["e_id"],
                        IsAdmin = (bool)reader["isadmin"],
                        EmployeeName = reader["e_name_en"].ToString()
                    };
                }
            }
            return null;
        }

        public static DataTable GetUsersWithUnreadCount(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT e.e_name_en, u.user_id, COUNT(m.message_id) AS UnreadCount " +
                               "FROM Employees e " +
                               "JOIN users u ON e.e_id = u.e_id " +
                               "LEFT JOIN Messages m ON m.receiver_id = u.user_id AND m.is_read = 0 " +
                               "WHERE u.user_id <> @userId " +
                               "GROUP BY e.e_name_en, u.user_id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetChatMessages(int userId, int contactId)
        {
            string query = @"SELECT sender_id, message_text, timestamp 
                     FROM Messages 
                     WHERE (sender_id = @userId AND receiver_id = @contactId) 
                        OR (sender_id = @contactId AND receiver_id = @userId) 
                     ORDER BY timestamp ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@contactId", contactId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        public static void SendMessage(int senderId, int receiverId, string messageText)
        {
            string query = @"INSERT INTO Messages (sender_id, receiver_id, message_text) 
                     VALUES (@senderId, @receiverId, @messageText)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@senderId", senderId);
                    cmd.Parameters.AddWithValue("@receiverId", receiverId);
                    cmd.Parameters.AddWithValue("@messageText", messageText);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static void MarkMessagesAsRead(int userId, int contactId)
        {
            string query = @"UPDATE Messages 
                     SET is_read = 1 
                     WHERE receiver_id = @userId AND sender_id = @contactId AND is_read = 0";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@contactId", contactId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
