namespace _15_OpakovanyVypis
{
    public partial class Form1 : Form
    {
        int cislo;
        string vystup = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWhileCycle_Click(object sender, EventArgs e)
        {
            // vymazani vystupu nahrazenim za prazdny text
            vystup = "";
            // ziskani èísla od uživatele
            cislo = int.Parse(TxtCislo.Text);
            // instance generatoru nahodnych cisel
            Random generator = new Random();
            while (generator.Next(1, 21) != cislo)
            {
                // konstanta Environment.NewLine vloží odsazeni
                // na novy radek v zavislosti na zvolenem OS
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            LblVypis.Text = vystup;

        }

        private void BtnForCycle_Click(object sender, EventArgs e)
        {
            // vymazani vystupu nahrazenim za prazdny text
            vystup = "";
            // ziskani èísla od uživatele
            cislo = int.Parse(TxtCislo.Text);
            for (int i = 0; i < cislo; i++)
            {
                vystup += $"{TxtText.Text}{Environment.NewLine}";
            }
            LblVypis.Text = vystup;
        }
    }
}