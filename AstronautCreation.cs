using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace HATCH_2024
{

    public partial class AstronautCreation : Form
    {
        string API_KEY = "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";
        string API_URL = "https://api.openai.com/v1/completions";
        public string myreader2;
        Login login = new Login();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public AstronautCreation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void submitBTN_Click(object sender, EventArgs e)
        {
            int height = int.Parse(heightTXT.Text);
            int weight = int.Parse(weightTXT.Text);
            int bmi = weight / (height * height) * 703;
            String text1 = this.nameTXT.Text;
            String text2 = this.genderTXT.Text;
            int text3 = height;
            int text4 = weight;
            int text5 = bmi;
            String text6 = this.activityTXT.Text;
            int text7 = int.Parse(this.frequencyTXT.Text);
            String text8 = this.healthTXT.Text;

            SQLiteCommand command;
            SQLiteConnection connect = Program.connect();
            command = connect.CreateCommand();
            command.CommandText = "INSERT INTO Astronaut(Name, Gender, Height, Weight, BMI, Activity, Frequency, Conditions) VALUES ('" + text1 + "', '" + text2 + "', '" + text3 + "', '" + text4 + "', '" + text5 + "', '" + text6 + "', '" + text7 + "','" + text8 + "');";
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Astronaut created successfully. ");
            string question = "Give me a report for the optimal vegitable diet for a person that is'" + text2 + ", is about '" + height.ToString() + "'inches in height, weighs '" + weight.ToString() + "' pounds, a bmi of '" + bmi.ToString() + "', with a '" + text6 + "' activity level, they eat '" + text7.ToString() + "' meals a day, and have '" + text8 + "' health condition(s). This diet needs to take into account the person living in space, and the weight of the food that will be taken. ";
            string prompt = question;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.openai.com");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY");
                var response = await client.GetAsync("/v1/chat");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    //report.textbox1.Text = responseBody;
                }
                else
                {
                    Console.WriteLine("Failed to make request. Status code: " + response.StatusCode);
                }
                Report report = new Report();
                report.ShowDialog();
                this.Close();
             }
            }
        }
    }
