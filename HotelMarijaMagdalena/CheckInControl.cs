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
    public partial class CheckInControl : UserControl
    {
        public CheckInControl()
        {
            InitializeComponent();
        }

        /* Click on the Save button to open the GuestForm for each guest. */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int numberOfGuests = (int)numericUpDownGuests.Value;

            for (int i = 1; i <= numberOfGuests; i++)
            {
                GuestForm guestForm = new GuestForm();
                guestForm.Text = $"Guest number {i}";
                guestForm.ShowDialog();
            }
        }
    }
}
