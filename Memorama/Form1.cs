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
            HamCafeCover1.Visible = false;  HamCafe1.Visible = true;
            
            if (HamCafeCover2.Visible == false )
            {
                Correcto.Visible = true;
            }
            else if (HamCafe1.Visible == false)
            {
                Incorrecto.Visible = true;
                HamCafeCover2.Visible = true;
                HamCafe2.Visible = false;
                
            }

        }
        private void HamCafeCover2_Click(object sender, EventArgs e)
        {
            HamCafeCover2.Visible = false; HamCafe2.Visible = true;

            if (HamCafeCover1.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamCafe2.Visible == false) 
            {
                Incorrecto.Visible = true;
                HamCafeCover1.Visible = true;
                HamCafe1.Visible = false;

            }
        }

        private void HamGrisCover1_Click(object sender, EventArgs e)
        {
            HamGrisCover1.Visible = false; HamGris1.Visible = true;

            if (HamGrisCover2.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamGris1.Visible == false)
            {
                Incorrecto.Visible = true;
                HamGrisCover2.Visible = true;
                HamGris2.Visible = false;

            }
        }
        private void HamGrisCover2_Click(object sender, EventArgs e)
        {
            HamGrisCover2.Visible = false; HamGris2.Visible = true;

            if (HamGrisCover1.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamGris2.Visible == false)
            {
                Incorrecto.Visible = true;
                HamGrisCover1.Visible = true;
                HamGris1.Visible = false;

            }
        }

        private void HamGunCover1_Click(object sender, EventArgs e)
        {
            HamGunCover1.Visible = false; HamGun1.Visible = true;

            if (HamGunCover2.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamGun1.Visible == false)
            {
                Incorrecto.Visible = true;
                HamGunCover2.Visible = true;
                HamGun2.Visible = false;

            }
        }
        private void HamGunCover2_Click(object sender, EventArgs e)
        {
            HamGunCover2.Visible = false; HamGun2.Visible = true;

            if (HamGunCover1.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamGun2.Visible == false)
            {
                Incorrecto.Visible = true;
                HamGunCover1.Visible = true;
                HamGun1.Visible = false;

            }
        }

        private void HamWhiteCover1_Click(object sender, EventArgs e)
        {
            HamWhiteCover1.Visible = false; HamWhite1.Visible = true;

            if (HamWhiteCover2.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamWhite1.Visible == false)
            {
                Incorrecto.Visible = true;
                HamWhiteCover2.Visible = true;
                HamWhite2.Visible = false;

            }
        }
        private void HamWhiteCover2_Click(object sender, EventArgs e)
        {
            HamWhiteCover2.Visible = false; HamWhite2.Visible = true;

            if (HamWhiteCover1.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamWhite2.Visible == false)
            {
                Incorrecto.Visible = true;
                HamWhiteCover1.Visible = true;
                HamWhite1.Visible = false;

            }
        }

        private void HamRunCover1_Click(object sender, EventArgs e)
        {
            HamRunCover1.Visible = false; HamRun1.Visible = true;

            if (HamRunCover2.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamRun1.Visible == false)
            {
                Incorrecto.Visible = true;
                HamRunCover2.Visible = true;
                HamRun2.Visible = false;

            }
        }
        private void HamRunCover2_Click(object sender, EventArgs e)
        {
            HamRunCover2.Visible = false; HamRun2.Visible = true;

            if (HamRunCover1.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (HamRun2.Visible == false)
            {
                Incorrecto.Visible = true;
                HamRunCover1.Visible = true;
                HamRun1.Visible = false;

            }
        }

        private void CarrotCover1_Click(object sender, EventArgs e)
        {
            CarrotCover1.Visible = false; Carrot1.Visible = true;

            if (CarrotCover2.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (Carrot1.Visible == false)
            {
                Incorrecto.Visible = true;
                CarrotCover2.Visible = true;
                Carrot2.Visible = false;

            }
        }
        private void CarrotCover2_Click(object sender, EventArgs e)
        {
            CarrotCover2.Visible = false; Carrot2.Visible = true;

            if (CarrotCover1.Visible == false)
            {
                Correcto.Visible = true;
            }
            else if (Carrot2.Visible == false)
            {
                Incorrecto.Visible = true;
                CarrotCover1.Visible = true;
                Carrot1.Visible = false;

            }
        }
        
    }
}
