using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wishake
{
    public partial class Fruits : Form
    {
        public Fruits()
        {
            InitializeComponent();
        }

        private void btnBack_Fruits_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbFruits_SelectedIndexChanged(object sender, EventArgs e)//Display fruits inforamtion
        {
            switch (lbFruits.SelectedIndex)
            {
                case 0:
                    pb_Fruit.Image = Properties.Resources.Blueberries;
                    lblFruitName.Text = "Fruit Name: Blueberries";
                    lblBenefits.Text = "Immune Support\nMemory Boost\nFocus Enhancement";
                    lblDesc.Text = "lueberries are small, round berries with a dark blue-purple color. They are sweet and tangy.";
                    lblNutrit.Text = "Blueberries are rich in antioxidants, vitamins (such as vitamin C), and dietary fiber. They are low in calories and fat.";
                    break;
                case 1:
                    pb_Fruit.Image = Properties.Resources.Banana;
                    lblFruitName.Text = "Fruit Name: Bananas";
                    lblBenefits.Text = "Muscle Recovery\nMood Elevation\nSleep Improvement";
                    lblDesc.Text = "Bananas are elongated, yellow fruits with a soft texture and a sweet taste.";
                    lblNutrit.Text = "Bananas are a great source of potassium, vitamin B6, and dietary fiber. They are also easy to digest and provide quick energy";
                    break;
                case 2:
                    pb_Fruit.Image = Properties.Resources.Strawberries;
                    lblFruitName.Text = "Fruit Name: Strawberries";
                    lblBenefits.Text = "Immune Support\nWeight Management\nStress Relief";
                    lblDesc.Text = "Strawberries are heart-shaped red berries with a sweet flavor.";
                    lblNutrit.Text = " Strawberries are packed with vitamin C, antioxidants, and dietary fiber. They are low in calories and fat";
                    break;
                case 3:
                    pb_Fruit.Image = Properties.Resources.Kiwi;
                    lblFruitName.Text = "Fruit Name: Kiwi";
                    lblBenefits.Text = "Digestive Health\nImmune Support\nSleep Improvement\n";
                    lblDesc.Text = "Kiwi (also known as kiwifruit) is a small, green fruit with a fuzzy brown skin and bright green flesh.";
                    lblNutrit.Text = "Kiwi is an excellent source of vitamin C, vitamin K, and dietary fiber. It also contains antioxidants and potassium";
                    break;
                case 4:
                    pb_Fruit.Image = Properties.Resources.Mango;
                    lblFruitName.Text = "Fruit Name: Mango";
                    lblBenefits.Text = "Energy Boost\nMood Elevation\nFocus Enhancement";
                    lblDesc.Text = "Mangoes are tropical fruits with a sweet, juicy flesh and a yellow-orange color.";
                    lblNutrit.Text = "Mangoes are rich in vitamin A, vitamin C, and beta-carotene. They are also a good source of natural sugars";
                    break;
                case 5:
                    pb_Fruit.Image = Properties.Resources.Pineapple;
                    lblFruitName.Text = "Fruit Name: Pineapples";
                    lblBenefits.Text = "Digestive Health\nWeight Management\nStress Relief";
                    lblDesc.Text = "Description: Pineapple is a spiky, tropical fruit with a sweet and tangy flavor.";
                    lblNutrit.Text = "Pineapple contains vitamin C, manganese, and bromelain (an enzyme with potential health benefits). It is also low in fat";

                    break;
                case 6:
                    pb_Fruit.Image = Properties.Resources.Avocado;
                    lblFruitName.Text = "Fruit Name: Avocados";
                    lblBenefits.Text = "Weight Management\nStress Relief\nMemory Boost";
                    lblDesc.Text = "Avocado is a creamy, green fruit with a buttery texture.";
                    lblNutrit.Text = "Avocado is high in healthy fats (monounsaturated fats), potassium, and fiber. It also provides vitamins E, K, and B6";
                    break;
                case 7:
                    pb_Fruit.Image = Properties.Resources.Cherries;
                    lblFruitName.Text = "Fruit Name: Cherries";
                    lblBenefits.Text = "Muscle Recovery\nSleep Improvement\nStress Relief";
                    lblDesc.Text = "Cherries are small, round fruits with a red or dark purple color.";
                    lblNutrit.Text = "Cherries are rich in antioxidants, vitamin C, and potassium. They may also have anti-inflammatory properties";
                    break;
                case 8:
                    pb_Fruit.Image = Properties.Resources.Grapefruit;
                    lblFruitName.Text = "Fruit Name: Grapefruits";
                    lblBenefits.Text = "Weight Management\nEnergy Boost\nFocus Enhancement";
                    lblDesc.Text = "Grapefruit is a citrus fruit with a tangy and slightly bitter taste.";
                    lblNutrit.Text = "Grapefruit is a good source of vitamin C, fiber, and antioxidants. It may also aid in weight management";
                    break;
                case 9:
                    pb_Fruit.Image = Properties.Resources.Apples;
                    lblFruitName.Text = "Fruit Name: Apples";
                    lblBenefits.Text = "Digestive Health\nEnergy Boost\nMemory Boost";
                    lblDesc.Text = "Apples are crisp, round fruits with various colors (such as red, green, or yellow).";
                    lblNutrit.Text = "Apples provide dietary fiber, vitamin C, and antioxidants. They are a healthy snack option";
                    break;

            }
        }
    }
}
