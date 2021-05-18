using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhmuvZakon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOdpor_Click(object sender, EventArgs e)
        {
            if (TxtNapeti.Text == "" || TxtProud.Text == "")
            {
                MessageBox.Show("Chybí vstupní hodnoty");
                return;
            }
            double napeti = double.Parse(TxtNapeti.Text);
            double proud = double.Parse(TxtProud.Text);
            double odpor;

            if (proud == 0)
            {
                MessageBox.Show("Pozor dělení nulou");
                return;
            }

            odpor = napeti / proud;

            TxtOdpor.Text = odpor.ToString();
        }

        private void BtnNapeti_Click(object sender, EventArgs e)
        {
            if (TxtOdpor.Text == "" || TxtProud.Text == "")
            {
                MessageBox.Show("Chybí vstupní hodnoty");
                return;
            }
            double napeti;
            double proud = double.Parse(TxtProud.Text);
            double odpor = double.Parse(TxtOdpor.Text);

            napeti = proud * odpor;

            TxtNapeti.Text = napeti.ToString();
        }

        private void BtnProud_Click(object sender, EventArgs e)
        {
            if (TxtOdpor.Text == "" || TxtNapeti.Text == "")
            {
                MessageBox.Show("Chybí vstupní hodnoty");
                return;
            }
            double napeti = double.Parse(TxtNapeti.Text);
            double proud ;
            double odpor = double.Parse(TxtOdpor.Text);

            if(odpor == 0)
            {
                MessageBox.Show("Pozor dělení nulou!");
                return;
            }

            proud = napeti / odpor;

            TxtProud.Text = proud.ToString();
        }
    }
}
