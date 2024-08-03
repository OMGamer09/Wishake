using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Wishake
{
    public partial class FeelOrder : Form
    {
        public FeelOrder()
        {
            InitializeComponent();
            InitializeFruits();
            CheckCart();
            cblPhysical.ItemCheck += Controls_Changed;
            cblMental.ItemCheck += Controls_Changed;
            AttachRadioButtonEventHandlers(gbDrinkSize);
        }
        private void Controls_Changed(object sender, EventArgs e)
        {
            // Delay the update for CheckedListBox to ensure the checked state is updated
            if (sender is CheckedListBox)
            {
                this.BeginInvoke(new Action(UpdateRecommendations));
            }
            else
            {
                UpdateRecommendations();
            }
        }
        public static Dictionary<string, int[]> Fruits;
        private List<string> Benefits;
        Form1 Main = new Form1(); //Reference to form1
        private List<string> Name1, Name2;
        public void InitializeFruits()
        {
            Fruits = new Dictionary<string, int[]>()
            {
                /////The Indexes of each condition
                ////Physical Conditions:
                //0.Energy Boost
                //1.Muscle Recovery
                //2.Immune Support
                //3.Digestive Health
                //4.Weight Management

                //Mental Conditions:
                //5.Stress Relief
                //6.Focus Enhancement
                //7.Mood Elevation
                //8.Sleep Improvement
                //9.Memory Boost
                        { "Blueberries", new int[] { 0, 0, 8, 0, 0, 0, 7, 0, 0, 9 } },
                        { "Bananas", new int[] { 0, 8, 0, 0, 0, 0, 0, 7, 6, 0 } },
                        { "Strawberries", new int[] { 0, 0, 7, 0, 6, 5, 0, 0, 0, 0 } },
                        { "Kiwi", new int[] { 0, 0, 8, 9, 0, 0, 0, 0, 7, 0 } },
                        { "Mango", new int[] { 8, 0, 0, 0, 0, 0, 0, 7, 6, 0 } },
                        { "Pineapple", new int[] { 0, 0, 0, 8, 6, 5, 0, 0, 0, 0 } },
                        { "Avocado", new int[] { 0, 0, 0, 0, 7, 6, 0, 0, 0, 5 } },
                        { "Cherries", new int[] { 0, 7, 0, 0, 0, 6, 0, 0, 9, 0 } },
                        { "Grapefruit", new int[] { 7, 0, 0, 0, 8, 0, 5, 0, 0, 0 } },
                        { "Apples", new int[] { 6, 0, 0, 7, 0, 0, 0, 0, 0, 5 } }
            };
            Benefits = new List<string> //Each condition written for comparrison with the checkboxes
            {
                "Energy Boost", "Muscle Recovery", "Immune Support", "Digestive Health", "Weight Management",
                "Stress Relief", "Focus Enhancement", "Mood Elevation", "Sleep Improvement", "Memory Boost"
            };
        }
        private void CheckCart()
        {
            if (Form1.Order.Count > 0)
                btnCart_OrderFeel.Text = $"to Cart ({Form1.Order.Values.Sum(tuple => tuple.Item2)})";
        }
        public List<string> RecommendIngredients(CheckedListBox physicalListBox, CheckedListBox mentalListBox)
        {
            // Create a list of all selected benefits from both physical and mental conditions
            var selectedBenefits = physicalListBox.CheckedItems.Cast<string>()
                .Concat(mentalListBox.CheckedItems.Cast<string>())
                .ToList();

            //defining a dictionary for matching the fruits to selected conditions
            var fruitScores = new Dictionary<string, int>();

            foreach (var fruit in Fruits)
            {
                int score = 0;
                for (int i = 0; i < Benefits.Count; i++)
                {
                    // checking if the current benefit is one of the selected benefits
                    if (selectedBenefits.Contains(Benefits[i]))
                    {
                        // If it is, add the score for this benefit to the fruit's total score
                        score += fruit.Value[i];
                    }
                }
                // If the fruit has a positive score (it helps with at least one selected benefit)
                if (score > 0)
                {
                    // Add this fruit and its score to the fruitScores dictionary
                    fruitScores[fruit.Key] = score;
                }
            }
            // Sort fruits by score in a descending order
            var sortedFruits = fruitScores.OrderByDescending(x => x.Value).ToList();

            // Select top 3/4/5 fruits
            int size;
            if (rbSmall.Checked)
                size = 3;
            else if (rbMedium.Checked)
                size = 4;
            else if (rbLarge.Checked)
                size = 5;
            else
                size = 3;
            var recommendedFruits = sortedFruits.Take(size).Select(x => x.Key).ToList();

            if (recommendedFruits.Count < size)//If we don't have enough fruits, add random ones
            {
                //makes a list of the fruits not picked in the algorythm
                var remainingFruits = Fruits.Keys.Except(recommendedFruits).ToList();
                var random = new Random();
                while (recommendedFruits.Count < size)
                {
                    //a random index from the not picked fruits
                    int index = random.Next(remainingFruits.Count);
                    //add that fruit to the picked list, untill size is full
                    recommendedFruits.Add(remainingFruits[index]);
                    //remove that fruit from the not picked so no duplicates
                    remainingFruits.RemoveAt(index);
                }


            }
            //returns a list of the fruits chosen for the drink
            return recommendedFruits;
        }
        private void UpdateRecommendations()
        {
            var recommendedFruits = RecommendIngredients(cblPhysical, cblMental);
            lbFruits.Items.Clear();
            lbFruits.Items.AddRange(recommendedFruits.ToArray());
        }
        private void AttachRadioButtonEventHandlers(params System.Windows.Forms.GroupBox[] groupBoxes)
        {
            foreach (var groupBox in groupBoxes)
            {
                foreach (Control control in groupBox.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton)
                    {
                        radioButton.CheckedChanged += Controls_Changed;
                    }
                }
            }
        }
        private string Drinkgenerator()
        {
            Name1 = new List<string>()
            {
                "Re","Pro ","Cool ","Freeze ","Mix ", "Super "
            };
            Name2 = new List<string>()
            {
                "Watermelon","Melon","Lemon","Dragon","Acai","Ocean","Green","Shape"
            };
            Random rnd = new Random();
            string name = Name1[rnd.Next(Name1.Count)].ToString() + Name2[rnd.Next(Name2.Count)];
            return name;
        }
        private void UpdateTotalPrice()
        {
            double totalPrice = Form1.Order.Values.Sum(entry => entry.Item1);
            Form1.Price += totalPrice;
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string drink = Drinkgenerator();
            string size = Form1.GetFirstWord(gbDrinkSize.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text);
            string baseType = gbBase.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;

            if (drink != null && size != null && baseType != null)
            {
                string description = $"{drink} - {size} - {baseType}";
                double price = Form1.PriceCalculate(size, baseType);

                // Add or update the price in the dictionary with quantity
                if (Form1.Order.ContainsKey(description))
                {
                    var existingEntry = Form1.Order[description];
                    Form1.Order[description] = new Tuple<double, int>(existingEntry.Item1 + price, existingEntry.Item2 + 1);
                }
                else
                {
                    Form1.Order[description] = new Tuple<double, int>(price, 1);
                }
                CheckCart();

                MessageBox.Show(string.Join(Environment.NewLine, Form1.Order.Select(entry => $"{entry.Key}: {entry.Value.Item1}₪ (Quantity: {entry.Value.Item2})")));
            }
            else
            {
                MessageBox.Show("Please select a drink, size, and base.");
            }
        }

        private void btnBack_OrderFeel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCart_OrderFeel_Click(object sender, EventArgs e)
        {
            //test to see if the fruits are chosen correctly
            //var recommendedFruits = RecommendIngredients(cblMental, cblPhysical);
            //MessageBox.Show(string.Join(Environment.NewLine, recommendedFruits), "Recommended Fruits");
            //double price = Main.PriceCalculate(gbDrinkSize.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text
            //              ,gbBase.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text);
            CheckOut checkOut = new CheckOut();
            checkOut.ShowDialog();
        }

        private void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRecommendations();   
        }

        private void btnFruitsInfo_Click(object sender, EventArgs e)
        {
            Fruits fruits = new Fruits();
            fruits.ShowDialog();
        }
    }
}
