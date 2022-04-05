using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linie
{
    public partial class Form1 : Form
    {
        private Point[] body = new Point[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVykresli_Click(object sender, EventArgs e)
        {
            TxtInput.Text = "";
            Random rnd = new Random();
            for(int i = 0; i < 20; i++)
            {
                TxtInput.Text += $"{rnd.Next(0, 300)}";
                if (i != 19) { TxtInput.Text += ","; }
            }
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (TxtInput.Text == "") return;
            string[] retezcovyVstup = TxtInput.Text.Split(',');
            body = new Point[retezcovyVstup.Length];

            for(int i = 0; i < body.Length; i++)
            {
                body[i] = new Point(i * 20, int.Parse(retezcovyVstup[i]));
            }

            e.Graphics.DrawLines(Pens.Magenta, body);


        }
    }
}
