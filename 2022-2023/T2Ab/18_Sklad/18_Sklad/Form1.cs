namespace _18_Sklad
{
    public partial class Form1 : Form
    {
        private List<Zbozi> sklad = new List<Zbozi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Zbozi z = null;

            switch (ComboItem.Text)
            {
                case "ZBOŽÍ":
                    z = new Zbozi(TxtName.Text,TxtUnit.Text,double.Parse(TxtCount.Text));
                    break;
                case "POTRAVINA":
                    z = new Potravina(TxtName.Text, TxtUnit.Text, double.Parse(TxtCount.Text),TxtExpiration.Text);
                    break;
                case "DROGERIE":
                    z = new Drogerie(TxtName.Text, TxtUnit.Text, double.Parse(TxtCount.Text), TxtRestriction.Text);
                    break;
            }
            // TODO vyhledat zaznam



            if (z != null) sklad.Add(z);
            VypisSklad();

        }

        private void VypisSklad()
        {
            string vypisSkladu = "";
            foreach(Zbozi z in sklad)
            {
                vypisSkladu += $"{z}\n";
            }
            LblSklad.Text = vypisSkladu;
        }
    }
}