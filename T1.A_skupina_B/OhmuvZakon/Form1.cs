using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// @author = David Sladecek
/// </summary>
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
                MessageBox.Show("Nezadali jste vstupní hodnoty!");
                return;
            }
            double napeti = double.Parse(TxtNapeti.Text);
            double proud = double.Parse(TxtProud.Text);
            if(napeti<0 || proud < 0)
            {
                MessageBox.Show("Hodnoty nesmí být záporné");
                return;
            }
            if (proud == 0)
            {
                MessageBox.Show("Proud nesmí bý nulový");
                return;
            }
            double odpor = napeti / proud;

            TxtOdpor.Text = odpor.ToString();
        }

        private void BtnNapeti_Click(object sender, EventArgs e)
        {
            if (TxtOdpor.Text == "" || TxtProud.Text == "")
            {
                MessageBox.Show("Nezadali jste vstupní hodnoty!");
                return;
            }
            double odpor = double.Parse(TxtOdpor.Text);
            double proud = double.Parse(TxtProud.Text);
            if (proud < 0 || odpor < 0)
            {
                MessageBox.Show("Hodnoty nesmí být záporné");
                return;
            }
            double napeti = odpor * proud;

            TxtNapeti.Text = napeti.ToString();
        }

        private void BtnProud_Click(object sender, EventArgs e)
        {
            if (TxtNapeti.Text == "" || TxtOdpor.Text == "")
            {
                MessageBox.Show("Nezadali jste vstupní hodnoty!");
                return;
            }
            double napeti = double.Parse(TxtNapeti.Text);
            double odpor = double.Parse(TxtOdpor.Text);
            if (napeti < 0 || odpor < 0)
            {
                MessageBox.Show("Hodnoty nesmí být záporné");
                return;
            }
            if (odpor == 0)
            {
                MessageBox.Show("Proud nesmí bý nulový");
                return;
            }
            double proud = napeti / odpor;

            TxtProud.Text = proud.ToString();
        }
    }
}
