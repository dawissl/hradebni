using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Katalog
{
    public partial class DialogPolozka : Form
    {
        private Polozka polozka;
        public Polozka Polozka {  get { return polozka; }}
        public DialogPolozka()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            polozka = new Polozka(txtNazev.Text, (int)numPocet.Value, txtPopis.Text);
            this.Close();
        }
    }
}
