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
        private Polozka p;
        public Polozka P {  get { return p; } }

        public DialogPolozka()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtNazev.Text.Trim() == string.Empty || txtPopis.Text.Trim() == string.Empty || txtPocet.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vstupy nesmí být prázdne");
                return;
            }
            if (!int.TryParse(txtPocet.Text,out int x)) {
                MessageBox.Show("Neplatný formát počtu kusů");
                return;
            }
            DialogResult = DialogResult.OK;
            p = new Polozka(txtNazev.Text, int.Parse(txtPocet.Text), txtPopis.Text);
            Close();

            int* x;
        }
    }
}
