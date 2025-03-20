namespace _17_DeliteleCisla
{
    public partial class Form1 : Form
    {
        // delarace kolekce list, reprezentujici seznam dìlitelù
        private List<int> delitele;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDelitele_Click(object sender, EventArgs e)
        {
            // inicializace nového prázdného listu
            delitele = new List<int>();
            try
            {
                // ziskání èísla od uživatele
                int cislo = int.Parse(TxtCislo.Text);

                // vyzkoušení všech èísel do poloviny hodnoty, zda jsou dìlitelem
                for (int i = 1; i <= cislo / 2; i++)
                {
                    // pokud je èíslo dìlitelem, pøidáme jej do seznamu
                    if (cislo % i == 0) delitele.Add(i);
                }
                // vypsání dìlitelù na vystup s využitím foreach cyklu
                string vystup = "";
                foreach (int delitel in delitele)
                {
                    vystup += $"{delitel} ";
                }
                LblDelitele.ForeColor = Color.Black;
                LblDelitele.Text = vystup;
            }
            catch (FormatException ex)
            {
                LblDelitele.ForeColor = Color.Red;
                LblDelitele.Text = "Nebylo zadáno èíslo";
            }
            catch(DivideByZeroException ex)
            {
                LblDelitele.ForeColor = Color.Red;
                LblDelitele.Text = "Pokus o dìlení nulou";
            }

        }
    }
}