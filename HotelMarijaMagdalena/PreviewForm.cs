﻿using System;
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
    public partial class PreviewForm : Form
    {
        public string roomNumber;
        public PreviewForm(string roomNumber)
        {
            InitializeComponent();
            this.roomNumber = roomNumber;
        }
    }
}
