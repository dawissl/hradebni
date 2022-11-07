namespace _03_Kinosal
{

    public partial class Form1 : Form
    {
        private Label[,] kinoSal = new Label[0, 0];
        private Label platno;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            VymazKino();

            // ziskani velikosi salu a vytvo�en� nov�ho 2D pole
            int size = (int)NumCinemaSize.Value;
            kinoSal = new Label[size, size];

            platno = GenerujPlatno(size);
            Controls.Add(platno);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kinoSal[i, j] = GenerujSedacku(i, j);
                    Controls.Add(kinoSal[i, j]);
                }
            }

        }

        private Label GenerujPlatno(int size)
        {
            Label p = new Label();
            p.Text = "pl�tno";
            p.TextAlign = ContentAlignment.MiddleCenter;
            p.Location = new Point(50, 70);
            p.Height = 20;
            p.Width = (size) *30 ;
            p.BackColor = Color.White;
            return p;
        }

        private void VymazKino()
        {
            
            // nema�eme kino, pokud nebylo vyto�eno
            if (kinoSal.GetLength(0) == 0) return;


            // postupne maz�n� kina            
            for (int i = 0; i < kinoSal.GetLength(0); i++)
            {
                for (int j = 0; j < kinoSal.GetLength(1); j++)
                {
                    // odebr�n� z formul��e
                    Controls.Remove(kinoSal[i, j]);
                }
            }

            Controls.Remove(platno);
        }

        private Label GenerujSedacku(int v1, int v2)
        {
            Label sedacka = new Label();
            sedacka.Location = new Point(50 + v1 * 30, 110 + v2 * 30);
            sedacka.Width = 20;
            sedacka.Height = 20;
            sedacka.BackColor = Color.Yellow;
            // obslu�n� metoda - kliknut� na seda�ku
            sedacka.Click += new EventHandler(Rezervace);
            return sedacka;

        }

        private void Rezervace(object? sender, EventArgs e)
        {

            if ((sender as Label).BackColor == Color.Yellow && CheckReservation.Checked)
            {
                (sender as Label).BackColor = Color.Red;
                return;
            }

            if ((sender as Label).BackColor == Color.Red && CheckReservation.Checked)
            {
                MessageBox.Show("Seda�ka je ji� obsazena");
                return;
            }

            if ((sender as Label).BackColor == Color.Yellow && !CheckReservation.Checked)
            {
                return;
            }

            if ((sender as Label).BackColor == Color.Red && !CheckReservation.Checked)
            {
                (sender as Label).BackColor = Color.Yellow;
            }
        }
    }
}