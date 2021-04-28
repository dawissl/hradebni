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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOdpor_Click(object sender, EventArgs e)
        {
            if(txtNapeti.Text == "" || txtProud.Text == "")
            {
                MessageBox.Show("Nezadali jste vstupní hodnoty");
                return;
            }

            double napeti = double.Parse(txtNapeti.Text);
            double proud = double.Parse(txtProud.Text);
            if(napeti < 0 || proud < 0)
            {
                MessageBox.Show("Vstupní hodnoty nesmí být záporné");
                return;
            }
            if(proud == 0)
            {
                MessageBox.Show("Proud nesmí být nulový!");
                return;
            }
            double odpor = napeti / proud;
            txtOdpor.Text = odpor.ToString();
        }

        private void btnNapeti_Click(object sender, EventArgs e)
        {
            if (txtOdpor.Text == "" || txtProud.Text == "")
            {
                MessageBox.Show("Nezadali jste vstupní hodnoty");
                return;
            }
            double odpor = double.Parse(txtOdpor.Text);
            double proud = double.Parse(txtProud.Text);
            if (proud < 0 || odpor < 0)
            {
                MessageBox.Show("Vstupní hodnoty nesmí být záporné");
                return;
            }
            double napeti = odpor * proud;
            txtNapeti.Text = napeti.ToString();
        }

        private void btnProud_Click(object sender, EventArgs e)
        {
            if (txtNapeti.Text == "" || txtOdpor.Text == "")
            {
                MessageBox.Show("Nezadali jste vstupní hodnoty");
                return;
            }
            double napeti = double.Parse(txtNapeti.Text);
            double odpor = double.Parse(txtOdpor.Text);
            if (napeti < 0 || odpor < 0)
            {
                MessageBox.Show("Vstupní hodnoty nesmí být záporné");
                return;
            }
            if (odpor == 0)
            {
                MessageBox.Show("Odpor nesmí být nulový!");
                return;
            }
            double proud = napeti / odpor;
            txtProud.Text = proud.ToString();
        }
    }
}
