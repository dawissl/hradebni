using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_MortalKombat
{
    public partial class NewPlayerForm : Form
    {
        public NewPlayerForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
           
            this.Close();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
