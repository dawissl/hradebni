namespace NakupniSeznam
{
    public partial class Form1 : Form
    {
        private Zbozi[] nakupniKosik = new Zbozi[10];
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Zbozi z;

            if(ComboType.Text == "Zboží")
            {
                z = new Zbozi(TxtName.Text, double.Parse(TxtPrice.Text));
            }

            if(ComboType.Text == "Potravina")
            {

            }

            if(ComboType.Text == "Drogerie")
            {

            }
            
            if(ComboType.Text == "")
            {
                MessageBox.Show("Vyberte typ zboží");
                return;
            }           
            
            if (index < 10)
            {
                nakupniKosik[index] = z;
                index++;
            }

            LblShop.Text = "";
            double vyslednaCena = 0;
            for (int i = 0; i < index; i++)
            {
                LblShop.Text += nakupniKosik[i].ToString() + Environment.NewLine;
                vyslednaCena += nakupniKosik[i].Cena;
            }
            LblPrice.Text = $"{vyslednaCena} Kè";
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
            //$ = alt + 36
            return $"{nazev} - {cena},- Kè";
        }
    }
}