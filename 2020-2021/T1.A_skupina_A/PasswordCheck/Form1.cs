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

        private void BtnTest_Click(object sender, EventArgs e)
        {
            int skore = 0;
            char[] heslo = TxtPassword.Text.ToCharArray();
            bool male = false;
            bool velke = false;
            bool cislo = false;
            for (int i = 0; i < heslo.Length; i++)
            {
                if (Char.IsLower(heslo[i]))
                {
                    male = true;
                }

                if (Char.IsUpper(heslo[i]))
                {
                    velke = true;
                }

                if (Char.IsDigit(heslo[i]))
                {
                    cislo = true;
                }
            }
            // velke + male = 3b
            if (velke && male)
            {
                skore += 3;
            }


            // velke nebo male = 1b
            if ((velke && !male) || (!velke && male))
            {
                skore += 1;
            }
            // obsahuje cislo = 3b
            if (cislo)
            {
                skore += 3;
            }
            // kratsi nez 8 - vzdy slabe
            if (heslo.Length < 8)
            {
                skore = 0;
            }
            // 8 - 12 znaku = 1b
            if (heslo.Length >= 8 && heslo.Length < 12)
            {
                skore += 1;
            }

            // 12 - 15 = 2b
            if (heslo.Length >= 12 && heslo.Length < 15)
            {
                skore += 2;
            }
            // +15 = 3b
            if (heslo.Length >= 15)
            {
                skore += 3;
            }

            // 7+ bodu - silne heslo
            // 5-6 bodu -dobre heslo
            // <5 bodu - slabe heslo

            if (skore < 4)
            {
                LblResut.Text = "Slabé heslo";
                LblResut.BackColor = Color.Red;
            }

            if (skore >= 4 && skore < 6)
            {
                LblResut.Text = "Dobré heslo";
                LblResut.BackColor = Color.Orange;
            }

            if (skore >= 6)
            {
                LblResut.Text = "Silné heslo";
                LblResut.BackColor = Color.Green;
            }
        }
    }
}
