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
                    z = new Potravina(TxtName.Text, double.Parse(TxtPrice.Text), TxtStore.Text);
                    break;
                case "Drogerie":
                    z = new Drogerie(TxtName.Text, double.Parse(TxtPrice.Text), TxtUsedBy.Text);
                    break;
                default:
                    Erase();
                    return;
            }

            if (index < 10)
            {
                nakupniSeznam[index] = z;
                index++;
            }
            else
            {
                MessageBox.Show("Nakupní košík je plný");
                return;
            }
            Erase();

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
            TxtStore.Text = "";
            TxtName.Text = "";
            TxtPrice.Text = "";
            TxtUsedBy.Text = "";
            ComboType.Text = "";
            
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
        private string skladovani;

        public Potravina(string n, double c, string s) : base(n, c)
        {
            skladovani = s;
        }

        public override string ToString()
        {
            return base.ToString() + $" (skladování:{skladovani})";
        }
    }

    class Ovoce : Potravina
    {
        private double vaha;

        public Ovoce(string n, double c, string s, double v) : base(n, c, s)
        {
            vaha = v;
        }
    }
        
    class Drogerie : Zbozi
    {
        private string urceni;

        public Drogerie(string n, double c, string u) : base(n, c)
        {
            urceni = u;
        }

        public override string ToString()
        {
            return base.ToString() + $" (pro:{urceni})";
        }
    }
}