using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Kinosal
{
    public partial class Form1 : Form
    {
        private Label[,] kino;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int size = int.Parse(TxtSize.Text);
            if (size <= 0)
            {
                MessageBox.Show("Nelze vytvořit takové kino!");
                return;
            }

            VymazKino();
            kino = new Label[size, size];
            // nahradit naplnenim Label[,] kino
           Label sedacka =  VytvorSedacku(0, 0);

            // pridani sedacky do formuláře
            Controls.Add(sedacka);
            for (int i = 0; i < kino.GetLength(0);i++)
            {
                
            }

        }

        private Label VytvorSedacku(int v1, int v2)
        {
            Label l = new Label();
            l.Location = new Point(50 + 30 * v1, 50 + 30 * v2);
            l.Width = 20;
            l.Height = 20;
            l.BackColor = Color.Green;
            // TODO metoda pro obarveni
            // $ = alt + 36
            l.Name = $"sedadlo_{v1+1}_{v2+1}";
            return l;
        }

        private void VymazKino()
        {
            if (kino == null) return;


        }
    }
}
