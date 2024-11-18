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
        /// Zji�t�n� nejhor�� p���iny v kolekci p���in
        /// </summary>
        /// <returns>P���inu z nejvy���m po�tem pacient�</returns>
        /// <exception cref="Exception">v�jimka p�i pr�znd� kolekci</exception>
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
                throw new Exception("Seznam p���in je pr�zdn�");
            }
        }

        private void BtnAddPacient_Click(object sender, EventArgs e)
        {
            UpdateAges(NumAge.Value);
            UpdateCauses(TxtPricina.Text.ToUpper());
            LblWorst.Text = $"{NejhorsiPricina()}";
            int celkovyPoce = deti + dospeli + duchodci;
            LblPacients.Text = $"D�ti: {(double)deti / celkovyPoce * 100:F2} %, " +
                $"Dosp�l�: {(double)dospeli / celkovyPoce * 100:F2} %, " +
                $"D�chodci: {(double)duchodci / celkovyPoce * 100:F2} %, ";


        }
        /// <summary>
        /// V p��pad� nov� p���iny zalo� novou, jinak p�idej pacienta
        /// </summary>
        /// <param name="pricina">n�zev p���iny</param>
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
        /// Aktualizace v�kov�ch kategorii s nov�m pacientem
        /// </summary>
        /// <param name="value">v�k pacienta</param>
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
                sw.WriteLine("Statistika pacient�");
                sw.WriteLine("-------------------");
                if (CheckPacient.Checked)
                {
                    sw.WriteLine("V�kov� zastoupen� pacient�");
                    sw.WriteLine(LblPacients.Text);
                }
                if (CheckCause.Checked)
                {
                    sw.WriteLine("Nej�ast�j�� p���ina:");
                    sw.WriteLine(LblWorst.Text);
                }
                sw.Close();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            /**
             * TODO
             * 1) otev��t soubor - absolutn� cesta / OpenFileDialog
             * 2) postupn� na��t�n� ��dk� cyklem / na��st v�e do kolekce
             * 3) z na�ten�ho ��dku odd�lit informaci o v�ku a p���in�
             * 4) vyu��t hotov� funkce pro aktualizaci
             * 5) zav�� souborov� proud
             */
        }
    }
}