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
    public partial class MainForm : Form
    {
        public String Username;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Visible = true;
            panelSlide.Height = btn.Height;

        }

        private void labelHotelName_Click(object sender, EventArgs e)
        {
            panelSlide.Visible = false;
            pictureBoxHotel.Visible = true;
            roomControl.Hide();
            checkInControl.Hide();
            reservationControl.Hide();
            employeeControl.Hide();
            billControl.Hide();
            serviceControl.Hide();
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            MovePanel(RoomsButton);
            pictureBoxHotel.Visible = false;
            roomControl.Show();
            checkInControl.Hide();
            reservationControl.Hide();
            employeeControl.Hide();
            billControl.Hide();
            serviceControl.Hide();
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            MovePanel(CheckInButton);
            pictureBoxHotel.Visible = false;
            roomControl.Hide();
            checkInControl.Show();
            reservationControl.Hide();
            employeeControl.Hide();
            billControl.Hide();
            serviceControl.Hide();
        }

        private void ReservationsButton_Click(object sender, EventArgs e)
        {
            MovePanel(ReservationsButton);
            pictureBoxHotel.Visible = false;
            roomControl.Hide();
            checkInControl.Hide();
            reservationControl.Show();
            employeeControl.Hide();
            billControl.Hide();
            serviceControl.Hide();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            MovePanel(EmployeeButton);
            pictureBoxHotel.Visible = false;
            roomControl.Hide();
            checkInControl.Hide();
            reservationControl.Hide();
            employeeControl.Show();
            billControl.Hide();
            serviceControl.Hide();
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            MovePanel(BillButton);
            pictureBoxHotel.Visible = false;
            roomControl.Hide();
            checkInControl.Hide();
            reservationControl.Hide();
            employeeControl.Hide();
            billControl.Show();
            serviceControl.Hide();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            MovePanel(ServicesButton);
            pictureBoxHotel.Visible = false;
            roomControl.Hide();
            checkInControl.Hide();
            reservationControl.Hide();
            employeeControl.Hide();
            billControl.Hide();
            serviceControl.Show();
        }

        /* Showing username after loading form. */
        private void MainForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }

        /* Clik on "Log out" to close the form. */
        private void labelLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
