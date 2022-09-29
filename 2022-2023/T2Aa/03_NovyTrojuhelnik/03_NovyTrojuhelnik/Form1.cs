using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_NovyTrojuhelnik
{


    public partial class Form1 : Form
    {
        private double hranaA, hranaB, hranaC;

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            hranaA = double.Parse(TxtEdgeA.Text);
            hranaB = double.Parse(TxtEdgeB.Text);
            hranaC = double.Parse(TxtEdgeC.Text);

            if (Trojuhelnik(hranaA, hranaB, hranaC))
            {
                LblResult.BackColor = Color.Green;
                LblResult.Text = "Platný vstup";
                BtnArea.Enabled = true;
                BtnObvod.Enabled = true;
            }
            else
            {
                LblResult.BackColor = Color.Red;
                LblResult.Text = "Neplatný vstup";
                BtnArea.Enabled = false;
                BtnObvod.Enabled = false;
            }
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            double s = (hranaA + hranaB + hranaC) / 2;
            double area = Math.Sqrt(s * (s - hranaA) + (s - hranaB) + (s - hranaC));
            LblCalcul.Text = $"Obsah: {area}";
        }

        private void BtnObvod_Click(object sender, EventArgs e)
        {
            LblCalcul.Text = $"Obvod: {hranaA + hranaB + hranaC}";
        }

        public Form1()
        {
            InitializeComponent();
            BtnArea.Enabled = false;
            BtnObvod.Enabled = false;
        }

        private bool Trojuhelnik(double a, double b, double c)
        {
            //& = alt + 38
            return (a + b) > c & (a + c) > b & (b + c) > a;
        }

    }
}
