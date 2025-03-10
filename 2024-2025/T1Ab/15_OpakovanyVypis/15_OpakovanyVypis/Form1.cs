namespace _15_OpakovanyVypis
{
    public partial class Form1 : Form
    {
        // deklarace promennych pro vstup
        string vystup = "";
        int cislo;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWhileCycle_Click(object sender, EventArgs e)
        {
            vystup = "";
            // ziskaní èísla od uživatele
            cislo = int.Parse(TxtCislo.Text);
            // generator náhodných èísel
            Random generator = new Random();

            while (generator.Next(1, 21) != cislo)
            {
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            LblVypis.Text = vystup;
        }

        private void BtnForCycle_Click(object sender, EventArgs e)
        {
            // smazání dosavadního textu vypsaného na výstup
            vystup = "";
            // ziskaní èísla od uživatele
            cislo = int.Parse(TxtCislo.Text);
            for (int i = 0; i < cislo; i++)
            {
                // += je zkrácením vystup = vystup + text
                // operator + u øetezcù umožnuje jejich spojeni
                // promenna Environment.NewLine vkládá odsazení
                // na novy øadek v závislosti na typu OS
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            LblVypis.Text = vystup;
        }
    }
}