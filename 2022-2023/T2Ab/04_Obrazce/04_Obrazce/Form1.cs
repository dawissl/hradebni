using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Obrazce
{
    public partial class Form1 : Form
    {
        private List<Obrazec> seznamObrazcu = new List<Obrazec>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Obrazec o = null;
            if (RadioCircle.Checked)
            {
                double polomer = double.Parse(TxtR.Text);
               o =  new Kruh(polomer);
            }
            if (RadioTriangle.Checked)
            {
                double a = double.Parse(TxtA.Text);
                double b = double.Parse(TxtB.Text);
                double c = double.Parse(TxtC.Text);
                o = new Trojuhelnik(a, b, c);
            }
            if (RadioRectangle.Checked)
            {
                double a = double.Parse(TxtA.Text);
                double b = double.Parse(TxtB.Text);
                o = new Obdelnik(a, b);
            }

            //LblOut.Text += o.ToString() + Environment.NewLine;
            seznamObrazcu.Add(o);
            LblOut.Text = "";
            foreach(Obrazec obr in seznamObrazcu)
            {
                LblOut.Text += obr.ToString() + Environment.NewLine;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // TODO odebrat poslední záznam
            if (seznamObrazcu.Count == 0) return;
            seznamObrazcu.RemoveAt(seznamObrazcu.Count - 1);
            LblOut.Text = "";
            foreach (Obrazec obr in seznamObrazcu)
            {
                LblOut.Text += obr.ToString() + Environment.NewLine;
            }
        }

        private void LblOut_Click(object sender, EventArgs e)
        {

        }

        private void RadioRectangle_CheckedChanged(object sender, EventArgs e)
        {
            TxtC.Enabled = false;
            TxtR.Enabled = false;

            TxtA.Enabled = true;
            TxtB.Enabled = true;
        }

        private void RadioCircle_CheckedChanged(object sender, EventArgs e)
        {
            TxtC.Enabled = false;
            TxtR.Enabled = true;

            TxtA.Enabled = false;
            TxtB.Enabled = false;
        }

        private void RadioTriangle_CheckedChanged(object sender, EventArgs e)
        {
            TxtC.Enabled = true;
            TxtR.Enabled = false;
            TxtA.Enabled = true;
            TxtB.Enabled = true;
        }
    }
}
