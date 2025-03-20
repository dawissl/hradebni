namespace _17_DeliteleCisla
{
    public partial class Form1 : Form
    {
        // delarace kolekce list, reprezentujici seznam d�litel�
        private List<int> delitele;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDelitele_Click(object sender, EventArgs e)
        {
            // inicializace nov�ho pr�zdn�ho listu
            delitele = new List<int>();
            try
            {
                // zisk�n� ��sla od u�ivatele
                int cislo = int.Parse(TxtCislo.Text);

                // vyzkou�en� v�ech ��sel do poloviny hodnoty, zda jsou d�litelem
                for (int i = 1; i <= cislo / 2; i++)
                {
                    // pokud je ��slo d�litelem, p�id�me jej do seznamu
                    if (cislo % i == 0) delitele.Add(i);
                }
                // vyps�n� d�litel� na vystup s vyu�it�m foreach cyklu
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
                LblDelitele.Text = "Nebylo zad�no ��slo";
            }
            catch(DivideByZeroException ex)
            {
                LblDelitele.ForeColor = Color.Red;
                LblDelitele.Text = "Pokus o d�len� nulou";
            }

        }
    }
}