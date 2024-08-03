using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wishake
{

    public partial class StaffLogin : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Google Drive\לימודים PDF\שנה ב\סמסטר ב\תכנות\Wishake\SQL\Orders.mdf;";

        public StaffLogin()
        {
            InitializeComponent();
        }

        public StaffLogin(string name)
        {
            InitializeComponent();
            lblTitle_Login.Text = name;
            LoadUsernamesFromDatabase();
        }

        public static Dictionary<string, int> Staff;
        public static Dictionary<string, int> Members;

        public void LoadUsernamesFromDatabase()
        {
            // Initialize the Staff dictionary
            Staff = new Dictionary<string, int>()
            {
                {"Omer", 209029222},
                {"Ofir", 319065801},
                {"Michael", 318730421},
                {"Chen", 209342351}
            };

            // Load members from the database
            Members = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Phone FROM Customers";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        int phone = Convert.ToInt32(reader["Phone"]);

                        Members[name] = phone; // Add to the Members dictionary
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Please enter a valid Username and Password", "Error");
            }
            else
            {
                if (lblTitle_Login.Text == "Staff Login") // Staff log in validation
                {
                    if (Staff.TryGetValue(tbUsername.Text, out int StaffPassword))
                    {
                        if (int.TryParse(tbPassword.Text, out int tryPassword))
                        {
                            if (StaffPassword == tryPassword)
                            {
                                MessageBox.Show("Login Successful");
                                Form1.Username = tbUsername.Text;
                                Form1.Usertype = "Staff";
                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be a valid number", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error");
                    }
                }

                if (lblTitle_Login.Text == "Member Login") // Member log in validation
                {
                    if (Members.TryGetValue(tbUsername.Text, out int MemberPassword))
                    {
                        if (int.TryParse(tbPassword.Text, out int tryPassword))
                        {
                            if (MemberPassword == tryPassword)
                            {
                                MessageBox.Show("Login Successful");
                                Form1.Username = tbUsername.Text;
                                Form1.Usertype = "Member";

                                DatabaseHelper dbHelper = new DatabaseHelper();

                                // Retrieve the customer ID
                                int customerId = dbHelper.GetCustomerIdByUsername(tbUsername.Text);

                                if (customerId > 0)
                                {
                                    Form1.CurrentCustomerId = customerId;
                                }
                                else
                                {
                                    MessageBox.Show("Customer not found in database.", "Error");
                                    return; // Exit if customer ID is not found
                                }

                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be a valid number", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error");
                    }
                }
            }
        }
    }
}

