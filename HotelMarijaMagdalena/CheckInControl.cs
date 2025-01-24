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
    public partial class CheckInControl : UserControl
    {
        public CheckInControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        private void tabControlCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabIndex = tabControlCheckIn.SelectedIndex;

            // Selected tab 'Status'
            if (tabIndex == 1)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Booking";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewCheckIn.DataSource = dt;
                conn.Close();
            }
        }

        private void tabControlCheckIn_VisibleChanged(object sender, EventArgs e)
        {
            if (tabControlCheckIn.Visible)
            {
                // Insert room numbers into list
                comboBoxRoomNumber.Items.Clear();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT RoomNumber FROM Rooms" +
                               " WHERE Status = 'Available'";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxRoomNumber.Items.Add(reader.GetInt32(0));
                    }
                }

                query = @"SELECT * FROM Booking";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewCheckIn.DataSource = dt;

                conn.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Data validation check
            if (comboBoxRoomNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Room number not selected!", "Reservation room number error");
                return;
            }

            if(comboBoxRoomNumber.SelectedIndex < 0)
            {
                MessageBox.Show($"Room number {comboBoxRoomNumber.Text} doesn't exist!",
                        "Reservation room number error");
                return;
            }

            if (dateTimePickerCheckIn.Value.Date != DateTime.Now.Date)
            {
                MessageBox.Show("Check-in date must be today!", "Check-in date error");
                return;
            }

            if (dateTimePickerCheckOut.Value <= dateTimePickerCheckIn.Value)
            {
                MessageBox.Show("Check-out date can't be before or the same as check-in!",
                    "Check-out date error");
                return;
            }

            // Saving data into database - table Booking
            int roomNumber = int.Parse(comboBoxRoomNumber.Text);
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string queryCount = @"SELECT COUNT(*) FROM Booking";
            SqlCommand sqlCommand = new SqlCommand(queryCount, conn);
            int count = (int)sqlCommand.ExecuteScalar();

            string queryPrice = @"SELECT Price FROM Rooms WHERE RoomNumber = @roomNumber";
            sqlCommand = new SqlCommand(queryPrice, conn);
            sqlCommand.Parameters.AddWithValue("@roomNumber", roomNumber);
            decimal price = (decimal)sqlCommand.ExecuteScalar();

            TimeSpan days = dateTimePickerCheckOut.Value.Date - dateTimePickerCheckIn.Value.Date;

            string queryInsert = "INSERT INTO Booking(BookingId, RoomNumber," +
                                " CheckInDate, CheckOutDate, TotalPrice)" +
                                " VALUES (@bookingId, @roomNumber," +
                                " @checkInDate, @checkOutDate, @totalPrice)";

            SqlCommand cmd = new SqlCommand(queryInsert, conn);
            cmd.Parameters.AddWithValue("@bookingId", count + 1);
            cmd.Parameters.AddWithValue("@roomNumber", comboBoxRoomNumber.Text);
            cmd.Parameters.AddWithValue("@checkInDate", dateTimePickerCheckIn.Value);
            cmd.Parameters.AddWithValue("@checkOutDate", dateTimePickerCheckOut.Value);
            cmd.Parameters.AddWithValue("@totalPrice", price * days.Days);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }

            // Preparing data for database - table BookingGuests
            queryInsert = "INSERT INTO BookingGuests(BookingId, GuestId)" +
                          " VALUES (@bookingId, @guestId)";

            queryCount = @"SELECT COUNT(*) FROM Guests";
            sqlCommand = new SqlCommand(queryCount, conn);
            int guestCount = (int)sqlCommand.ExecuteScalar();

            // Open the GuestForm for each guest.
            int numberOfGuests = (int)numericUpDownGuests.Value;

            for (int i = 1; i <= numberOfGuests; i++)
            {
                GuestForm guestForm = new GuestForm();
                guestForm.Text = $"Guest number {i}";
                guestForm.ShowDialog();

                // Saving data into database - table BookingGuests
                cmd = new SqlCommand(queryInsert, conn);
                cmd.Parameters.AddWithValue("@bookingId", count + 1);
                cmd.Parameters.AddWithValue("@guestId", guestCount + i);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                    return;
                }
            }

            // Change status for this room
            string queryRoom = @"UPDATE Rooms SET Status = 'Occupied'" +
                               " WHERE RoomNumber = @roomNumber";
            cmd = new SqlCommand(queryRoom, conn);
            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
            cmd.ExecuteNonQuery();

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
                MessageBox.Show("Update of Rooms table (status) failed!", "Update error");
                return;
            }
            else
            {
                MessageBox.Show($"Room number {roomNumber} is now occupied.", "Success");
            }

            conn.Close();
        }
    }
}
