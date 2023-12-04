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
        /// Aktualizace vekovych katergorii pacientù na základì vìku nového pacienta
        /// </summary>
        /// <param name="vek">vek pacienta</param>
        public void PriradPacientaDoKategorie(int vek)
        {
            if (vek < 18) deti++;
            if (vek >= 18 && vek < 65) dospeli++;
            if (vek >= 65) duchodci++;
        }

        /// <summary>
        /// Aktualizace seznamu, pøidá nové onemocnìní, pokud ještì není v seznamu
        /// </summary>
        /// <param name="onemonceni">název onemocnìní</param>
        public void AktualizaceSeznamuPricin(string onemonceni)
        {
            bool noveOnemocneni = true;
            foreach (Pricina p in seznamPrincin)
            {
                //pokud je již v seznamu dane onemocnìni akutalizujeme poèet pacientù
                if (onemonceni.ToUpper() == p.Onemocneni)
                {
                    noveOnemocneni = false;
                    p.PocetVyskytu = 1;
                    break;
                }
            }
            // pokud nedošlo k atualizaci nìkteré z pøièin je tøeba pøièinu vložit jako novou
            if (noveOnemocneni)
            {
                seznamPrincin.Add(new Pricina(onemonceni));
            }
        }

        /// <summary>
        /// Pozice pøièiny s nejèastìjším vyskytem
        /// </summary>
        /// <returns>index v listu s nejèastìjším vyskytem</returns>
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

        public int[] IndexyNejcastejsichPricin(int n)
        {
            if (n > seznamPrincin.Count) n = seznamPrincin.Count;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int index = 0;
                while (result.Contains(index))
                {
                    index++;
                }
                int vyskyt = seznamPrincin[index].PocetVyskytu;

                for (int j = 1; j < seznamPrincin.Count; j++)
                {
                    if (seznamPrincin[j].PocetVyskytu > vyskyt && !result.Contains(j))
                    {
                        index = j;
                        vyskyt = seznamPrincin[j].PocetVyskytu;
                    }
                }
                result[i] = index;
            }

            return result;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PriradPacientaDoKategorie((int)NumVek.Value);
            AktualizaceSeznamuPricin(TxtPricina.Text);
            TxtVystup.Text = VypisInfo(true, true);
            panel1.Refresh();
        }

        /// <summary>
        /// Ziskani formatovaneho retezce s informacemi o onemocneni a vekových kategorii
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
                int[] indexy = IndexyNejcastejsichPricin(4);
                for (int i = 0; i < indexy.Length; i++)
                {
                    vystup += $"{seznamPrincin[indexy[i]].Onemocneni}" +
                              $" {Math.Round((double)seznamPrincin[indexy[i]].PocetVyskytu * 100 / PocetPacientu(), 3)}" +
                              $"%{Environment.NewLine}";
                }
                double soucetOstatnich = 0;
                for (int i = 0; i < seznamPrincin.Count; i++)
                {
                    if (!indexy.Contains(i)) soucetOstatnich += seznamPrincin[i].PocetVyskytu;
                }
                vystup += $"Ostatní " +
                              $" {Math.Round(soucetOstatnich * 100 / PocetPacientu(), 3)}" +
                              $"%{Environment.NewLine}";

            }
            if (vek)
            {
                int sumaPacientu = deti + dospeli + duchodci;
                vystup += $"Dìti: {(double)deti * 100 / sumaPacientu} %{Environment.NewLine}";
                vystup += $"Dospìlí: {(double)dospeli * 100 / sumaPacientu} %{Environment.NewLine}";
                vystup += $"Dùchodci: {(double)duchodci * 100 / sumaPacientu} %{Environment.NewLine}";

            }
            return vystup;
        }

        /// <summary>
        /// Ziskani poctu pacientu v datovém souboru
        /// </summary>
        /// <returns>poèet pacientù</returns>
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (FileDialogLoadPacients.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(FileDialogLoadPacients.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] splitted = reader.ReadLine().Split("-");
                        AktualizaceSeznamuPricin(splitted[0]);
                        PriradPacientaDoKategorie(int.Parse(splitted[1]));
                    }
                    reader.Close();
                }
                TxtVystup.Text = VypisInfo(true, true);
                panel1.Refresh();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            grf.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
            if (seznamPrincin.Count == 0)
            {
                return;
            }           

            //vekove kategorie
            double sumaPacientu = deti + dospeli + duchodci;
            int startAge = 0;
            grf.FillPie(Brushes.Yellow, 10, 10, 150, 150, startAge, (int)(360 * (deti / sumaPacientu)));
            startAge += (int)(360 * (deti / sumaPacientu));
            grf.FillPie(Brushes.Green, 10, 10, 150, 150, startAge, (int)(360 * (dospeli / sumaPacientu)));
            startAge += (int)(360 * (dospeli / sumaPacientu));
            grf.FillPie(Brushes.Pink, 10, 10, 150, 150, startAge, (int)(360 * (duchodci / sumaPacientu)));


            //priciny umrti
            int[] indexy = IndexyNejcastejsichPricin(4);
            double sumaVyskytu = 0;
            foreach (Pricina p in seznamPrincin)
            {
                sumaVyskytu += p.PocetVyskytu;
            }
            int startDisease = 0;
            SolidBrush[] stetce = { new SolidBrush(Color.Red), new SolidBrush(Color.Green),
             new SolidBrush(Color.Blue), new SolidBrush(Color.Magenta) };
            for (int i = 0; i < indexy.Length; i++)
            {
                grf.FillPie(stetce[i], 200, 10, 150, 150, startDisease, (int)(360 * (seznamPrincin[indexy[i]].PocetVyskytu / sumaVyskytu)));
                startDisease += (int)(360 * (seznamPrincin[indexy[i]].PocetVyskytu / sumaVyskytu));
            }
            double soucetOstatnich = 0;
            for (int i = 0; i < seznamPrincin.Count; i++)
            {
                if (!indexy.Contains(i)) soucetOstatnich += seznamPrincin[i].PocetVyskytu;

            }

            grf.FillPie(Brushes.Yellow, 200, 10, 150, 150, startDisease, (int)(360 * (soucetOstatnich / sumaVyskytu)));

        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zavøítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seznamPrincin = new List<Pricina>();
            deti = 0;
            dospeli = 0;
            duchodci = 0;
            TxtVystup.Text = "";
            panel1.Refresh();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cvièná praktická maturita - 2023");
        }
    }
}