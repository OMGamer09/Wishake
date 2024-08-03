using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wishake
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        public static string Username, Usertype;
        public static int CurrentCustomerId;
        public static Dictionary<string, Tuple<double, int>> Order = new Dictionary<string, Tuple<double, int>>();
        public static double Price;
        
        public static string GetFirstWord(string input)
        {
            // Split the string by spaces and return the first element, or an empty string if the input is null or empty
            return input?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? string.Empty;
        }
        public static double PriceCalculate(string size,string Base)
        {
            size = GetFirstWord(size);
            Base = GetFirstWord(Base);
            double price = 0;
            switch (size)
            {
                case "Small":
                    price = 23;
                    break;
                case "Medium":
                    price = 26;
                    break;
                case "Large":
                    price = 28;
                    break;
            }
            switch (Base)
            {
                case "Milk":
                    price += 2;
                    break;
                case "Almond":
                    price += 3;
                    break;
            }
            return price;
                
        }
        private void UpdateUI()//tells us if a member or a staff member logged in
        {
            if (Usertype == "Staff")
            {
                lblWelcome.Text = "Welcome to WiShake, " + Username;
                staffStatisticsToolStripMenuItem.Visible = true;
                msLogout_Staff.Visible = true;
                msLogout_Member.Visible = false;
                msStaffLogin.Visible = false;
                msMembers.Visible = false;
                MessageBox.Show("Statistics Unlocked!");
            }
            if (Usertype == "Member")
            {
                lblWelcome.Text = "Welcome to WiShake, " + Username;
                staffStatisticsToolStripMenuItem.Visible = false;
                staffToolStripMenuItem.Visible = false;
                msMembers.Visible = true;
                msMemberLogin.Visible = false;
                msLogout_Member.Visible = true;
                msLogout_Staff.Visible = false;
            }
            if (Usertype == "")
            {
                lblWelcome.Text = "Welcome to WiShake";
                Username = string.Empty;
                staffStatisticsToolStripMenuItem.Visible = false;
                msStaffLogin.Visible = true;
                staffToolStripMenuItem.Visible = true;
                msMemberLogin.Visible = true;
                msMembers.Visible = true;
                msLogout_Staff.Visible = false;
                msLogout_Member.Visible = false;
            }
        }
        private void btnAboutUs_Click(object sender, EventArgs e)//TODO - Make in a dedicated form
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)//Exit Program
        {
            Close();
        }
        private void btnGetStarted_Click(object sender, EventArgs e)//Go to FeelOrder form
        {
            FeelOrder feelOrder = new FeelOrder();
            feelOrder.ShowDialog();
        }
        private void btnQuickOrder_Click(object sender, EventArgs e)//Go to QuickOrder form
        {
           QuickOrder quickorder = new QuickOrder ();
           quickorder.ShowDialog();
        }
        private void msStaffLogin_Click(object sender, EventArgs e)//go to Login screen for staff
        {
            StaffLogin Login = new StaffLogin("Staff Login");
            if (Login.ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
            }
        }
        private void msLogout_Staff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?","Logout",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usertype = "";
                UpdateUI();
            } 
        }
        private void msLogout_Member_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usertype = "";
                UpdateUI();
            }
        }
        private void msMemberLogin_Click(object sender, EventArgs e)//go to Login screen for staff
        {
            StaffLogin Login = new StaffLogin("Member Login");
            if (Login.ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
            }
        }
        private void ingredientsToolStripMenuItem_Click(object sender, EventArgs e)//Go to fruits info form
        {
            Fruits fruits = new Fruits();
            fruits.ShowDialog();
        }
        private void staffStatisticsToolStripMenuItem_Click(object sender, EventArgs e)//Go to staff statistics form
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }
    }
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MyDrive\לימודים PDF\שנה ב\סמסטר ב\תכנות\Wishake\SQL\Orders.mdf;";
        }

        // Retrieve all orders
        public DataTable GetOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);
                return ordersTable;
            }
        }

        // Retrieve order details by OrderID
        public DataTable GetOrderDetails(int orderId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    d.DrinkName, 
                    d.DrinkSize, 
                    d.DrinkBase, 
                    d.Quantity, 
                    d.Price, 
                    (d.Quantity * d.Price) AS SubTotal
                FROM 
                    OrderDetails d
                WHERE 
                    d.OrderID = @OrderID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@OrderID", orderId);
                DataTable orderDetailsTable = new DataTable();
                adapter.Fill(orderDetailsTable);
                return orderDetailsTable;
            }
        }

        // Add a new order and return the OrderID
        public int AddOrder(int? customerId, decimal totalPrice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (CustomerID, TotalPrice) OUTPUT INSERTED.OrderID VALUES (@CustomerID, @TotalPrice)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", (object)customerId ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                connection.Open();
                return (int)command.ExecuteScalar(); // Returns the new OrderID
            }
        }
        public int GetCustomerIdByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID FROM Customers WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", username);

                connection.Open();
                object result = command.ExecuteScalar();
                return (result != DBNull.Value && result != null) ? Convert.ToInt32(result) : -1;
            }
        }
        // Add a detail to an existing order
        public void AddOrderDetail(int orderId, string drinkName, string drinkSize, string drinkBase, int quantity, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO OrderDetails (OrderID, DrinkName, DrinkSize, DrinkBase, Quantity, Price) VALUES (@OrderID, @DrinkName, @DrinkSize, @DrinkBase, @Quantity, @Price)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.Parameters.AddWithValue("@DrinkName", drinkName);
                command.Parameters.AddWithValue("@DrinkSize", drinkSize);
                command.Parameters.AddWithValue("@DrinkBase", drinkBase);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Price", price);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Get the best-selling drink
        public (string drinkName, double percentage) GetBestSellingDrink()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get the best-selling drink
                string bestSellingDrinkQuery = "SELECT TOP 1 DrinkName, SUM(Quantity) AS Total FROM OrderDetails GROUP BY DrinkName ORDER BY Total DESC";
                SqlCommand bestSellingDrinkCommand = new SqlCommand(bestSellingDrinkQuery, connection);
                string drinkName = "N/A";
                int bestSellingCount = 0;

                using (SqlDataReader reader = bestSellingDrinkCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        drinkName = reader["DrinkName"].ToString();
                        bestSellingCount = Convert.ToInt32(reader["Total"]);
                    }
                }

                // Get the total number of drinks ordered
                int totalOrders = GetTotalNumberOfOrders(connection);

                double percentage = (totalOrders > 0) ? (double)bestSellingCount / totalOrders * 100 : 0;
                return (drinkName, percentage);
            }
        }

        // Get the best-selling size
        public (string size, double percentage) GetBestSellingSize()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get the best-selling size
                string bestSellingSizeQuery = "SELECT TOP 1 DrinkSize, SUM(Quantity) AS Total FROM OrderDetails GROUP BY DrinkSize ORDER BY Total DESC";
                SqlCommand bestSellingSizeCommand = new SqlCommand(bestSellingSizeQuery, connection);
                string size = "N/A";
                int bestSellingCount = 0;

                using (SqlDataReader reader = bestSellingSizeCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        size = reader["DrinkSize"].ToString();
                        bestSellingCount = Convert.ToInt32(reader["Total"]);
                    }
                }

                // Get the total number of drinks ordered
                int totalOrders = GetTotalNumberOfOrders(connection);

                double percentage = (totalOrders > 0) ? (double)bestSellingCount / totalOrders * 100 : 0;
                return (size, percentage);
            }
        }

        public decimal GetTotalProfit()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(TotalPrice) FROM Orders";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToDecimal(result);
                }
                return 0m; // Return 0 if the result is null or DBNull
            }
        }

        // Get the total number of drinks ordered
        public int GetTotalNumberOfOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return GetTotalNumberOfOrders(connection);
            }
        }

        public int GetTotalNumberOfOrders(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open(); // Ensure the connection is open
            }

            string query = "SELECT SUM(Quantity) FROM OrderDetails";
            SqlCommand command = new SqlCommand(query, connection);

            object result = command.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }

        // Method to update the quantity of a specific drink in an order
        public void UpdateOrderDetailQuantity(int orderId, string drinkName, string drinkSize, string drinkBase, int newQuantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                UPDATE OrderDetails 
                SET Quantity = @NewQuantity 
                WHERE OrderID = @OrderID 
                AND DrinkName = @DrinkName 
                AND DrinkSize = @DrinkSize 
                AND DrinkBase = @DrinkBase";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.Parameters.AddWithValue("@DrinkName", drinkName);
                command.Parameters.AddWithValue("@DrinkSize", drinkSize);
                command.Parameters.AddWithValue("@DrinkBase", drinkBase);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RemoveOrderDetail(int orderId, string drinkName, string drinkSize, string drinkBase)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM OrderDetails WHERE OrderID = @OrderID AND DrinkName = @DrinkName AND DrinkSize = @DrinkSize AND DrinkBase = @DrinkBase";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.Parameters.AddWithValue("@DrinkName", drinkName);
                command.Parameters.AddWithValue("@DrinkSize", drinkSize);
                command.Parameters.AddWithValue("@DrinkBase", drinkBase);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
