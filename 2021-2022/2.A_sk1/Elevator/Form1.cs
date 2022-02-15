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
        // inicializace noveho výtahu
        private Vytah novyVytah = new Vytah(8, 500);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            int vaha = int.Parse(TxtWeight.Text);

            
            novyVytah.AddPerson(vaha);
            TxtElevator.Text = novyVytah.ToString();
            if (novyVytah.Overweight())
                LblWeight.BackColor = Color.Red;
            if(novyVytah.Overcounte())
                LblCount.BackColor = Color.Red;

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtElevator.Text = "";
            TxtWeight.Text = "";
            LblCount.BackColor = Color.Green;
            LblWeight.BackColor = Color.Green;
            novyVytah = new Vytah(8, 500);
        }
    }
}
