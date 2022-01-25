using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            //int cislo = int.Parse(TxtCislo.Text);
            string retezec = TxtRetezec.Text;

            // kouzlo
            if(retezec == "kouzlo")
            {
                int counter = 0;
                foreach(char c in LblResulr.Text)
                {
                    if(c.ToString() == " ")
                    {
                        counter++;
                    }
                }
                MessageBox.Show($"Počet vstupů je: {counter}");
            }
            else
            {
                LblResulr.Text += retezec + " ";
            }

          /*  string vysledek = "";

            for (int k = 0; k < cislo; k++)
            {
                if (k % 2 == 0)
                {
                    vysledek += "#";
                }
                vysledek += retezec;
                if (k == cislo-1)
                {
                    vysledek += ".";
                }
                else
                {
                    vysledek += ",\n";
                }                
            }

            LblResulr.Text = vysledek;*/
        }
    }
}
