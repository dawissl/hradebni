namespace NakupniKosik
{
    public partial class Form1 : Form
    {
        private Zbozi[] nakupniSeznam = new Zbozi[10];
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Zbozi z = null;

            switch (ComboType.Text)
            {
                case "Zboží":
                    z = new Zbozi(TxtName.Text, double.Parse(TxtPrice.Text));
                    break;

                case "Potravina":
                    z = new Potravina(TxtName.Text, double.Parse(TxtPrice.Text), double.Parse(TxtWeight.Text));
                    break;
                case "Drogerie":
                    z = new Drogerie(TxtName.Text, double.Parse(TxtPrice.Text),TxtUsedBy.Text);
                    break;
                default:
                    Erase();
                    return;
            }

            if (index < 10)
            {
                nakupniSeznam[index] = z;
                index++;
                Erase();
            }
            else
            {
                MessageBox.Show("Nakupní košík je plný");
                Erase();
                return;
            }

            LblShop.Text = "";
            double vyslednaCena = 0;
            for (int i = 0; i < index; i++)
            {
                LblShop.Text += nakupniSeznam[i].ToString() + Environment.NewLine;
                vyslednaCena += nakupniSeznam[i].Cena;
            }
            LblPrice.Text = $"{vyslednaCena} Kè";

        }

        private void Erase()
        {
            TxtName.Text = "";
            TxtPrice.Text = "";
            TxtUsedBy.Text = "";
            TxtWeight.Text = "";
            ComboType.Text = "";
        }

        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboType.Text)
            {
                case "Zboží":
                    TxtUsedBy.Enabled = false;
                    TxtWeight.Enabled = false;
                    break;
                case "Potravina":
                    TxtUsedBy.Enabled = false;
                    TxtWeight.Enabled = true;
                    break;
                case "Drogerie":
                    TxtUsedBy.Enabled = true;
                    TxtWeight.Enabled = false;
                    break;
            }
        }
    }

    class Zbozi
    {
        private string nazev;
        private double cena;

        public double Cena { get { return cena; } }

        public Zbozi(string nazev, double c)
        {
            this.nazev = nazev;
            cena = c;
        }

        public override string ToString()
        {
            // $ = alt + 36
            return $"{nazev} - {cena} Kè";
        }
    }

    class Potravina : Zbozi
    {
        private double vaha;

        public Potravina(string n, double c, double v) : base(n, c)
        {
            vaha = v;
        }

        public override string ToString()
        {
            return base.ToString() + $"(váha: {vaha}kg)";
        }
    }

    class Ovoce : Potravina
    {
        private Color barva;

        public Ovoce(string n, double c, double v, Color b) : base(n, c, v)
        {
            barva = b;
        }
    }

    class Drogerie: Zbozi
    {
        private string urceni;

        public Drogerie(string n, double c,string u) : base(n, c)
        {
            urceni = u;
        }

        public override string ToString()
        {
            return base.ToString() + $"(pro {urceni})";
        }
    }
}