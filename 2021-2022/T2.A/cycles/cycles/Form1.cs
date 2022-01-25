using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cycles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            int opakovani = int.Parse(TxtCislo.Text);
            string retezec = TxtRetezec.Text;
            string vystup = "";

            for(int i = 0; i < opakovani; i++)
            {
                if (i % 2 == 0) vystup += "#";
                vystup += retezec;
                if (i != opakovani - 1)
                {
                    vystup += ",\n";
                }
                else
                {
                    vystup += ".";
                }
            }

            LblVyskedek.Text = vystup;
        }
    }
}
