﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HamCafeCover1_Click(object sender, EventArgs e)
        {
            HamCafeCover1.Visible = false;
            HamCafe1.Visible = true;

        }
    }
}