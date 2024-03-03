using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HATCH_2024
{
    public partial class Menu : Form
    {
        public Menu()
        {
            Login login = new Login();
            login.ShowDialog();
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NutritionInfo info = new NutritionInfo();
            info.ShowDialog();
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            AstronautCreation creation = new AstronautCreation();
            creation.ShowDialog();
        }
    }
}
