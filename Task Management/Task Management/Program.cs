using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Messages(2));
            // Application.Run(new Analytics_Dashboard());
            // Application.Run(new Login());
            // Application.Run(new Admin_Dashboard());
            // Application.Run(new AddTasks());
        }
    }
}
