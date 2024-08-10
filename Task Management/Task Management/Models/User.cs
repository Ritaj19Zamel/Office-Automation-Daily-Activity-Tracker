using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int EmployeeId { get; set; }
        public bool IsAdmin { get; set; }
        public string EmployeeName { get; set; } // e_name_en from Employees table
    }

}
