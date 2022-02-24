using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Form1 : Form
    {
        private Vytah nasVytah = new Vytah(800, 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            nasVytah = new Vytah(800, 10);
            LblCount.BackColor = Color.Lime;
            LblWeight.BackColor = Color.Lime;
            TxtElevator.Text = "";
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            nasVytah.pridejOsobu(int.Parse(TxtWeight.Text));


            if (nasVytah.AktualniVaha > nasVytah.MaxVaha)
                LblWeight.BackColor = Color.Red;
            if (nasVytah.AktualniPocet > nasVytah.MaxPocet)
                LblCount.BackColor = Color.Red;

            TxtElevator.Text += $"{TxtWeight.Text}{Environment.NewLine}";
        }
    }
}
