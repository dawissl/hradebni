using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int skore = 0;
            bool male = false;
            bool velke = false;
            bool cislo = false;

            // převedení vstupního řetězce na pole znaků
            char[] heslo = TxtPassword.Text.ToCharArray();

            for (int i = 0; i < heslo.Length; i++)
            {
                if (Char.IsDigit(heslo[i]))
                {
                    cislo = true;
                }

                if (Char.IsUpper(heslo[i]))
                {
                    velke = true;
                }

                if (Char.IsLower(heslo[i]))
                {
                    male = true;
                }


            }

            // male / velke = 1b
            if ((male && !velke) || (!male && velke))
            {
                skore += 1;
            }
            // male + velke = 3b
            if (male && velke)
            {
                skore += 3;
            }
            // cislice = 2b
            if (cislo)
            {
                skore += 2;
            }
            // delka <8 - vždy slabe
            if (heslo.Length < 8)
            {
                skore = 0;
            }
            // delka 8-12 = 1b
            if (heslo.Length >= 8 && heslo.Length < 12)
            {
                skore += 1;
            }
            // delka 12-15 = 2b
            if (heslo.Length >= 12 && heslo.Length < 15)
            {
                skore += 2;
            }
            // delka 15+ = 3b
            if (heslo.Length >= 15)
            {
                skore += 3;
            }

            //skore <5 - slabe heslo
            // 5-6 - dobre heslo
            // 7+ silne heslo

            if (skore < 5)
            {
                // slabe
                LblResult.Text = "Slabé heslo";
                LblResult.BackColor = Color.Red;
            }

            if (skore >= 5 && skore < 7)
            {
                // dobre
                LblResult.Text = "Dobré heslo";
                LblResult.BackColor = Color.Orange;
            }

            if (skore >= 7)
            {
                // silne
                LblResult.Text = "Silné heslo";
                LblResult.BackColor = Color.Green;
            }
        }
    }
}
