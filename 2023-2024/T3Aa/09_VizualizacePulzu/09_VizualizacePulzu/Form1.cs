namespace _09_VizualizacePulzu
{
    public partial class Form1 : Form
    {

        private bool manualMode = false;
        //poèet vyslaných impulzù
        private int pulseCount = 0;
        private List<int> pulses = new List<int>();
        private Random rndPulse = new Random();
        //poèet oøezaní datové sady
        private int editCounter = 0;
        private int time;
        // vychozi paleta použita pro vykreslení impulzù
        Color[] defaultPalette = { Color.Aqua, Color.Azure, Color.Navy, Color.Blue, Color.BlueViolet
                                    ,Color.Red, Color.MediumVioletRed, Color.DarkRed, Color.PaleVioletRed, Color.OrangeRed
                                    ,Color.Salmon,Color.Yellow, Color.LightGoldenrodYellow,  Color.Brown, Color.SaddleBrown
                                    ,Color.Gray, Color.Green, Color.DarkSlateGray, Color.GreenYellow, Color.DarkOliveGreen};
        public Form1()
        {
            InitializeComponent();
            BtnPulse.Enabled = false;
        }

        private void zavøítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        /// <summary>
        /// Restartování aplikace do výchozího stavu
        /// </summary>
        private void Restart()
        {
            PulsGenerator.Enabled = false;
            manualMode = false;
            BtnPulse.Enabled = false;
            pulseCount = 0;
            ProgressPulse.Value = 0;
            PanelVisualise.Refresh();
            pulses = new List<int>();
            editCounter = 0;
            time = 100;
        }

        private void PanelVisualise_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //pokud nebyl pøidán impulz nevykreslujeme
            if (pulseCount == 0)
            {
                g.FillRectangle(Brushes.White, 0, 0, PanelVisualise.Width, PanelVisualise.Height);
                return;
            }
            //urèení šíøky sloupcù
            int impulseWidth = PanelVisualise.Width / (int)NumImpulseCount.Value;
            int startPositionX = 0;// pozice prvního sloupce
            for (int i = 0; i < pulses.Count; i++)
            {
                //výchozí pozice Y pro vykreslování ze spodu panelu
                int startPositionY = PanelVisualise.Height - pulses[i];
                //ziskani stetce z palety
                SolidBrush stetec = new SolidBrush(defaultPalette[i]);
                g.FillRectangle(stetec, startPositionX, startPositionY, impulseWidth, pulses[i]);
                startPositionX += impulseWidth; // po vykreslení se posuneme o šíøku vpravo
            }
        }

        private void PulsGenerator_Tick(object sender, EventArgs e)
        {
            //po každém impulus je náhodnì zvolena doba následujícího impulsu
            if (pulseCount != NumImpulseCount.Value)
            {
                // do seznamu je pøidána výška sloupce dle délky impulzu
                pulses.Add(PulsGenerator.Interval / 2);
                PulsGenerator.Interval = 100 * rndPulse.Next(1, 6);
                pulseCount++;
                ProgressPulse.Value = pulseCount;
                PanelVisualise.Refresh();

            }
            else
            {
                // po vykreslení všech impulzù zastavujeme bìh a upravujeme data
                EditPulses();
                PulsGenerator.Stop();
                PulsGenerator.Enabled = false;
                MessageBox.Show($"Done [Poèet úprav:{editCounter}]");
            }

        }
        /// <summary>
        /// Rekurzivní funkce, která snižuje hodnotu impulzù o 5% dokud není prùmìr pod 120px
        /// </summary>
        private void EditPulses()
        {
            double avg = pulses.Average();
            if (avg > 120)
            {
                for (int i = 0; i < pulses.Count; i++)
                {
                    pulses[i] = (int)(pulses[i] * 0.95); // snížení všech hodnot o 5 %
                }
                editCounter++;
                EditPulses();
            }
            else
            {
                // data vykreslujeme až v momentì vhodnosti dat
                PanelVisualise.Refresh();
            }
        }

        // Pulzy jsou generovány v momentì, kdy uživatel zadá poèet impulzù
        private void NumImpulseCount_ValueChanged(object sender, EventArgs e)
        {
            // validace vstupní hodnoty
            if (NumImpulseCount.Value < 10 || NumImpulseCount.Value > 20)
            {
                MessageBox.Show("Byla zadána hodnota mimo interval <10, 20>");
                return;
            }
            // v pøípadì manuálního režimu èekáme na další akci od uživatele
            if (!manualMode)
            {
                Restart();
                ProgressPulse.Maximum = (int)NumImpulseCount.Value;
                PulsGenerator.Start();
            }


        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("David Sládeèek školní rok 2023/2024");
        }

        private void nápovìdaProOvládáníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"V pravé èásti vyberte poèet impulzù{Environment.NewLine}" +
                $"Po zadání poètu impulzù zapoène generování impulsù.{Environment.NewLine}" +
                $"Po vygenerování všech impulzù dojde ke korekci dat");
        }

        private void manuálníRežimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
            manualMode = true;
            BtnPulse.Enabled = true;

        }

        // Vyvolání manuálního impulzu sledujeme èas mezi jednotlivými kliknutími na tlaèítko
        private void BtnPulse_Click(object sender, EventArgs e)
        {
            if (NumImpulseCount.Value < 10 || NumImpulseCount.Value > 20)
            {
                MessageBox.Show("Byla zadána hodnota mimo interval <10, 20>");
                return;
            }
            ManualPulseGenerator.Start();
            ProgressPulse.Maximum = (int)NumImpulseCount.Value;

            if (pulseCount != NumImpulseCount.Value)
            {
                // hodnotu dìlíme 20 pro drobnou korelaci dat
                pulses.Add(time / 20);
                pulseCount++;
                ProgressPulse.Value = pulseCount;
                PanelVisualise.Refresh();
                time = 0;
            }
            else
            {
                EditPulses();
                ManualPulseGenerator.Stop();
                ManualPulseGenerator.Enabled = false;
                MessageBox.Show($"Done [Poèet úprav:{editCounter}]");
            }

        }

        private void ManualPulseGenerator_Tick(object sender, EventArgs e)
        {
            time += 1000;
        }
    }
}