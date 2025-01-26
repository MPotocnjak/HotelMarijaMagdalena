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
    public partial class ServicesControl : UserControl
    {
        public ServicesControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Data validation check
            if (comboBoxRoomNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Room number not selected!", "Reservation room number error");
                return;
            }

            if (comboBoxRoomNumber.SelectedIndex < 0)
            {
                MessageBox.Show($"Room number {comboBoxRoomNumber.Text} not available!",
                        "Reservation room number error");
                return;
            }

            if (listBoxService.SelectedItems.Count != 1)
            {
                MessageBox.Show($"Service type not selected!", "Service type error");
                return;
            }

            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Room price invalid!", "Room price error");
                return;
            }

            // Preparing data for database - table Services
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            var roomNumber = comboBoxRoomNumber.SelectedItem;

            string queryCount = @"SELECT COUNT(*) FROM Services";
            SqlCommand sqlCommand = new SqlCommand(queryCount, conn);
            int count = (int)sqlCommand.ExecuteScalar() + 1;

            string queryBooking = @"SELECT BookingId FROM Booking" +
                                  " WHERE RoomNumber = @roomNumber" +
                                  " AND CheckInDate <= @date AND CheckOutDate >= @date";

            sqlCommand = new SqlCommand(queryBooking, conn);
            sqlCommand.Parameters.AddWithValue("@roomNumber", roomNumber);
            sqlCommand.Parameters.AddWithValue("@date", DateTime.Now.Date);
            var bookingId = sqlCommand.ExecuteScalar();

            string serviceType = listBoxService.SelectedItems[0].ToString();
            decimal price = numericUpDownPrice.Value;

            // Saving data into database - table Services
            string queryInsert = "INSERT INTO Services(ServiceId, BookingId, RoomNumber, Type, Price)" +
                                " VALUES (@serviceId, @bookingId, @roomNumber, @type, @price)";

            SqlCommand cmd = new SqlCommand(queryInsert, conn);
            cmd.Parameters.AddWithValue("@serviceId", count + 1);
            cmd.Parameters.AddWithValue("@bookingId", bookingId);
            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
            cmd.Parameters.AddWithValue("@type", serviceType);
            cmd.Parameters.AddWithValue("@price", price);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }
            MessageBox.Show($"Service {serviceType} for room {roomNumber}" +
                " added successfully!", "Success");

            // Preparing data for database - table Booking
            queryBooking = @"SELECT TotalPrice FROM Booking" +
                           " WHERE BookingId = @bookingId";

            sqlCommand = new SqlCommand(queryBooking, conn);
            sqlCommand.Parameters.AddWithValue("@bookingId", bookingId);
            decimal totalPrice = (decimal)sqlCommand.ExecuteScalar();

            // Saving data into database - table Booking
            string queryUpdate = "UPDATE Booking SET TotalPrice = @newPrice" +
                                " WHERE BookingId = @bookingId";

            cmd = new SqlCommand(queryUpdate, conn);
            cmd.Parameters.AddWithValue("@newPrice", totalPrice + price);
            cmd.Parameters.AddWithValue("@bookingId", bookingId);

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
                MessageBox.Show("Update of Booking table (total price) failed!", "Update error");
                return;
            }
            else
            {
                MessageBox.Show($"New total price is {totalPrice + price}");
            }

            conn.Close();
        }

        private void tabControlServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabIndex = tabControlServices.SelectedIndex;

            // Selected tab 'Services'
            if (tabIndex == 1)
            {
                // Show Services table from database
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT * FROM Services";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewServices.DataSource = dt;
                conn.Close();
            }
        }

        private void tabControlServices_VisibleChanged(object sender, EventArgs e)
        {
            // Insert room numbers into list
            comboBoxRoomNumber.Items.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"SELECT RoomNumber FROM Rooms" +
                           " WHERE Status = 'Occupied'";

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
}
