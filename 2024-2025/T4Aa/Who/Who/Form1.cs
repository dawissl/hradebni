namespace Who
{
    public partial class Form1 : Form
    {
        private int deti, dospeli, duchodci;
        private List<Pricina> priciny = new List<Pricina>();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Zjištìní nejhorší pøíèiny v kolekci pøíèin
        /// </summary>
        /// <returns>Pøíèinu z nejvyšším poètem pacientù</returns>
        /// <exception cref="Exception">výjimka pøi prázndé kolekci</exception>
        private Pricina NejhorsiPricina()
        {
            if (priciny.Count > 0)
            {
                Pricina p = priciny[0];
                for (int i = 1; i < priciny.Count; i++)
                {
                    if (priciny[i].Count > p.Count)
                    {
                        p = priciny[i];
                    }
                }
                return p;
            }
            else
            {
                throw new Exception("Seznam pøíèin je prázdný");
            }
        }

        private void BtnAddPacient_Click(object sender, EventArgs e)
        {
            UpdateAges(NumAge.Value);
            UpdateCauses(TxtPricina.Text.ToUpper());
            LblWorst.Text = $"{NejhorsiPricina()}";
            int celkovyPoce = deti + dospeli + duchodci;
            LblPacients.Text = $"Dìti: {(double)deti / celkovyPoce * 100:F2} %, " +
                $"Dospìlí: {(double)dospeli / celkovyPoce * 100:F2} %, " +
                $"Dùchodci: {(double)duchodci / celkovyPoce * 100:F2} %, ";


        }
        /// <summary>
        /// V pøípadì nové pøíèiny založ novou, jinak pøidej pacienta
        /// </summary>
        /// <param name="pricina">název pøíèiny</param>
        private void UpdateCauses(string pricina)
        {
            bool found = false;
            foreach (Pricina p in priciny)
            {
                if (p.Name == pricina)
                {
                    found = true;
                    p.AddPacient();
                    break;
                }
            }
            if (!found)
            {
                priciny.Add(new Pricina(pricina));
            }
        }

        /// <summary>
        /// Aktualizace vìkových kategorii s novým pacientem
        /// </summary>
        /// <param name="value">vìk pacienta</param>
        private void UpdateAges(decimal value)
        {
            if (value >= 65) duchodci++;
            if (value < 65 && value >= 18) dospeli++;
            if (value < 18) deti++;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("export.txt"))
            {
                sw.WriteLine("Statistika pacientù");
                sw.WriteLine("-------------------");
                if (CheckPacient.Checked)
                {
                    sw.WriteLine("Vìkové zastoupení pacientù");
                    sw.WriteLine(LblPacients.Text);
                }
                if (CheckCause.Checked)
                {
                    sw.WriteLine("Nejèastìjší pøíèina:");
                    sw.WriteLine(LblWorst.Text);
                }
                sw.Close();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            /**
             * TODO
             * 1) otevøít soubor - absolutní cesta / OpenFileDialog
             * 2) postupné naèítání øádkù cyklem / naèíst vše do kolekce
             * 3) z naèteného øádku oddìlit informaci o vìku a pøíèinì
             * 4) využít hotové funkce pro aktualizaci
             * 5) zavøí souborový proud
             */
        }
    }
}