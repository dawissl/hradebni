using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogovOkna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtInput.Text = "";
            TxtInput.BackColor = Color.White;
        }

        private void BtnColour_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtInput.BackColor =  dialog.Color;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            ZobrazForm();
        }

        private void ZobrazForm()
        {
            Form okno = new Form();
            Label LblSlova = new Label();
            Label LblZnaky = new Label();
            Button BtnCall = new Button();

            LblSlova.Location = new Point(10, 10);
            LblZnaky.Location = new Point(10, 30);
            BtnCall.Location = new Point(10, 100);

            string vstup = TxtInput.Text;

            LblSlova.AutoSize = true;
            LblZnaky.AutoSize = true;
            LblSlova.Text =$"Počet slov: {vstup.Trim().Split(" ").Length}";
            LblZnaky.Text = $"počet znaků (bez mezer): {vstup.Replace(" ","").Length}";

            BtnCall.Text = "Pozdrav";

            BtnCall.Click += new EventHandler(Pozdrav_click); 

            okno.Controls.Add(LblSlova);
            okno.Controls.Add(LblZnaky);
            okno.Controls.Add(BtnCall);

            okno.Show();
        }

        private void Pozdrav_click(object sender, EventArgs e)
        {
            MessageBox.Show("ahoj");
        }
    }
}
