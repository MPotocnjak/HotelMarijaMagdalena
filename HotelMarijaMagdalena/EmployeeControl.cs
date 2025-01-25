using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMarijaMagdalena
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;
        private void tabControlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabIndex = tabControlEmployee.SelectedIndex;

            // Selected tab 'Employees'
            if (tabIndex == 0)
            {
                // Show Employees table from database
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewEmployees.DataSource = dt;
                conn.Close();
            }
        }

        private void tabControlEmployee_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // Show Rooms table from database
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewEmployees.DataSource = dt;
                conn.Close();
            }
        }

        private void buttonSaveOrUpdate_Click(object sender, EventArgs e)
        {
            // Data validation check
            if (textBoxFirstName.Text.Trim().Length == 0)
            {
                MessageBox.Show("First name required!", "Employee first name error");
                return;
            }
            
            if (textBoxLastName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Last name required!", "Employee last name error");
                return;
            }

            if (comboBoxShift.SelectedIndex < 0)
            {
                MessageBox.Show("Shift not selected!", "Employee shift error");
                return;
            }

            if (comboBoxStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Status not selected!", "Employee status error");
                return;
            }

            // Saving data into database
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            Button b = sender as Button;
            string queryInsert = "INSERT INTO Employees(EmployeeId," +
                                " FirstName, LastName, Position, Shift, Status, Phone)" +
                                " VALUES (@employeeId, @firstName, @lastName, @position," +
                                " @shift, @status, @phone)";

            string queryUpdate = "UPDATE Employees SET Position = @position, Shift = @shift," +
                                " Status = @status, Phone = @phone" +
                                " WHERE FirstName = @firstName AND LastName = @lastName";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (b.Text == "Save")
            {
                string queryCount = @"SELECT COUNT(*) FROM Employees";
                SqlCommand sqlCommand = new SqlCommand(queryCount, conn);
                int count = (int)sqlCommand.ExecuteScalar();

                cmd.CommandText = queryInsert;
                cmd.Parameters.AddWithValue("@EmployeeId", count+1);
            }
            else
            {
                cmd.CommandText = queryUpdate;
            }

            cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@position", textBoxPosition.Text);
            cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
            cmd.Parameters.AddWithValue("@shift", comboBoxShift.Text);
            cmd.Parameters.AddWithValue("@status", comboBoxStatus.Text);

            int n = 0;  // Number of rows affected
            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }

            // Update didn't affect database
            if (n == 0)
            {
                MessageBox.Show($"Employee {textBoxFirstName.Text} {textBoxLastName.Text}" +
                    $" does not exist!", "Employee update error");
                return;
            }

            // Success messages
            if (b.Text == "Save")
            {
                MessageBox.Show("New employee added successfully!", "Success");
            }
            else
            {
                MessageBox.Show($"Employee {textBoxFirstName.Text} {textBoxLastName.Text}" +
                    $" updated successfully!", "Success");
            }

            conn.Close();
        }

    }
}
