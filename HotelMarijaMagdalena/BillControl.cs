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
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        private void BillControl_Load(object sender, EventArgs e)
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
        
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            // Data validation check
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

            // Opening previewForm
            PreviewForm previewForm = new PreviewForm(comboBoxRoomNumber.Text);
            previewForm.Show();
        }
    }
}
