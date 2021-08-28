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

        private void BtnVypocetOdporu_Click(object sender, EventArgs e)
        {
            if(TxtNapeti.Text == "" || TxtProud.Text == "")
            {
                MessageBox.Show("Vstupní hodnoty nesmí být prázdé");
                return;
            }
            double napeti = double.Parse(TxtNapeti.Text);
            double proud = double.Parse(TxtProud.Text);
            if(proud == 0)
            {
                MessageBox.Show("Proud nesmí být nulový!");
                return;
            }
            if(proud < 0 || napeti < 0)
            {
                MessageBox.Show("Vstupní hodnoty nesmí být záporné");

            }
            double odpor = napeti / proud;

            TxtOdpor.Text = odpor.ToString();
        }

        private void BtnNapeti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napětí zatím nelze spočítat");
        }

        private void BtnProud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proud zatím nelze spočítat");
        }
    }
}
