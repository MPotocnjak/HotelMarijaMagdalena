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
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }

        /* Opening previewForm */
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            PreviewForm previewForm = new PreviewForm();
            previewForm.Show();
        }
    }
}
