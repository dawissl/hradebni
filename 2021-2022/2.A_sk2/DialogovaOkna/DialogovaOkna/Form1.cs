using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogovaOkna
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

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                TxtInput.BackColor = dialog.Color;
            }
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            ZobrazFormular();
        }

        private void ZobrazFormular()
        {
            Form formularoveOkno = new Form();
            formularoveOkno.Text = "Počítadlo";

            Button btn = new Button();
            btn.Location = new Point(50, 100);
            btn.Text = "xxx";
            btn.Click += new EventHandler(Foo);
                
            Label lblPocetSlov = new Label();
            Label lblPocetZnaku = new Label();
            lblPocetZnaku.AutoSize = true;

            lblPocetSlov.Text = $"Počet slov: " +
                $"{TxtInput.Text.Trim().Split(" ").Length}";

            lblPocetZnaku.Text = $"Počet znaků(bez mezer): " +
                $"{TxtInput.Text.Replace(" ","").Length}";

            lblPocetSlov.Location = new Point(10, 10);
            lblPocetZnaku.Location = new Point(10, 40);

            formularoveOkno.Controls.Add(lblPocetZnaku);
            formularoveOkno.Controls.Add(lblPocetSlov);
            formularoveOkno.Controls.Add(btn);
            formularoveOkno.ShowDialog();
        }

        private void Foo(object sender, EventArgs e)
        {
           Close();
        }
    }
}
