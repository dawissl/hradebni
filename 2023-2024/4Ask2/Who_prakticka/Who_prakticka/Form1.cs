using System.Reflection;

namespace Who_prakticka
{
    public partial class Form1 : Form
    {
        private List<Pricina> seznamPrincin = new List<Pricina>();
        private int deti, dospeli, duchodci;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aktualizace vekovych katergorii pacient� na z�klad� v�ku nov�ho pacienta
        /// </summary>
        /// <param name="vek">vek pacienta</param>
        public void PriradPacientaDoKategorie(int vek)
        {
            if (vek < 18) deti++;
            if (vek >= 18 && vek < 65) dospeli++;
            if (vek >= 65) duchodci++;
        }

        /// <summary>
        /// Aktualizace seznamu, p�id� nov� onemocn�n�, pokud je�t� nen� v seznamu
        /// </summary>
        /// <param name="onemonceni">n�zev onemocn�n�</param>
        public void AktualizaceSeznamuPricin(string onemonceni)
        {
            bool noveOnemocneni = true;
            foreach (Pricina p in seznamPrincin)
            {
                //pokud je ji� v seznamu dane onemocn�ni akutalizujeme po�et pacient�
                if (onemonceni.ToUpper() == p.Onemocneni)
                {
                    noveOnemocneni = false;
                    p.PocetVyskytu = 1;
                    break;
                }
            }
            // pokud nedo�lo k atualizaci n�kter� z p�i�in je t�eba p�i�inu vlo�it jako novou
            if (noveOnemocneni)
            {
                seznamPrincin.Add(new Pricina(onemonceni));
            }
        }

        /// <summary>
        /// Pozice p�i�iny s nej�ast�j��m vyskytem
        /// </summary>
        /// <returns>index v listu s nej�ast�j��m vyskytem</returns>
        public int IndexNejcastejsiPriciny()
        {
            int index = 0;
            int max = seznamPrincin[index].PocetVyskytu;

            for (int i = 1; i < seznamPrincin.Count; i++)
            {
                if (seznamPrincin[i].PocetVyskytu > max)
                {
                    max = seznamPrincin[i].PocetVyskytu;
                    index = i;
                }
            }
            return index;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PriradPacientaDoKategorie((int)NumVek.Value);
            AktualizaceSeznamuPricin(TxtPricina.Text);
            TxtVystup.Text = VypisInfo(true, true);
        }

        /// <summary>
        /// Ziskani formatovaneho retezce s informacemi o onemocneni a vekov�ch kategorii
        /// 
        /// </summary>
        /// <param name="nemoc">do vypisu je zahrnuta informace o nemocich</param>
        /// <param name="vek">do vypisu je zahrnuta infomrace o vekovych kategoriich</param>
        /// <returns>formatovany vypis</returns>
        private string VypisInfo(bool nemoc, bool vek)
        {
            string vystup = "";
            if (nemoc)
            {
                vystup += $"{seznamPrincin[IndexNejcastejsiPriciny()].Onemocneni}" +
                $" {(double)seznamPrincin[IndexNejcastejsiPriciny()].PocetVyskytu * 100 / PocetPacientu()}" +
                $"%{Environment.NewLine}";
            }
            if (vek)
            {
                int sumaPacientu = deti + dospeli + duchodci;
                vystup += $"D�ti: {(double)deti * 100 / sumaPacientu} %{Environment.NewLine}";
                vystup += $"Dosp�l�: {(double)dospeli * 100 / sumaPacientu} %{Environment.NewLine}";
                vystup += $"D�chodci: {(double)duchodci * 100 / sumaPacientu} %{Environment.NewLine}";

            }
            return vystup;
        }

        /// <summary>
        /// Ziskani poctu pacientu v datov�m souboru
        /// </summary>
        /// <returns>po�et pacient�</returns>
        public int PocetPacientu()
        {
            int suma = 0;
            foreach (Pricina p in seznamPrincin)
            {
                suma += p.PocetVyskytu;
            }
            return suma;
        }

        
        private void BtnFile_Click(object sender, EventArgs e)
        {
            // vypsani do souboru nemoci.txt
            using (StreamWriter writer = new StreamWriter("nemoci.txt"))
            {
                writer.WriteLine(VypisInfo(CheckPriciny.Checked, CheckVeky.Checked));
                writer.Close();
            }
        }
    }
}