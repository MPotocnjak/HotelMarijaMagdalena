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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["BazaHotel"].ConnectionString;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string requiredPassword = "";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"SELECT Password FROM Users" + 
                           " WHERE Username = @username";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            try
            {
                requiredPassword = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR");
                return;
            }

            if (requiredPassword is null)
            {
                MessageBox.Show("Username not found!", "Username error");
                return;
            }

            conn.Close();

            if (password != requiredPassword)
            {
                MessageBox.Show($"Wrong password!", "Password error");
                return;
            }
            else
            {
                MainForm mainForm = new MainForm();
                mainForm.Username = textBoxUsername.Text;
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
        }
    }
}
