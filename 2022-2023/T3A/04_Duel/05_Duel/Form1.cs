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
            Player p1 = new Player(12, 5, 6, "Kamil");
            Player p2 = new Player(7, 4, 9, "Jarmilka");

            string log = "";
            // | = alt + 124
            // & = alt + 38
            while (p1.Hp > 0 && p2.Hp > 0)
            {
                // TODO souboj
                Random rnd = new Random();

                // utok hrac jedna
                double koef = rnd.Next(p1.AttackMin,p1.AttackMax +1)
                                    / (double) p2.Defense;
                p2.Hp =(int) (10 * koef);

                //utok hrac dva
                koef = rnd.Next(p2.AttackMin, p2.AttackMax + 1)
                                    / (double)p1.Defense;
                p1.Hp = (int)(10 * koef);

                log += p1.ToString() + "vs. " + p2.ToString()+ Environment.NewLine;
            }
            label2.Text = log;

            //TODO zobraz vítěze
            if(p1.Hp > p2.Hp)
            {
                MessageBox.Show(p1.ToString());
            }
            else
            {
                MessageBox.Show(p2.ToString());
            }
        }
    }
}
