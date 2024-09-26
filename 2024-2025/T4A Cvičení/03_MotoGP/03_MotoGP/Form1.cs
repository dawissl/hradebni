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
                MessageBox.Show("Pr�zdn� seznam z�vodn�k�");
                return;
            }
            if(NumTimeMax.Value == 0 || NumTimeMin.Value == 0||NumTimeMax.Value < NumTimeMin.Value)
            {
                MessageBox.Show("Z�vod nem� spr�vn� nastaven� nejrychlej�� a nejpomalej�� kolo.");
                return;
            }
            if(NumRaceLength.Value == 0)
            {
                MessageBox.Show("Nedostate�n� po�et kol z�vodu");
                return;
            }
            MessageBox.Show($"Z�vod odstartov�n s {riders.Count} jezdci");
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}