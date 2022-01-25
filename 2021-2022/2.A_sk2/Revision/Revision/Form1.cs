using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtRetezec_TextChanged(object sender, EventArgs e)
        {

            


        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            int repetition = int.Parse(TxtCislo.Text);
            string output = "";
            for (int i = 0; i < repetition; i++)
            {
                output += TxtRetezec.Text;

                if(i == repetition - 1)
                {
                    output += ".";
                }
                else
                {
                    output += ",\n";
                }
            }

            LblVystup.Text = output;
        }
    }
}
