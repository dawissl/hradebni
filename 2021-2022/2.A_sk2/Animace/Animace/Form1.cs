using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animace
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;
        private bool moveYPlus = false;
        private bool moveXPlus = false;
        private bool moveYMinus = false;
        private bool moveXMinus = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Red, x, y, 50, 50);
        }   

        private void BtnReset_Click(object sender, EventArgs e)
        {
            x = 0;y = 0;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            moveYPlus = false;
            moveYMinus = true;
            moveXMinus = false;
            moveXPlus = false;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            moveXMinus = true;
            moveXPlus = false;
            moveYMinus = false;
            moveYPlus = false;
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            moveYMinus = false;
            moveYPlus = true;
            moveXPlus = false;
            moveXMinus = false;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            moveXPlus = true;
            moveXMinus = false;
            moveYMinus = false;
            moveYPlus = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Posun");
        }

        private void BtnReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                moveYPlus = false;
                moveYMinus = true;
                moveXMinus = false;
                moveXPlus = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveYMinus = false;
                moveYPlus = true;
                moveXPlus = false;
                moveXMinus = false;
            }
            if (e.KeyCode == Keys.A)
            {
                moveXMinus = true;
                moveXPlus = false;
                moveYMinus = false;
                moveYPlus = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveXPlus = true;
                moveXMinus = false;
                moveYMinus = false;
                moveYPlus = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveXMinus) x--;
            if (moveYMinus) y--;
            if (moveXPlus) x++;
            if (moveYPlus) y++;
            panel1.Refresh();
        }
    }
}
