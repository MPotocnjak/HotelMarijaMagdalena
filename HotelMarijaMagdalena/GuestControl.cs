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
    public partial class GuestControl : UserControl
    {
        public GuestControl()
        {
            InitializeComponent();
        }

        /* Click on the button Save allows closing current form. */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}
