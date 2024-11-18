namespace Who
{
    public partial class Form1 : Form
    {
        private int children, adult, senior;
        //0 child, 1 - adult, 2- senior
        private int[] ages = new int[3];
        // kolekce pro veškeré pøíèiny
        private List<Pricina> priciny = new List<Pricina>();
        public Form1()
        {
            InitializeComponent();
        }

        private Pricina TheWorstDisease()
        {
            Pricina theWorst;
            if (priciny.Count > 0)
            {
                theWorst = priciny[0];
                for (int i = 1; i < priciny.Count; i++)
                {
                    if (priciny[i].Count > theWorst.Count)
                        theWorst = priciny[i];
                }
                return theWorst;
            }
            else
            {
                throw new Exception("Disease count is empty");
            }

        }

        private void BtnAddPacient_Click(object sender, EventArgs e)
        {
            UpdateAges(NumAge.Value);
            UpdateCauses(TxtPricina.Text.ToUpper());
            LblWorst.Text = $"{TheWorstDisease()}";
            int pacients = children + senior + adult;
            // :F2 za výsledkem udává kolik desetinných míst zobrazit
            LblPacients.Text = $"Dìti: {((double)children / pacients) * 100:F2} %," +
                $"Dospìlí: {((double)adult / pacients) * 100:F2},% " +
                $"Dùchodci: {((double)senior / pacients) * 100:F2} %,";

        }
        /// <summary>
        /// Update list of causes, if exists, add patient else add new cause
        /// </summary>
        /// <param name="cause">name of cause</param>
        private void UpdateCauses(string cause)
        {
            bool found = false;
            foreach (Pricina p in priciny)
            {
                if (p.Name == cause)
                {
                    found = true;
                    p.AddPatient();
                    break;
                }
            }
            if (!found)
            {
                priciny.Add(new Pricina(cause));
            }
        }

        /// <summary>
        /// Aktualizace vekovych skupin pacientu
        /// </summary>
        /// <param name="value">vek noveho pacienta</param>
        private void UpdateAges(decimal value)
        {
            if (value >= 65)
            {
                ages[2]++;
                senior++;
            }
            if (value < 18)
            {
                ages[0]++;
                children++;
            }
            if (value >= 18 && value < 65)
            {
                ages[1]++;
                adult++;
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("export.txt"))
            {
                sw.WriteLine("Statistika pacientù");
                sw.WriteLine("---------------------------------");
                if (CheckPacient.Checked)
                {
                    sw.WriteLine("Vìkové kategorie:");
                    sw.WriteLine(LblPacients.Text);
                }
                if(CheckCause.Checked) {
                    sw.WriteLine("Nejèastìjší pøíèina:");
                    sw.WriteLine(LblWorst.Text);
                }
                sw.Close();
            }
        }
    }
}