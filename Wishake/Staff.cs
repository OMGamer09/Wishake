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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            DisplayStatistics();
        }
        private void DisplayStatistics()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Get statistics
            var (bestSellingDrink, drinkPercentage) = dbHelper.GetBestSellingDrink();
            var (bestSellingSize, sizePercentage) = dbHelper.GetBestSellingSize();
            decimal totalProfit = dbHelper.GetTotalProfit();
            int totalNumberOfOrders = dbHelper.GetTotalNumberOfOrders();

            // Display statistics
            lblBestDrink.Text = $"{bestSellingDrink} ({drinkPercentage:F2}%)";
            lblBestSize.Text = $"{bestSellingSize} ({sizePercentage:F2}%)";
            lblProfit.Text = totalProfit.ToString()+ "₪";
            lblTotalOrders.Text = totalNumberOfOrders.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
