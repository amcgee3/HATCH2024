using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HATCH_2024
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static SQLiteConnection connect()
        {
            SQLiteConnection conn;
            string connect = "Data Source = C:\\Users\\amcge\\source\\repos\\HATCH 2024\\HATCH 2024\\Astronaut.db";
            conn = new SQLiteConnection(connect);

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return conn;

        }
    }
}
