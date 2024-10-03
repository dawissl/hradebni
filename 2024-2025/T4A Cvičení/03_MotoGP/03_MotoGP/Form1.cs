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
                MessageBox.Show("Pr�zdn� seznam z�vodn�k�");
                return;
            }
            if (NumTimeMax.Value == 0 || NumTimeMin.Value == 0 || NumTimeMax.Value < NumTimeMin.Value)
            {
                MessageBox.Show("Z�vod nem� spr�vn� nastaven� nejrychlej�� a nejpomalej�� kolo.");
                return;
            }
            if (NumRaceLength.Value == 0)
            {
                MessageBox.Show("Nedostate�n� po�et kol z�vodu");
                return;
            }
            rounds = (int)NumRaceLength.Value;
            timeMax = (int)NumTimeMax.Value;
            timeMin = (int)NumTimeMin.Value;
            MessageBox.Show($"V�t�z z�vodu {StartRace()}");
        }

        /// <summary>
        /// Funkce �e��c� pr�b�h z�vodu s jezdci na startovn� listin�
        /// </summary>
        /// <returns>Jezdec s nejrychlej��m �ase</returns>
        private Rider StartRace()
        {
            Random rnd = new Random();
            // jednotliv� kola z�vodu
            for (int i = 0; i < rounds; i++)
            {
                foreach (Rider r in riders)
                {
                    int slowestOption = (int)((timeMax - timeMin) * ((100 - r.Experience)/100));
                    r.Time += rnd.Next((int)timeMin, (int)timeMin + slowestOption + 1);
                }
            }
            // v�echna kola jsou odje�d�n�
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
                MessageBox.Show("Neplatn� vstupn� detaily z�vodn�ka");
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
                    MessageBox.Show("Startovn� ��slo je obsazeno. Zvolte jin�.");
                    return;
                }
                riders.Add(new Rider(TxtName.Text, short.Parse(TxtNumber.Text), (double)NumXP.Value / 100.0));
            }
            catch (FormatException exep)
            {
                MessageBox.Show($"Neplatn� form�t startovn�ho ��sla");
                return;
            }
            MessageBox.Show($"Jezdec p�id�n\n{riders[riders.Count - 1]}");
        }

        private void BtnRndGen_Click(object sender, EventArgs e)
        {
            string[] names = { "Kamil", "Ota", "Jirka", "Mirek", "Ludv�k", "Dominik", "J�chym", "Felix" };
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