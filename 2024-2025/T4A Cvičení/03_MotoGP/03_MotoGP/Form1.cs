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
            if(riders.Count == 0)
            {
                MessageBox.Show("Prázdný seznam závodníkù");
                return;
            }
            if(NumTimeMax.Value == 0 || NumTimeMin.Value == 0||NumTimeMax.Value < NumTimeMin.Value)
            {
                MessageBox.Show("Závod nemá správnì nastavené nejrychlejší a nejpomalejší kolo.");
                return;
            }
            if(NumRaceLength.Value == 0)
            {
                MessageBox.Show("Nedostateèný poèet kol závodu");
                return;
            }
            MessageBox.Show($"Závod odstartován s {riders.Count} jezdci");
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}