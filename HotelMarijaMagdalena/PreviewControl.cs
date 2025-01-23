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

        private void PreviewControl_Load(object sender, EventArgs e)
        {
            // Prepairing data to show
            string invoiceNumber = "00";

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
            sqlCommand.Parameters.AddWithValue("@date", DateTime.Now);
            var bookingId = sqlCommand.ExecuteScalar();

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


            conn.Close();

            // Fill invoice with data
            labelNumberOfInvoice.Text = invoiceNumber;
            labelTime.Text = DateTime.Now.ToString();
            labelClientName.Text = client.ToString();
            labelClientAddress.Text = address.ToString();
            labelRoomNumber.Text = form.roomNumber;

        }
    }
}
