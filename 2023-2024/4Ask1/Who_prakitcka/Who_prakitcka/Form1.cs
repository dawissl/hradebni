using System.Web;

namespace Who_prakitcka
{
    public partial class Form1 : Form
    {
        private List<Pricina> seznamPricin = new List<Pricina>();
        private int deti;
        private int dospeli;
        private int duchodci;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inkrement v�kov� kategorie na z�klad� vstupn� hodnoty v�ku pacienta
        /// </summary>
        /// <param name="vek"> v�k pacienta</param>
        public void RozhodniVekovouKategorii(int vek)
        {
            if (vek < 18) deti++;
            if (vek >= 18 && vek < 65) dospeli++;
            if (vek >= 65) duchodci++;
        }

        /// <summary>
        /// Aktualizace seznamu p�i�in v�etn� mo�n�ho p�id�n� pokud v seznamu je�t� nen�
        /// </summary>
        /// <param name="pricina">n�zev p���iny</param>
        public void AktualizaceSeznamuPricin(string pricina)
        {
            bool existujiciPricina = false;

            foreach (Pricina p in seznamPricin)
            {
                if (p.Onemocneni == pricina.ToUpper())
                {
                    existujiciPricina = true;
                    p.PocetVyskytu = 1;
                    break;
                }
            }
            // v pripade nenalezen� p���iny vkl�d�me novou
            if (!existujiciPricina)
            {
                seznamPricin.Add(new Pricina(pricina));
            }
        }

        /// <summary>
        /// Z�sk�n� indexu v seznamu, na kter�m se nach�z� p���ina s nej�ast�j��m v�skytem
        /// </summary>
        /// <returns> index v listu</returns>
        public int IndexNejcastejsiPriciny()
        {
            int index = 0;
            int vyskyty = seznamPricin[index].PocetVyskytu;
            for (int i = 1; i < seznamPricin.Count; i++)
            {
                if (seznamPricin[i].PocetVyskytu > vyskyty)
                {
                    index = i;
                    vyskyty = seznamPricin[i].PocetVyskytu;
                }
            }
            return index;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            RozhodniVekovouKategorii((int)NumVek.Value);
            AktualizaceSeznamuPricin(TxtPricina.Text);

            //vypsani dat to vystupniho textboxu
            string vystup = $"{seznamPricin[IndexNejcastejsiPriciny()].Onemocneni}" +
                $" {(double)seznamPricin[IndexNejcastejsiPriciny()].PocetVyskytu * 100 / PocetPacientu()}" +
                $" {Environment.NewLine}";
            int pocetPacientu = deti + dospeli + duchodci;
            vystup += $"D�ti:{(double)deti * 100 / pocetPacientu}{Environment.NewLine}" +
                $"Dosp�l�:{(double)dospeli * 100 / pocetPacientu}{Environment.NewLine}" +
                $"Duchodci:{(double)duchodci * 100 / pocetPacientu}{Environment.NewLine}";

            TxtVystup.Text = vystup;
        }

        /// <summary>
        /// Zisk�ni po�tu v�ech pacient� vlo�en�ch do datab�ze
        /// </summary>
        /// <returns>po�et pacient�</returns>
        private int PocetPacientu()
        {
            int suma = 0;
            foreach(Pricina p in seznamPricin)
            {
                suma += p.PocetVyskytu;
            }
            return suma;
        }
    }
}