namespace _15_OpakovanyVypis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWhileCycle_Click(object sender, EventArgs e)
        {
            // ziskani cisla od u�ivatele
            int cislo = int.Parse(TxtCislo.Text);
            // instance Random pro generov�n� ��sel
            Random generator = new Random();
            // retezcova promenna pro vytvareni vystupu
            string vystup = "";

            while (generator.Next(1, 21) != cislo)
            {
                // += nahrazuje synataxi vystup = vystup + "novy text"
                // promenna Environment.NewLine vkl�d� odsazen�
                // nov�ho ��dku v z�vislosti na OS
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            // po vyroben� vystupu jej vlo��me do p��slusne komponenty
            LblVypis.Text = vystup;

        }

        private void BtnForCycle_Click(object sender, EventArgs e)
        {

            // ziskani cisla od u�ivatele
            int cislo = int.Parse(TxtCislo.Text);
            // retezcova promenna pro vytvareni vystupu
            string vystup = "";
           
            for (int i = 0; i < cislo; i++)
            {
                // += nahrazuje synataxi vystup = vystup + "novy text"
                // promenna Environment.NewLine vkl�d� odsazen�
                // nov�ho ��dku v z�vislosti na OS
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }

            // po vyroben� vystupu jej vlo��me do p��slusne komponenty
            LblVypis.Text = vystup;
        }
    }
}