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
    public partial class PreviewControl : UserControl
    {
        public PreviewControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        string invoiceNumber;
        int bookingId;
        decimal totalPrice;

        private void PreviewControl_Load(object sender, EventArgs e)
        {
            // Prepairing data to show
            invoiceNumber = "00";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Header
            string queryCount = @"SELECT COUNT(*) FROM Payments";
            SqlCommand sqlCommand = new SqlCommand(queryCount, conn);
            int count = (int)sqlCommand.ExecuteScalar() + 1;
            invoiceNumber += count.ToString();

            string queryBooking = @"SELECT BookingId FROM Booking" +
                                  " WHERE RoomNumber = @roomNumber" +
                                  " AND CheckInDate <= @date AND CheckOutDate >= @date";
            
            sqlCommand = new SqlCommand(queryBooking, conn);
            var form = this.FindForm() as PreviewForm;
            sqlCommand.Parameters.AddWithValue("@roomNumber", form.roomNumber);
            sqlCommand.Parameters.AddWithValue("@date", DateTime.Now.Date);
            bookingId = int.Parse(sqlCommand.ExecuteScalar().ToString());

            string queryGuest = @"SELECT GuestId FROM BookingGuests WHERE BookingId = @bookingId";
            sqlCommand = new SqlCommand(queryGuest, conn);
            sqlCommand.Parameters.AddWithValue("@bookingId", bookingId);
            var guestId = sqlCommand.ExecuteScalar();

            string queryName = @"SELECT LastName FROM Guests WHERE GuestId = @guestId";
            sqlCommand = new SqlCommand(queryName, conn);
            sqlCommand.Parameters.AddWithValue("@guestId", guestId);
            var client = sqlCommand.ExecuteScalar();

            string queryAddress = @"SELECT Address FROM Guests WHERE GuestId = @guestId";
            sqlCommand = new SqlCommand(queryAddress, conn);
            sqlCommand.Parameters.AddWithValue("@guestId", guestId);
            var address = sqlCommand.ExecuteScalar();

            // List of services
            string queryService = @"SELECT Type, Price FROM Services" +
                                  " WHERE BookingId = @bookingId";

            sqlCommand = new SqlCommand(queryService, conn);
            sqlCommand.Parameters.AddWithValue("@bookingId", bookingId);

            List<string> types = new List<string>();
            List<decimal> prices = new List<decimal>();

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    types.Add(reader.GetString(0));
                    prices.Add(reader.GetDecimal(1));
                }
            }

            // // Room price per night
            //string queryRoom = @"SELECT Price FROM Rooms" +
            //                   " WHERE RoomNumber = @roomNumber";

            //sqlCommand = new SqlCommand(queryRoom, conn);
            //sqlCommand.Parameters.AddWithValue("@roomNumber", form.roomNumber);
            //decimal roomPrice = (decimal)sqlCommand.ExecuteScalar();

            // Total price
            string query = @"SELECT TotalPrice FROM Booking" +
                           " WHERE BookingId = @bookingId";
            sqlCommand = new SqlCommand(query, conn);
            sqlCommand.Parameters.AddWithValue("@bookingId", bookingId);
            totalPrice = (decimal)sqlCommand.ExecuteScalar();

            conn.Close();

            // Fill invoice with data
            labelNumberOfInvoice.Text = invoiceNumber;
            labelTime.Text = DateTime.Now.ToString();
            labelClientName.Text = client.ToString();
            labelClientAddress.Text = address.ToString();
            labelRoomNumber.Text = form.roomNumber;

            decimal accomodationPrice = totalPrice;
            for (int i = 0; i < types.Count; i++)
            {
                richTextBoxTypes.Text += types[i] + "\n";
                richTextBoxPrices.Text += " € " + prices[i].ToString() + "\n";
                accomodationPrice -= prices[i];
            }
            richTextBoxTypes.Text += "Accomodation\n";
            richTextBoxPrices.Text += " € " + accomodationPrice.ToString() + "\n";

            TotalPrice.Text = totalPrice.ToString();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            // Data validation check
            if (comboBoxPayment.SelectedIndex < 0)
            {
                MessageBox.Show("Please select payment method.", "Payment method error");
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string queryDate = "SELECT CheckOutDate FROM Booking " +
                               "WHERE BookingId = @bookingId";
            SqlCommand sqlCommand = new SqlCommand(queryDate, conn);
            sqlCommand.Parameters.AddWithValue("@bookingId", bookingId);
            DateTime date = (DateTime)sqlCommand.ExecuteScalar();

            if (date != DateTime.Now.Date)
            {
                MessageBox.Show($"Payment cannot be made because " +
                    $"check out date {date.Date} is not today!", "Payment error");
                return;
            }

            // Saving data into database
            string queryInsert = "INSERT INTO Payments(PaymentId, BookingId, Amount, " +
                                 "PaymentDate, PaymentMethod)" +
                                " VALUES (@paymentId, @bookingId, @amount, " +
                                " @paymentDate, @paymentMethod)";
            
            SqlCommand cmd = new SqlCommand(queryInsert, conn);
            cmd.Parameters.AddWithValue("@paymentId", invoiceNumber);
            cmd.Parameters.AddWithValue("@bookingId", bookingId);
            cmd.Parameters.AddWithValue("@amount", totalPrice);
            cmd.Parameters.AddWithValue("@paymentDate", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@paymentMethod", comboBoxPayment.Text);
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }
            MessageBox.Show("Payment successful", "Success");

            // Update room availability
            var form = this.FindForm() as PreviewForm;

            string queryUpdate = @"UPDATE Rooms SET Status = 'Available'" +
                               " WHERE RoomNumber = @roomNumber";
            
            cmd = new SqlCommand(queryUpdate, conn);
            cmd.Parameters.AddWithValue("@roomNumber", form.roomNumber);
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
                MessageBox.Show($"Room number {form.roomNumber} is now available.", "Success");
            }

            conn.Close();

            // Close current form
            form.Close();
        }
    }
}
