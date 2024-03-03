using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HATCH_2024
{
    public partial class Report : Form
    {
        private const string V = "Designing an optimal vegetable-based diet for a female individual living in space, with the provided specifications, requires careful consideration of nutritional needs, energy requirements, space constraints, and the management of diabetes. Here's a sample daily meal plan tailored to meet the requirements:\r\n\rMeal Plan:\r\n\r\nBreakfast:\r\n\r\n1/2 cup cooked oatmeal with 1 tablespoon of ground flaxseeds and sliced strawberries\r\n1 small apple\r\n1 cup unsweetened almond milk\r\nLunch:\r\n\r\nMixed greens salad with cherry tomatoes, cucumbers, bell peppers, and grilled tofu, dressed with olive oil and vinegar\r\n1 whole grain roll\r\n1 small orange\r\nDinner:\r\n\r\nGrilled vegetable skewers (zucchini, bell peppers, mushrooms, cherry tomatoes) served with quinoa pilaf\r\nSteamed broccoli florets with lemon zest\r\n1 small peach\r\nSnacks (in between meals):\r\n\r\n1/4 cup raw almonds\r\nCarrot and celery sticks with hummus dip\r\nSugar-free Greek yogurt with mixed berries\r\nConsiderations:\r\n\r\nNutrient Variety: The meal plan includes a variety of vegetables, whole grains, fruits, and healthy fats to ensure a balanced intake of essential nutrients, including vitamins, minerals, fiber, and antioxidants.\r\n\r\nCarbohydrate Management: Foods with a low glycemic index and high fiber content are emphasized to help manage blood sugar levels in individuals with diabetes. Portions are controlled to avoid spikes in blood glucose.\r\n\r\nProtein Sources: Plant-based protein sources such as tofu, quinoa, almonds, and Greek yogurt are incorporated into each meal to provide satiety and support muscle health.\r\n\r\nSpace Constraints: Foods selected are lightweight, non-perishable, and require minimal preparation in the space environment. Freeze-dried or dehydrated options may be suitable for longer missions.\r\n\r\nMeal Frequency: Three meals per day are provided, along with nutritious snacks, to help regulate blood sugar levels and provide sustained energy for a low activity level.\r\n\r\nWeight Considerations: Foods with low energy density and high nutritional value are prioritized to minimize the weight of the food payload while ensuring adequate nutrient intake.\r\n\r\nPersonal Preferences: The meal plan can be adjusted based on personal preferences, food availability, and dietary restrictions. It's essential to consult with a registered dietitian or nutritionist to tailor the diet to individual needs and ensure proper diabetes management.\r\n\r\nThis sample vegetarian meal plan aims to provide a nutritious and balanced diet tailored to the needs of a female individual living in space with diabetes. However, it's crucial to monitor blood sugar levels regularly, adjust insulin doses as needed, and seek medical advice from healthcare professionals for personalized dietary recommendations and diabetes management strategies.";

        public Report()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\amcge\Downloads\Astronaut.docx";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(textBox1.Text);
            }
            this.Close();
        }

        private void populateBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text = V;
        }
    }
}
