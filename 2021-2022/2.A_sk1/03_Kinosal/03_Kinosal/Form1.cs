namespace _03_Kinosal
{
    public partial class Form1 : Form
    {
        private Label[,] kino = null;
        private Label platno = null;
        private bool rezervace = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGeneruj_Click(object sender, EventArgs e)
        {
            // vymazat kino
            VymazKino();
            // inicializace dvourozm�rn�ho pole reprezentujici kino
            kino = new Label[(int)NumVelikostKina.Value, (int)NumVelikostKina.Value];

            // umisteni platna p�ed seda�ky
            platno = NovePlatno((int)NumVelikostKina.Value);
            Controls.Add(platno);

            // pr�chod 2D polem, napln�n� a vlo�en� seda�ky (Label) na formul��
            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    // vygenerov�n� seda�ky na pozici i, j
                    kino[i, j] = GenerujSedacku(i + 1, j + 1);
                    // vlo�en� do formul��e
                    Controls.Add(kino[i, j]);
                }
            }

        }

        private Label NovePlatno(int value)
        {
            Label p = new Label();
            p.Text = "pl�tno";
            p.TextAlign = ContentAlignment.MiddleCenter;
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Height = 20;
            p.Width = 30 * value - 10;
            p.Location = new Point(50, 90);
            return p;
        }

        private void VymazKino()
        {
            if (kino == null) return;
            if (platno == null) return;
            Controls.Remove(platno);
            for (int i = 0; i < kino.GetLength(0); i++)
            {
                for (int j = 0; j < kino.GetLength(1); j++)
                {
                    Controls.Remove(kino[i, j]);
                }
            }
        }

        private Label GenerujSedacku(int v1, int v2)
        {
            Label novaSedacka = new Label();
            novaSedacka.BackColor = Color.Aqua;
            novaSedacka.Width = 20;
            novaSedacka.Height = 20;
            // $ = alt + 36
            novaSedacka.Name = $"rada:{v2}-sedadlo:{v1}";
            novaSedacka.Location = new Point(50 + 30 * (v1 - 1), 120 + 30 * (v2 - 1));
            // pridani obslu�n� metody seda�ky po kliknut� na seda�ku
            novaSedacka.Click += new EventHandler(Rezervace);
            return novaSedacka;
        }


        private void Rezervace(object? sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.Red && rezervace)
            {
                MessageBox.Show($"{(sender as Label).Name} je obsazeno");
            }

            if ((sender as Label).BackColor == Color.Red && !rezervace)
            {
                (sender as Label).BackColor = Color.Aqua;
            }

            if ((sender as Label).BackColor == Color.Aqua && rezervace)
            {
                (sender as Label).BackColor = Color.Red;
            }
        }

        private void BtnRezervace_Click(object sender, EventArgs e)
        {
            rezervace = !rezervace;
            if (rezervace)
            {
                BtnRezervace.Text = "+";
            }
            else
            {
                BtnRezervace.Text = "-";
            }
        }
    }
}