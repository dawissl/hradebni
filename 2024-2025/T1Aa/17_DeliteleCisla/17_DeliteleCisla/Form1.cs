namespace _17_DeliteleCisla
{
    public partial class Form1 : Form
    {
        // deklarace kolekce list pro ukladani d�litel�
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
                // ziskani ��sla, pro kter� hled�me d�litele
                int cislo = int.Parse(TxtCislo.Text);
                // projdeme v�echny potecionaln� d�litele pomoci cyklu
                for (int i = 1; i <= cislo / 2; i++)
                {
                    // pokud je ��slo d�litelem, p�id�me jej do kolekce
                    if (cislo % i == 0)
                        delitele.Add(i);
                }
                // vytvo�en� stringov�ho v�stupu pomoc� foreach
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
                LblDelitele.Text = "Nebylo zad�no ��slo";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}