using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all field", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
