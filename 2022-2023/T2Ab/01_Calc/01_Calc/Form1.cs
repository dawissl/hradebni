using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Calc
{
    public partial class Form1 : Form
    {
        // atributy představující číselné hodnoty pro výpočet
        private double cisloA, cisloB;
        public Form1()
        {
            InitializeComponent();
        }

        // sečtení hodnot
        private void BtnScitani_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            LblResult.Text = $"{cisloA + cisloB}";
        }

        private void BtnOdcitani_Click_1(object sender, EventArgs e)
        {
            LoadNumbers();
            LblResult.Text = $"{cisloA - cisloB}";
        }

        private void BtnNasobeni_Click_1(object sender, EventArgs e)
        {
            LoadNumbers();
            LblResult.Text = $"{cisloA * cisloB}";
        }

        private void BtnDeleni_Click_1(object sender, EventArgs e)
        {
            LoadNumbers();
            // kontrola dělení nulou
            if (cisloB == 0)
            {
                MessageBox.Show("Dělení nulou!");
                // v případě, že je zobrazena informace o chybě,
                // funkce dále nepokračuje -> užití return
                return;
            }

            LblResult.Text = $"{cisloA / cisloB}";
        }

        /// <summary>
        /// Funkce pro inicializaci atributů formuláře a vymazání výstupu
        /// </summary>
        private void LoadNumbers()
        {
            cisloA = (double)NumA.Value;
            cisloB = (double)NumB.Value;
            LblResult.Text = "";
        }
    }
}
