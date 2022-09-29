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
            // inicializace nového pole
            kino = new Label[size, size];

            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    kino[i, j] = VytvorSedacku(i, j);
                    Controls.Add(kino[i, j]);
                }
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
            l.Click += new EventHandler(this.Seat_Click);
            // $ = alt + 36
            l.Name = $"sedadlo_{v1 + 1}_{v2 + 1}";
            return l;
        }
        private void Seat_Click(object sender, EventArgs e)
        {
            if((sender as Label).BackColor == Color.Green)
            {
                (sender as Label).BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show($"Sedačka { (sender as Label).Name} je obsazena");
            }
        }

        private void VymazKino()
        {
            if (kino == null) return;
            // vyprazdni naplnene kino
            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    Controls.Remove(kino[i, j]);
                }
            }

        }
    }
}
