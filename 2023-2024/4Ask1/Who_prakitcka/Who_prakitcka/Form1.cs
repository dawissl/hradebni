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
                    //pokud jsme pricinu aktualizovali, vime �e nebude t�eba ji nov� p�idat
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

        /// <summary>
        /// Z�sk�n� pole N nej�ast�j��ch p���in onemocn�n�
        /// </summary>
        /// <param name="n">po�et nej�ast�j��ch p���in</param>
        /// <returns>pole s indexy, kde se nach�z� nej�ast�j�� v�skyty</returns>
        public int[] IndexyNejcastejsichPricin(int n)
        {
            //o�et�en�, pokud by byl list krat�� ne� po�adovan� po�et v�sledk�
            if (n > seznamPricin.Count) n = seznamPricin.Count;
            int[] result = new int[n];
            //vn�j�� cyklus, kter� opakujeme p�esn� podle po�tu po�adovan�ch maxim
            for(int i = 0; i < n; i++)
            {
                // v�b�r po��te�n�ho indexu a lok�ln�ho maxima
                // nechceme opakovan� vyb�rat index, kter� je ji� zahrnut ve v�sledku
                int index = 0;
                while (result.Contains(index))
                {
                    index++;
                }
                int vyskyty = seznamPricin[index].PocetVyskytu;
                //hled�n� lok�ln�ho maxima dle po�tu v�skyt�, p�eskakujeme ji� z�skan� indexy
                for (int j = 1; j < seznamPricin.Count; j++)
                {
                    if (seznamPricin[j].PocetVyskytu > vyskyty && !result.Contains(j))
                    {
                        index = j;
                        vyskyty = seznamPricin[j].PocetVyskytu;
                    }
                }
                //p�id�n� maxim�ln�ho indexu do n�vratov�ho pole
                result[i] = index;
            }

            return result;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            RozhodniVekovouKategorii((int)NumVek.Value);
            AktualizaceSeznamuPricin(TxtPricina.Text);
            TxtVystup.Text = Vypis(true, true);
        }

        /// <summary>
        /// Zjednodu�en� v�pis z prvn�ho inkrementu
        /// </summary>
        /// <returns></returns>
        private string Vypis()
        {
            string vystup = $"{seznamPricin[IndexNejcastejsiPriciny()].Onemocneni}" +
                $" {(double)seznamPricin[IndexNejcastejsiPriciny()].PocetVyskytu * 100 / PocetPacientu()}" +
                $" {Environment.NewLine}";
            int pocetPacientu = deti + dospeli + duchodci;
            vystup += $"D�ti:{(double)deti * 100 / pocetPacientu}{Environment.NewLine}" +
                $"Dosp�l�:{(double)dospeli * 100 / pocetPacientu}{Environment.NewLine}" +
                $"Duchodci:{(double)duchodci * 100 / pocetPacientu}{Environment.NewLine}";

            return vystup;
        }

        /// <summary>
        /// Vytvo�en� v�pisu dle po�adovan�ch informac� do reportu
        /// </summary>
        /// <param name="priciny">true pokud chceme zahrnout priciny<param>
        /// <param name="veky">true pokud chceme zahrnout vekove kategorie</param>
        /// <returns>report</returns>
        private string Vypis(bool priciny, bool veky)
        {
            string vystup = "";
            if (priciny)
            {
                //nejpre vypisujeme priciny s nejcastejsimi pricinami (3 nej�ast�j��)
                int[] indexy = IndexyNejcastejsichPricin(3);
                for(int i = 0; i < indexy.Length; i++)
                {
                    vystup += $"{seznamPricin[indexy[i]].Onemocneni}" +
                $" {Math.Round((double)seznamPricin[indexy[i]].PocetVyskytu * 100 / PocetPacientu(),2)}" +
                $" {Environment.NewLine}";
                }

                // ostatni priciny seskupime do jedn� kategorie s n�zvem ostatn�
                double sumaOstatnich = 0;
                for(int k = 0; k < seznamPricin.Count; k++)
                {
                    if (!indexy.Contains(k)) sumaOstatnich += seznamPricin[k].PocetVyskytu;
                }
                vystup += $"Ostatn�" +
                $" {Math.Round(sumaOstatnich * 100 / PocetPacientu(),2)}" +
                $" {Environment.NewLine}";
            }
            if (veky)
            {
                int pocetPacientu = deti + dospeli + duchodci;
                vystup += $"D�ti:{(double)deti * 100 / pocetPacientu}{Environment.NewLine}" +
                    $"Dosp�l�:{(double)dospeli * 100 / pocetPacientu}{Environment.NewLine}" +
                    $"Duchodci:{(double)duchodci * 100 / pocetPacientu}{Environment.NewLine}";

            }

            return vystup;
        }

        /// <summary>
        /// Zisk�ni po�tu v�ech pacient� vlo�en�ch do datab�ze
        /// </summary>
        /// <returns>po�et pacient�</returns>
        private int PocetPacientu()
        {
            int suma = 0;
            foreach (Pricina p in seznamPricin)
            {
                suma += p.PocetVyskytu;
            }
            return suma;
        }

        //Davkove na�ten� p�i�in a v�k� pacient�
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (OpenFileReports.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(OpenFileReports.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        //m��eme si dovolit rozd�len� pomoc� split, pokud je zn�m� form�t dat
                        string[] splitted = line.Split("-");
                        AktualizaceSeznamuPricin(splitted[0]);
                        RozhodniVekovouKategorii(int.Parse(splitted[1]));
                    }
                    reader.Close();
                }
                TxtVystup.Text = Vypis(true,true);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("report.txt"))
            {
                writer.Write(Vypis(CheckNemoci.Checked, CheckAges.Checked));
                writer.Close();
            }
            // duplicitn� zobrazit do textboxu
            TxtVystup.Text = Vypis(CheckNemoci.Checked, CheckAges.Checked);
        }
    }
}