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
        private double stranaA, stranaB, stranaC;

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            stranaA = double.Parse(TxtEdgeA.Text);
            stranaB = double.Parse(TxtEdgeB.Text);
            stranaC = double.Parse(TxtEdgeC.Text);

            if (Trojuhelnik(stranaA, stranaB, stranaC))
            {
                LblResult.BackColor = Color.Green;
                LblResult.Text = "Validní trojúhelník";
                BtnArea.Enabled = true;
                BtnObvod.Enabled = true;
            }
            else
            {
                LblResult.BackColor = Color.Red;
                LblResult.Text = "Neplatný vstup!";
                BtnArea.Enabled = false;
                BtnObvod.Enabled = false;
            }
        }
        private bool Trojuhelnik(double a, double b, double c)
        {
            if (a + b <= c) return false;
            if (a + c <= b) return false;
            if (b + c <= a) return false;
            return true;
            
            //return (a + b) > c & (a + c) > b & (b + c) > a;
        }

        public Form1()
        {
            InitializeComponent();
            BtnArea.Enabled = false;
            BtnObvod.Enabled = false;
        }
        

    }
}
