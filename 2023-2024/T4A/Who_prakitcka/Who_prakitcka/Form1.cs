namespace Who_prakitcka
{
    public partial class Form1 : Form
    {
        private int deti, dospeli, duchodci;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Urèení vìkové kategorie s aktualizaci poètu pacientu v kategorii
        /// </summary>
        /// <param name="vek">vek pacienta</param>
        private void UrciVekovouKategorii(int vek)
        {
            if (vek < 18) deti++;
            if (vek >= 18 && vek < 65) dospeli++;
            if (vek >= 65) duchodci++;
        }

        private List<Pricina> seznamPricin = new List<Pricina>();

        private List<int> indexyNejcastejsichPricin;
        private int SumaPacientuMimoNejcastejiPriciny()
        {
            int suma = 0;
            for (int i = 0; i < seznamPricin.Count; i++)
            {
                if (!indexyNejcastejsichPricin.Contains(i))
                {
                    suma += seznamPricin[i].PocetVyskytu;
                }
            }
            return suma;
        }

        private void AktualizujSeznamPricin(string nemoc)
        {

            bool novePricina = true;

            foreach (Pricina p in seznamPricin)
            {
                if (p.Nazev == nemoc.ToUpper())
                {
                    p.PocetVyskytu = 1;
                    novePricina = false;
                    break;
                }
            }

            if (novePricina) seznamPricin.Add(new Pricina(nemoc));

        }

        private int IndexNejcastejsiPriciny()
        {
            int index = 0;
            int pocetVyskytu = seznamPricin[index].PocetVyskytu;

            for (int i = 1; i < seznamPricin.Count; i++)
            {
                if (seznamPricin[i].PocetVyskytu > pocetVyskytu)
                {
                    index = i;
                    pocetVyskytu = seznamPricin[index].PocetVyskytu;
                }
            }
            return index;

        }

        private void NejcastejiPriciny(int n)
        {
            indexyNejcastejsichPricin = new List<int>();
            if (n > seznamPricin.Count) n = seznamPricin.Count;
            for (int i = 0; i < n; i++)
            {
                int index = 0;
                for (int k = 0; k < seznamPricin.Count - 1; k++)
                {
                    if (!indexyNejcastejsichPricin.Contains(k))
                    {
                        index = k;
                        break;
                    }
                }
                int pocetVyskytu = seznamPricin[index].PocetVyskytu;

                for (int j = 1; j < seznamPricin.Count; j++)
                {
                    if (seznamPricin[j].PocetVyskytu > pocetVyskytu
                        && !indexyNejcastejsichPricin.Contains(j))
                    {
                        index = j;
                        pocetVyskytu = seznamPricin[index].PocetVyskytu;
                    }
                }
                indexyNejcastejsichPricin.Add(index);
            }
        }

        private void BtnManualAdd_Click(object sender, EventArgs e)
        {
            AktualizujSeznamPricin(TxtPricina.Text);
            UrciVekovouKategorii((int)NumVek.Value);
            TxtVystup.Text = VypisInfo(true,true);
        }

        private string VypisInfo()
        {
            string vystp = "";
            vystp += seznamPricin[IndexNejcastejsiPriciny()].ToString() + Environment.NewLine;
            vystp += $"Dìti - {deti}{Environment.NewLine}";
            vystp += $"Dospìlí - {dospeli}{Environment.NewLine}";
            vystp += $"Dùchodci - {duchodci}";
            return vystp;
        }

        private string VypisInfo(bool nemoci, bool vekoveKategorie)
        {
            string vystp = "";
            NejcastejiPriciny(2);
            if (nemoci)
            {
                foreach(int index in indexyNejcastejsichPricin)
                {
                    vystp += seznamPricin[index].ToString()
                + Environment.NewLine;
                }
                vystp +=$"Ostaní pøíèiny, poèet výskytù {SumaPacientuMimoNejcastejiPriciny()}"
                    +Environment.NewLine;

            }
            if (vekoveKategorie)
            {
                vystp += $"Dìti - {deti}{Environment.NewLine}";
                vystp += $"Dospìlí - {dospeli}{Environment.NewLine}";
                vystp += $"Dùchodci - {duchodci}";
            }
            return vystp;
        }



        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("vystup.txt"))
            {
                writer.Write(VypisInfo(CheckPriciny.Checked, CheckVeky.Checked));
                writer.Close();
            }
            // vypis vystupu pro kontrolu obsahu souboru
            TxtVystup.Text = VypisInfo(CheckPriciny.Checked, CheckVeky.Checked);

        }

        private void BtnAddFromFile_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(FileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] splited = line.Split("-");
                        AktualizujSeznamPricin(splited[0]);
                        UrciVekovouKategorii(int.Parse(splited[1]));
                    }
                    reader.Close();
                }
                TxtVystup.Text = VypisInfo(true,true);

            }
        }
    }
}