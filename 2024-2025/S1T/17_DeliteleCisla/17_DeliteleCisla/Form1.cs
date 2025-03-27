namespace _17_DeliteleCisla
{
    public partial class Form1 : Form
    {
        // kolekce pro ukl�d�n� d�litel� vstupn�ho ��sla
        List<int> delitele;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDelitele_Click(object sender, EventArgs e)
        {
            // vymaz�n� obsahu kolekce list z p�ede�l� ud�losti click
            delitele = new List<int>();
            LblDelitele.Text = string.Empty;
            // z�sk�n� ��sla z textboxu od u�ivatele
            try
            {
                int cislo = int.Parse(TxtCislo.Text);
                if (cislo <= 0)
                {
                    throw new ArgumentException();
                }
                // cyklus pro zji�t�n� v�ech d�litel� 
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
            // p�ede�l� cyklus za��n� od 2 a m��eme t�m odhalit
            // zda je na vstupu prvo��slo
            if (delitele.Count == 0)
            {
                LblDelitele.Text = "Zadan� ��slo je prvo��slo";
            }
            else
            {
                // vytvo�en� v�stupn�ho �et�zce pro v�pis d�litel�
                // zadan�ho ��sla
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
