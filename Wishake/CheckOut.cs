using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wishake
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            update();
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            double totalPrice = Form1.Order.Values.Sum(entry => entry.Item1);
            Form1.Price = totalPrice;
            if (Form1.Usertype == "Member")/////add logic for the user to be a member
            {
                totalPrice = totalPrice * 0.9;
                lblTotalPrice.Text = $"Total Price: {totalPrice}₪";
            }
            else
            {
                lblTotalPrice.Text = $"Total Price: {totalPrice}₪";
            }
                
        }
        private void update()
        {
            lbOrderList.Items.Clear();
            foreach (var entry in Form1.Order)
            {
                lbOrderList.Items.Add($"{entry.Key}: {entry.Value.Item1}₪ , {entry.Value.Item2}");
            }
        }
        private void ConfirmPayment()
        {
            var result = MessageBox.Show("Do you want to confirm the payment?", "Payment Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int? customerId = Form1.CurrentCustomerId > 0 ? Form1.CurrentCustomerId : (int?)null;

                DatabaseHelper dbHelper = new DatabaseHelper();
                decimal totalPrice = Form1.Order.Sum(entry => (decimal)entry.Value.Item1);
                

                    // Add a new order to the database with the customer ID or as a guest order
                    int orderId = dbHelper.AddOrder(customerId, totalPrice);

                // Iterate through each order item and add it to the database
                foreach (var entry in Form1.Order)
                {
                    string[] details = entry.Key.Split(new string[] { " - " }, StringSplitOptions.None);
                    if (details.Length == 3)
                    {
                        string drinkName = details[0];
                        string drinkSize = details[1];
                        string drinkBase = details[2];
                        int quantity = entry.Value.Item2;
                        decimal price = (decimal)(entry.Value.Item1 / quantity);
                        if (Form1.Usertype == "Member")/////add logic for the user to be a member
                            price = price - price / 10;

                        dbHelper.AddOrderDetail(orderId, drinkName, drinkSize, drinkBase, quantity, price);
                    }
                }

                // Clear in-memory order data
                Form1.Order.Clear();
                update();
                MessageBox.Show("Order confirmed and saved to the database.");

                // Close all forms except Form1
                foreach (Form form in Application.OpenForms)
                {
                    if (!(form is Form1))
                    {
                        form.Close();
                    }
                }
            }
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            ConfirmPayment();
        }
        public string GetFirstWord(string input)
        {
            // Split the string by spaces and return the first element, or an empty string if the input is null or empty
            return input?.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? string.Empty;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbOrderList.SelectedItem != null)
            {
                string selectedOrder1 = GetFirstWord(lbOrderList.SelectedItem.ToString());
                if (Form1.Order.ContainsKey(selectedOrder1))
                {
                    var existingEntry = Form1.Order[selectedOrder1];
                    double pricePerOrder = existingEntry.Item1 / existingEntry.Item2;

                    // Update the dictionary entry
                    if (existingEntry.Item2 > 1)
                    {
                        Form1.Order[selectedOrder1] = new Tuple<double, int>(existingEntry.Item1 - pricePerOrder, existingEntry.Item2 - 1);
                    }
                    else
                    {
                        Form1.Order.Remove(selectedOrder1);
                    }

                    // Parse the drink details from the selected order description
                    string[] details = selectedOrder1.Split(new string[] { " - " }, StringSplitOptions.None);
                    if (details.Length == 3)
                    {
                        string drinkName = details[0];
                        string drinkSize = details[1];
                        string drinkBase = details[2];

                        // Update the database
                        DatabaseHelper dbHelper = new DatabaseHelper();

                        // Assume you have the current OrderID available
                        int orderId = Form1.CurrentCustomerId; // Implement this method to retrieve the current OrderID

                        // Determine the new quantity
                        int newCount = existingEntry.Item2 - 1;

                        if (newCount > 0)
                        {
                            // Update the order detail quantity
                            dbHelper.UpdateOrderDetailQuantity(orderId, drinkName, drinkSize, drinkBase, newCount);
                        }
                        else
                        {
                            // Remove the order detail if the new count is zero
                            dbHelper.RemoveOrderDetail(orderId, drinkName, drinkSize, drinkBase);
                        }

                        MessageBox.Show($"Order '{selectedOrder1}' updated successfully.");

                        // Update the ListBox after removal
                        update();
                        UpdateTotalPrice();
                    }
                }
            }
        }

        private void btnBack_Fruits_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
