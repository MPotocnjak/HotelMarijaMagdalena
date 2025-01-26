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
using System.Windows.Forms.VisualStyles;

namespace HotelMarijaMagdalena
{
    public partial class ReservationControl : UserControl
    {
        public ReservationControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        private void tabControlReservation_VisibleChanged(object sender, EventArgs e)
        {
            if (tabControlReservation.Visible)
            {
                // Insert room numbers into list
                comboBoxRoomNumber.Items.Clear();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT RoomNumber FROM Rooms";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxRoomNumber.Items.Add(reader.GetInt32(0));
                    }
                }

                conn.Close();
            }
        }

        private void tabControlReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabIndex = tabControlReservation.SelectedIndex;

            // Selected tab 'Reservations'
            if (tabIndex == 1)
            {
                // Show Reservations table from database
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Reservations";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewAllReservations.DataSource = dt;
                conn.Close();
            }
            else if (tabIndex == 2)
            {
                // Show Guests table from database
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Guests";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewGuests.DataSource = dt;
                conn.Close();
            }
        }

        private void buttonSaveOrUpdate_Click(object sender, EventArgs e)
        {
            // Data validation check
            if (textBoxName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Reservation name not entered!", "Reservation name error");
                return;
            }

            if (comboBoxRoomNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Room number not selected!", "Reservation room number error");
                return;
            }

            if (comboBoxRoomNumber.SelectedIndex < 0)
            {
                MessageBox.Show($"Room number {comboBoxRoomNumber.Text} doesn't exist!",
                        "Reservation room number error");
                return;
            }

            if (dateTimePickerCheckIn.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Check-in date can't be in past!", "Check-in date error");
                return;
            }

            if (dateTimePickerCheckOut.Value <= dateTimePickerCheckIn.Value)
            {
                MessageBox.Show("Check-out date can't be before or the same as check-in!",
                    "Check-out date error");
                return;
            }

            // Saving data into database
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            Button b = sender as Button;
            string queryInsert = "INSERT INTO Reservations(ReservationId, Name, RoomNumber," +
                                " CheckInDate, CheckOutDate)" +
                                " VALUES (@reservationId, @name, @roomNumber," +
                                " @checkInDate, @checkOutDate)";

            string queryUpdate = "UPDATE Reservations SET RoomNumber = @roomNumber," +
                                " CheckInDate = @checkInDate, CheckOutDate = @checkOutDate" +
                                " WHERE Name = @name";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (b.Text == "Save")
            {
                string queryCount = @"SELECT COUNT(*) FROM Reservations";
                SqlCommand sqlCommand = new SqlCommand(queryCount, conn);
                int count = (int)sqlCommand.ExecuteScalar();

                cmd.CommandText = queryInsert;
                cmd.Parameters.AddWithValue("@ReservationId", count + 1);
            }
            else
            {
                cmd.CommandText = queryUpdate;
            }

            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@roomNumber", comboBoxRoomNumber.Text);
            cmd.Parameters.AddWithValue("@checkInDate", dateTimePickerCheckIn.Value);
            cmd.Parameters.AddWithValue("@checkOutDate", dateTimePickerCheckOut.Value);

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
                MessageBox.Show($"Reservation {textBoxName.Text} does not exist!",
                    "Reservation update error");
                return;
            }

            // Success messages
            if (b.Text == "Save")
            {
                MessageBox.Show("New reservation added successfully!", "Success");
            }
            else
            {
                MessageBox.Show($"Reservation {textBoxName.Text} updated successfully!", "Success");
            }

            conn.Close();
        }

    }
}
