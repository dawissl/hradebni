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
            // ziskani cisla od uživatele
            int cislo = int.Parse(TxtCislo.Text);
            // instance Random pro generování èísel
            Random generator = new Random();
            // retezcova promenna pro vytvareni vystupu
            string vystup = "";

            while (generator.Next(1, 21) != cislo)
            {
                // += nahrazuje synataxi vystup = vystup + "novy text"
                // promenna Environment.NewLine vkládá odsazení
                // nového øádku v závislosti na OS
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            // po vyrobení vystupu jej vložíme do pøíslusne komponenty
            LblVypis.Text = vystup;

        }

        private void BtnForCycle_Click(object sender, EventArgs e)
        {

            // ziskani cisla od uživatele
            int cislo = int.Parse(TxtCislo.Text);
            // retezcova promenna pro vytvareni vystupu
            string vystup = "";
           
            for (int i = 0; i < cislo; i++)
            {
                // += nahrazuje synataxi vystup = vystup + "novy text"
                // promenna Environment.NewLine vkládá odsazení
                // nového øádku v závislosti na OS
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }

            // po vyrobení vystupu jej vložíme do pøíslusne komponenty
            LblVypis.Text = vystup;
        }
    }
}