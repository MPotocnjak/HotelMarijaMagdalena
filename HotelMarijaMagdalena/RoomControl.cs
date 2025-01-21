using System;
using System.Collections;
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
using System.Windows.Forms.VisualStyles;

namespace HotelMarijaMagdalena
{
    public partial class RoomControl : UserControl
    {
        public RoomControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        private void tabControlRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabIndex = tabControlRooms.SelectedIndex;

            // Selected tab 'Rooms'
            if (tabIndex == 0)
            {
                // Show Rooms table from database
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Rooms";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewRooms.DataSource = dt;
                conn.Close();
            }
        }

        private void dataGridViewRooms_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // Show Rooms table from database
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Rooms";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewRooms.DataSource = dt;
                conn.Close();
            }
        }

        private void buttonSaveOrUpdate_Click(object sender, EventArgs e)
        {
            // Data validation check
            int roomNumber = 0;
            if (!int.TryParse(textBoxRoomNumber.Text, out roomNumber))
            {
                MessageBox.Show("Room number invalid!", "Room number error");
                return;
            }

            if (comboBoxType.SelectedIndex < 0)
            {
                MessageBox.Show("Room type not selected!", "Room type error");
                return;
            }

            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Room price invalid!", "Room price error");
                return;
            }

            // Saving data into database
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            Button b = sender as Button;
            string queryInsert = "INSERT INTO Rooms(RoomNumber, Price, Type, Status)" +
                                " VALUES (@roomNumber, @price, @type, @status)";

            string queryUpdate = "UPDATE Rooms SET Price = @price, Type = @type" +
                                " WHERE RoomNumber = @roomNumber";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (b.Text == "Save")
            {
                cmd.CommandText = queryInsert;
            }
            else
            {
                cmd.CommandText = queryUpdate;
            }

            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
            cmd.Parameters.AddWithValue("@price", numericUpDownPrice.Value);
            cmd.Parameters.AddWithValue("@type", comboBoxType.Text);
            cmd.Parameters.AddWithValue("@status", "Available");

            int n = 0;  // Number of rows affected
            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Failed to add new room! \n" +
                        $"Room number {roomNumber} already exists!", "Add room error");
                    return;
                }
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }

            // Update didn't affect database
            if(n == 0)
            {
                MessageBox.Show($"Room number {roomNumber} does not exist!", "Room number error");
                return;
            }

            // Success messages
            if (b.Text == "Save")
            {
                MessageBox.Show("New room added successfully!", "Success");
            }
            else
            {
                MessageBox.Show($"Room number {roomNumber} updated successfully!", "Success");
            }

            conn.Close();
        }
    }
}
