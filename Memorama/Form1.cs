using System;
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

        private void HamGrisCover1_Click(object sender, EventArgs e)
        {
            HamGrisCover1.Visible = false;
            HamGris1.Visible = true;
        }

        private void HamGunCover1_Click(object sender, EventArgs e)
        {
            HamGunCover1.Visible = false;
            HamGun1.Visible = true;
        }

        private void HamWhiteCover1_Click(object sender, EventArgs e)
        {
            HamWhiteCover1.Visible = false;
            HamWhite1.Visible = true;
        }

        private void HamWhiteCover2_Click(object sender, EventArgs e)
        {
            HamWhiteCover2.Visible = false;
            HamWhite2.Visible = true;
        }

        private void HamRunCover1_Click(object sender, EventArgs e)
        {
            HamRunCover1.Visible = false;
            HamRun1.Visible = true;
        }

        private void HamCafeCover2_Click(object sender, EventArgs e)
        {
            HamCafeCover2.Visible = false;
            HamCafe2.Visible = true;
        }

        private void CarrotCover1_Click(object sender, EventArgs e)
        {
            CarrotCover1.Visible = false;
            Carrot1.Visible = true;
        }

        private void HamGunCover2_Click(object sender, EventArgs e)
        {
            HamGunCover2.Visible = false;
            HamGun2.Visible = true;
        }

        private void CarrotCover2_Click(object sender, EventArgs e)
        {
            CarrotCover2.Visible = false;
            Carrot2.Visible = true;
        }

        private void HamRunCover2_Click(object sender, EventArgs e)
        {
            HamRunCover2.Visible = false;
            HamRun2.Visible = true;
        }

        private void HamGrisCover2_Click(object sender, EventArgs e)
        {
            HamGrisCover2.Visible = false;
            HamGris2.Visible = true;
        }
    }
}
