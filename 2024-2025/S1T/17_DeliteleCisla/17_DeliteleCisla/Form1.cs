namespace _17_DeliteleCisla
{
    public partial class Form1 : Form
    {
        // kolekce pro ukládání dìlitelù vstupního èísla
        List<int> delitele;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDelitele_Click(object sender, EventArgs e)
        {
            // vymazání obsahu kolekce list z pøedešlé události click
            delitele = new List<int>();
            LblDelitele.Text = string.Empty;
            // získání èísla z textboxu od uživatele
            try
            {
                int cislo = int.Parse(TxtCislo.Text);
                if (cislo <= 0)
                {
                    throw new ArgumentException();
                }
                // cyklus pro zjištìní všech dìlitelù 
                for (int i = 2; i < cislo; i++)
                {
                    if (cislo % i == 0) delitele.Add(i);
                }
            }
            catch (FormatException ex)
            {
                LblDelitele.Text = $"{ex.Message}";
                return;
            }
            catch(ArgumentException ex)
            {
                LblDelitele.Text = $"{ex.Message}";
                return;
            }
            // pøedešlý cyklus zaèíná od 2 a mùžeme tím odhalit
            // zda je na vstupu prvoèíslo
            if (delitele.Count == 0)
            {
                LblDelitele.Text = "Zadané èíslo je prvoèíslo";
            }
            else
            {
                // vytvoøení výstupního øetìzce pro výpis dìlitelù
                // zadaného èísla
                string seznamDelitelu = string.Empty;
                foreach (int x in delitele)
                {
                    seznamDelitelu += $"{x} ";
                }
                LblDelitele.Text = seznamDelitelu;
            }
        }
    }
}
