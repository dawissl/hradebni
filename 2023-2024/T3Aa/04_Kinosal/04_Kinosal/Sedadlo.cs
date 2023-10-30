using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Kinosal
{
    internal class Sedadlo : Label
    {

        public Sedadlo()
        {
            Height = 30;
            Width = 30;
            BackColor = Color.Aqua;
            Click += Sedadlo_Click;
        }

        private void Sedadlo_Click(object? sender, EventArgs e)
        {
            if (BackColor == Color.Aqua)
            {
                BackColor = Color.DeepPink;
            }
            else
            {
                MessageBox.Show($"Sedadlo {Text} je obsazeno, zvolte jiné");
            }

        }
    }
}
