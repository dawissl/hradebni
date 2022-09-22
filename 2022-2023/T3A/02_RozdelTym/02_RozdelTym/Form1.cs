using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_RozdelTym
{
    public partial class Form1 : Form
    {
        private List<string> hraci = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(TxtName.Text == "")
            {
                MessageBox.Show("Neplatné jméno");
                return;
            }
            hraci.Add(TxtName.Text);
            string seznamHracu = "";
            foreach( string s in hraci)
            {
                seznamHracu += s + Environment.NewLine;
            }
            LblPlayers.Text = seznamHracu;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Neplatné jméno");
                return;
            }
            hraci.Remove(TxtName.Text);
            string seznamHracu = "";
            foreach (string s in hraci)
            {
                seznamHracu += s + Environment.NewLine;
            }
            LblPlayers.Text = seznamHracu;
        }

        private void BtnTeam_Click(object sender, EventArgs e)
        {
            int rozdeleni = hraci.Count / (int) NumTeamSize.Value;
            int tmp = 0;
            string vystup = "";
            foreach(string s in hraci)
            {
                if(tmp == rozdeleni)
                {
                    vystup += "---------" + Environment.NewLine;
                    tmp = 0;
                }
                vystup += s + Environment.NewLine;
                tmp++;
            }
            LblTeams.Text = vystup;
            

        }
    }
}
