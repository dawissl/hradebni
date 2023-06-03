using System.Net.Http.Headers;

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
                    z = new Zbozi(TxtName.Text, TxtUnit.Text, double.Parse(TxtCount.Text));
                    break;
                case "POTRAVINY":
                    z = new Potraviny(TxtName.Text, TxtUnit.Text, double.Parse(TxtCount.Text),TxtExpiration.Text);
                    break;
                case "DROGERIE":
                    z = new Drogerie(TxtName.Text, TxtUnit.Text, double.Parse(TxtCount.Text), TxtRestriction.Text);
                    break;

            }

            sklad.Add(z);
            VypisSklad();
        }

        private void VypisSklad()
        {
            string skladVypis = "";
            foreach(Zbozi z in sklad)
            {
                skladVypis += $"{z}\n";
            }
            LblSklad.Text = skladVypis;
        }
    }
}