using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HATCH_2024
{
    public partial class Login : Form
    {
        public int myreader;
        public int myreader2;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {

            SQLiteConnection connection = Program.connect();
            SQLiteCommand command = new SQLiteCommand();
            command = connection.CreateCommand();
            command.CommandText = "SELECT count(*) FROM Astronaut WHERE username = '" + userTXT.Text + "' and password = '" + passTXT.Text + "';";

            myreader = Convert.ToInt32(command.ExecuteScalar());

            if (myreader > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
