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
        /// Inkrement vìkové kategorie na základì vstupní hodnoty vìku pacienta
        /// </summary>
        /// <param name="vek"> vìk pacienta</param>
        public void RozhodniVekovouKategorii(int vek)
        {
            if (vek < 18) deti++;
            if (vek >= 18 && vek < 65) dospeli++;
            if (vek >= 65) duchodci++;
        }

        /// <summary>
        /// Aktualizace seznamu pøièin vèetnì možného pøidání pokud v seznamu ještì není
        /// </summary>
        /// <param name="pricina">název pøíèiny</param>
        public void AktualizaceSeznamuPricin(string pricina)
        {
            bool existujiciPricina = false;

            foreach (Pricina p in seznamPricin)
            {
                if (p.Onemocneni == pricina.ToUpper())
                {
                    //pokud jsme pricinu aktualizovali, vime že nebude tøeba ji novì pøidat
                    existujiciPricina = true;
                    p.PocetVyskytu = 1;
                    break;
                }
            }
            // v pripade nenalezení pøíèiny vkládáme novou
            if (!existujiciPricina)
            {
                seznamPricin.Add(new Pricina(pricina));
            }
        }

        /// <summary>
        /// Získání indexu v seznamu, na kterém se nachází pøíèina s nejèastìjším výskytem
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
        /// Získání pole N nejèastìjších pøíèin onemocnìní
        /// </summary>
        /// <param name="n">poèet nejèastìjších pøíèin</param>
        /// <returns>pole s indexy, kde se nachází nejèastìjší výskyty</returns>
        public int[] IndexyNejcastejsichPricin(int n)
        {
            //ošetøení, pokud by byl list kratší než požadovaný poèet výsledkù
            if (n > seznamPricin.Count) n = seznamPricin.Count;
            int[] result = new int[n];
            //vnìjší cyklus, který opakujeme pøesnì podle poètu požadovaných maxim
            for(int i = 0; i < n; i++)
            {
                // výbìr poèáteèního indexu a lokálního maxima
                // nechceme opakovanì vybírat index, který je již zahrnut ve výsledku
                int index = 0;
                while (result.Contains(index))
                {
                    index++;
                }
                int vyskyty = seznamPricin[index].PocetVyskytu;
                //hledání lokálního maxima dle poètu výskytù, pøeskakujeme již získané indexy
                for (int j = 1; j < seznamPricin.Count; j++)
                {
                    if (seznamPricin[j].PocetVyskytu > vyskyty && !result.Contains(j))
                    {
                        index = j;
                        vyskyty = seznamPricin[j].PocetVyskytu;
                    }
                }
                //pøidání maximálního indexu do návratového pole
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
        /// Zjednodušený výpis z prvního inkrementu
        /// </summary>
        /// <returns></returns>
        private string Vypis()
        {
            string vystup = $"{seznamPricin[IndexNejcastejsiPriciny()].Onemocneni}" +
                $" {(double)seznamPricin[IndexNejcastejsiPriciny()].PocetVyskytu * 100 / PocetPacientu()}" +
                $" {Environment.NewLine}";
            int pocetPacientu = deti + dospeli + duchodci;
            vystup += $"Dìti:{(double)deti * 100 / pocetPacientu}{Environment.NewLine}" +
                $"Dospìlí:{(double)dospeli * 100 / pocetPacientu}{Environment.NewLine}" +
                $"Duchodci:{(double)duchodci * 100 / pocetPacientu}{Environment.NewLine}";

            return vystup;
        }

        /// <summary>
        /// Vytvoøení výpisu dle požadovaných informací do reportu
        /// </summary>
        /// <param name="priciny">true pokud chceme zahrnout priciny<param>
        /// <param name="veky">true pokud chceme zahrnout vekove kategorie</param>
        /// <returns>report</returns>
        private string Vypis(bool priciny, bool veky)
        {
            string vystup = "";
            if (priciny)
            {
                //nejpre vypisujeme priciny s nejcastejsimi pricinami (3 nejèastìjší)
                int[] indexy = IndexyNejcastejsichPricin(3);
                for(int i = 0; i < indexy.Length; i++)
                {
                    vystup += $"{seznamPricin[indexy[i]].Onemocneni}" +
                $" {Math.Round((double)seznamPricin[indexy[i]].PocetVyskytu * 100 / PocetPacientu(),2)}" +
                $" {Environment.NewLine}";
                }

                // ostatni priciny seskupime do jedné kategorie s názvem ostatní
                double sumaOstatnich = 0;
                for(int k = 0; k < seznamPricin.Count; k++)
                {
                    if (!indexy.Contains(k)) sumaOstatnich += seznamPricin[k].PocetVyskytu;
                }
                vystup += $"Ostatní" +
                $" {Math.Round(sumaOstatnich * 100 / PocetPacientu(),2)}" +
                $" {Environment.NewLine}";
            }
            if (veky)
            {
                int pocetPacientu = deti + dospeli + duchodci;
                vystup += $"Dìti:{(double)deti * 100 / pocetPacientu}{Environment.NewLine}" +
                    $"Dospìlí:{(double)dospeli * 100 / pocetPacientu}{Environment.NewLine}" +
                    $"Duchodci:{(double)duchodci * 100 / pocetPacientu}{Environment.NewLine}";

            }

            return vystup;
        }

        /// <summary>
        /// Ziskáni poètu všech pacientù vložených do databáze
        /// </summary>
        /// <returns>poèet pacientù</returns>
        private int PocetPacientu()
        {
            int suma = 0;
            foreach (Pricina p in seznamPricin)
            {
                suma += p.PocetVyskytu;
            }
            return suma;
        }

        //Davkove naètení pøièin a vìkù pacientù
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (OpenFileReports.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(OpenFileReports.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        //mùžeme si dovolit rozdìlení pomocí split, pokud je známý formát dat
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
            // duplicitnì zobrazit do textboxu
            TxtVystup.Text = Vypis(CheckNemoci.Checked, CheckAges.Checked);
        }
    }
}