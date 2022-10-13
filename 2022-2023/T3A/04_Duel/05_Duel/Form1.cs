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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFight_Click(object sender, EventArgs e)
        {
            Player p1 = (Player)ComboPlayer1.SelectedItem;
            Player p2 = (Player)ComboPlayer2.SelectedItem;

            if (ComboPlayer1.SelectedIndex == -1
                || ComboPlayer2.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber hráče");
                return;
            }

            string log = "";
            // | = alt + 124
            // & = alt + 38
            while (p1.Hp > 0 && p2.Hp > 0)
            {
                // TODO souboj
                Random rnd = new Random();

                // utok hrac jedna
                double koef = rnd.Next(p1.AttackMin, p1.AttackMax + 1)
                                    / (double)p2.Defense;
                p2.Hp = (int)(10 * koef);

                //utok hrac dva
                koef = rnd.Next(p2.AttackMin, p2.AttackMax + 1)
                                    / (double)p1.Defense;
                p1.Hp = (int)(10 * koef);

                log += p1.ToString() + "vs. " + p2.ToString() + Environment.NewLine;
            }
            label2.Text = log;

            //TODO zobraz vítěze
            if (p1.Hp > p2.Hp)
            {
                MessageBox.Show(p1.ToString());
            }
            else
            {
                MessageBox.Show(p2.ToString());
            }

            p1.RestoreHP();
            p2.RestoreHP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPlayer create = new FormPlayer();
            Player p = null;
            if (create.ShowDialog() == DialogResult.OK)
            {
                p = new Player(
                    create.UtokMax,
                    create.UtokMin,
                    create.Obrana,
                    create.JmenoHrace
                    );
            }
            ComboPlayer1.Items.Add(p);
            ComboPlayer2.Items.Add(p);

        }
    }
}
