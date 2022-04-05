using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtInput.BackColor = Color.White;
            TxtInput.Text = "";
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            FormularPocitani();
        }

        /// <summary>
        /// Zobrazi nemodalni okno s počtem slov a znaků v textboxu
        /// </summary>
        private void FormularPocitani()
        {
            Form pocet = new Form();
            pocet.Text = "Počítadlo";

            // počet slov
            Label slova = new Label();
            slova.Location = new Point(10, 10);
            slova.AutoSize = true;
            slova.Text = $"Počet slov: {TxtInput.Text.Trim().Split(" ").Length}";
            //počet znaků bez mezer
            Label znaky = new Label();
            znaky.AutoSize = true;
            znaky.Location = new Point(10, 40);
            znaky.Text = $"Počet znaků (bez mezer): {TxtInput.Text.Replace(" ","").Length}";

            pocet.Controls.Add(slova);
            pocet.Controls.Add(znaky);
            pocet.ShowDialog();
        }

        private void BtnColour_Click(object sender, EventArgs e)
        {
            
            if(ClrDialog.ShowDialog() == DialogResult.OK)
            {
                TxtInput.BackColor = ClrDialog.Color;
            }
        }
    }
}
