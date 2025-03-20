namespace _17_DeliteleCisla
{
    public partial class Form1 : Form
    {
        // deklarace kolekce list pro ukladani dìlitelù
        private List<int> delitele;
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnDelitele_Click(object sender, EventArgs e)
        {
            try
            {
                // incializace prazdneho listu
                delitele = new List<int>();
                // ziskani èísla, pro které hledáme dìlitele
                int cislo = int.Parse(TxtCislo.Text);
                // projdeme všechny potecionalní dìlitele pomoci cyklu
                for (int i = 1; i <= cislo / 2; i++)
                {
                    // pokud je èíslo dìlitelem, pøidáme jej do kolekce
                    if (cislo % i == 0)
                        delitele.Add(i);
                }
                // vytvoøení stringového výstupu pomocí foreach
                string vystup = "";
                foreach (int num in delitele)
                {
                    vystup += $"{num} ";
                }
                LblDelitele.ForeColor = Color.Black;
                LblDelitele.Text = vystup;
            }
            catch (FormatException ex)
            {
                LblDelitele.ForeColor = Color.Red;
                LblDelitele.Text = "Nebylo zadáno èíslo";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}