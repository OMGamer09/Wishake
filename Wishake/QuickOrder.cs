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
    public partial class QuickOrder : Form
    {
        public QuickOrder()
        {
            InitializeComponent();
            CheckCart();
        }

        // Method to check and update the cart button with current order details
        private void CheckCart()
        {
            if (Form1.Order.Count > 0)
                btnCart.Text = $"To Cart ({Form1.Order.Values.Sum(tuple => tuple.Item2)})";
            else
                btnCart.Text = "To Cart";
        }

        // Method to handle the 'Back' button click event
        private void btnBack_Fruits_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Method to handle the 'Add' button click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string drink = lbDrinks.SelectedItem?.ToString();
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

        private void btnCart_Click(object sender, EventArgs e)
        {
            
            CheckOut checkOut = new CheckOut();
            checkOut.ShowDialog();
        }
    }
}
