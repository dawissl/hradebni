using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Hlavicky_funkci
{
    public partial class Function_01 : Form
    {
        public Function_01()
        {
            InitializeComponent();
        }

        private void TxtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtNum1.Text);
            int b = int.Parse(TxtNum2.Text);
            int c = int.Parse(TxtNum3.Text);

            int[] vystupniPole = Serad(a, b, c);

            string vystup = "";
               
            foreach(int cislo in vystupniPole)
            {
                vystup += $"{cislo}, ";
            }
            LblSorted.Text = vystup;
        }

        private int[] Serad(int a, int b, int c)
        {
            int[] arr = { a, b, c };
            Array.Sort(arr);
            return arr;
        }
    }
}
