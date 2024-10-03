namespace _03_MotoGP
{
    public partial class Form1 : Form
    {
        private double timeMin, timeMax;
        private int rounds;
        private List<Rider> riders = new List<Rider>();

        public Form1()
        {
            InitializeComponent();
        }


        private void BtnRace_Click(object sender, EventArgs e)
        {
            if (riders.Count == 0)
            {
                MessageBox.Show("Prázdný seznam závodníkù");
                return;
            }
            if (NumTimeMax.Value == 0 || NumTimeMin.Value == 0 || NumTimeMax.Value < NumTimeMin.Value)
            {
                MessageBox.Show("Závod nemá správnì nastavené nejrychlejší a nejpomalejší kolo.");
                return;
            }
            if (NumRaceLength.Value == 0)
            {
                MessageBox.Show("Nedostateèný poèet kol závodu");
                return;
            }
            rounds = (int)NumRaceLength.Value;
            timeMax = (int)NumTimeMax.Value;
            timeMin = (int)NumTimeMin.Value;
            MessageBox.Show($"Vítìz závodu {StartRace()}");
        }

        /// <summary>
        /// Funkce øešící prùbìh závodu s jezdci na startovní listinì
        /// </summary>
        /// <returns>Jezdec s nejrychlejším èase</returns>
        private Rider StartRace()
        {
            Random rnd = new Random();
            // jednotlivá kola závodu
            for (int i = 0; i < rounds; i++)
            {
                foreach (Rider r in riders)
                {
                    int slowestOption = (int)((timeMax - timeMin) * ((100 - r.Experience)/100));
                    r.Time += rnd.Next((int)timeMin, (int)timeMin + slowestOption + 1);
                }
            }
            // všechna kola jsou odježdìné
            Rider theBest = riders[0];
            for (int i = 1; i < riders.Count; i++)
            {
                if (theBest.Time > riders[i].Time) theBest = riders[i];
            }

            return theBest;
        }

        private void BtnAddRider_Click(object sender, EventArgs e)
        {
            if (TxtNumber.Text == "" || TxtName.Text == "" || NumXP.Value == 0)
            {
                MessageBox.Show("Neplatné vstupní detaily závodníka");
                return;
            }
            bool startNumber = false;
            try
            {
                foreach (Rider r in riders)
                {

                    if (r.Number == short.Parse(TxtNumber.Text))
                        startNumber = true;

                }
                if (startNumber)
                {
                    MessageBox.Show("Startovní èíslo je obsazeno. Zvolte jiné.");
                    return;
                }
                riders.Add(new Rider(TxtName.Text, short.Parse(TxtNumber.Text), (double)NumXP.Value / 100.0));
            }
            catch (FormatException exep)
            {
                MessageBox.Show($"Neplatný formát startovního èísla");
                return;
            }
            MessageBox.Show($"Jezdec pøidán\n{riders[riders.Count - 1]}");
        }

        private void BtnRndGen_Click(object sender, EventArgs e)
        {
            string[] names = { "Kamil", "Ota", "Jirka", "Mirek", "Ludvík", "Dominik", "Jáchym", "Felix" };
            Random r = new Random();
            for (int i = 0; i < NumRiderCount.Value; i++)
            {
                riders.Add(new Rider(names[r.Next(names.Length)], (short)(i + 1), r.Next(70, 91)));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}