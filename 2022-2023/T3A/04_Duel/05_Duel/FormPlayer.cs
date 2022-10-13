using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Duel
{
    public partial class FormPlayer : Form
    {

        private string jmenoHrace;
        private int utokMax;
        private int utokMin;
        private int obrana;
        public string JmenoHrace { get { return jmenoHrace; } }
        public int UtokMax { get { return utokMax; } }
        public int UtokMin { get { return utokMin; } }
        public int Obrana { get { return obrana; } }

        public FormPlayer()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            utokMax = int.Parse(TxtPlayerMaxAttack.Text);
            utokMin = int.Parse(TxtPlayerMinAttack.Text);
            obrana = int.Parse(TxtPlayerDefense.Text);
            jmenoHrace = TxtPlayerName.Text;

            DialogResult = DialogResult.OK;
            Close();

        }



    }
}
