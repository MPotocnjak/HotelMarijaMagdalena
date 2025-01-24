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
    public partial class GuestControl : UserControl
    {
        public GuestControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Data validation check
            if (textBoxFirstName.Text.Trim().Length == 0)
            {
                MessageBox.Show("First name not entered!", "Guest first name error");
                return;
            }

            if (textBoxLastName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Last name not entered!", "Guest last name error");
                return;
            }

            if (textBoxID.Text.Trim().Length == 0)
            {
                MessageBox.Show("ID number not entered!", "Guest ID number error");
                return;
            }

            if (textBoxID.Text.Length != 11)
            {
                MessageBox.Show("ID number must have exactly 11 numbers!",
                    "Guest ID number error");
                return;
            }

            var date = DateTime.Now.Date;
            if (!DateTime.TryParse(textBoxDateOfBirth.Text, out date))
            {
                MessageBox.Show("Please enter date in format DD/MM/YYYY",
                    "Guest date error");
                return;
            }

            // Saving data into database - table Guests
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string queryCount = @"SELECT COUNT(*) FROM Guests";
            SqlCommand sqlCommand = new SqlCommand(queryCount, conn);
            int count = (int)sqlCommand.ExecuteScalar();

            string queryInsert = "INSERT INTO Guests(GuestId, FirstName, LastName," +
                                " IDNumber, DateOfBirth, Address, Phone)" +
                                " VALUES (@guestId, @firstName, @lastName, @idNumber, " +
                                " @date, @address, @phone)";

            SqlCommand cmd = new SqlCommand(queryInsert, conn);
            cmd.Parameters.AddWithValue("@guestId", count + 1); 
            cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("@idNumber", textBoxID.Text);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
            cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }

            // Allow closing current form
            this.FindForm()?.Close();
        }
    }
}
