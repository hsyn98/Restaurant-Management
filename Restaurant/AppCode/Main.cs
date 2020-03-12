using Restaurant.AppCode;
using Restaurant.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
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

            MyClient client = new MyClient();
            DataTable dt = new DataTable();
            dt = client.GetTable("Select Count(*) From Users");
            Application.Run(new FirstAdmin());
            //if (dt.Rows[0][0].ToString() != "0")
            //{
            //    Application.Run(new Login());
            //}
            //else
            //    Application.Run(new FirstAdmin());
        }
    }
}
