namespace _09_VizualizacePulzu
{
    public partial class Form1 : Form
    {

        private bool manualMode = false;
        //po�et vyslan�ch impulz�
        private int pulseCount = 0;
        private List<int> pulses = new List<int>();
        private Random rndPulse = new Random();
        //po�et o�ezan� datov� sady
        private int editCounter = 0;
        private int time;
        // vychozi paleta pou�ita pro vykreslen� impulz�
        Color[] defaultPalette = { Color.Aqua, Color.Azure, Color.Navy, Color.Blue, Color.BlueViolet
                                    ,Color.Red, Color.MediumVioletRed, Color.DarkRed, Color.PaleVioletRed, Color.OrangeRed
                                    ,Color.Salmon,Color.Yellow, Color.LightGoldenrodYellow,  Color.Brown, Color.SaddleBrown
                                    ,Color.Gray, Color.Green, Color.DarkSlateGray, Color.GreenYellow, Color.DarkOliveGreen};
        public Form1()
        {
            InitializeComponent();
            BtnPulse.Enabled = false;
        }

        private void zav��tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        /// <summary>
        /// Restartov�n� aplikace do v�choz�ho stavu
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
            //pokud nebyl p�id�n impulz nevykreslujeme
            if (pulseCount == 0)
            {
                g.FillRectangle(Brushes.White, 0, 0, PanelVisualise.Width, PanelVisualise.Height);
                return;
            }
            //ur�en� ���ky sloupc�
            int impulseWidth = PanelVisualise.Width / (int)NumImpulseCount.Value;
            int startPositionX = 0;// pozice prvn�ho sloupce
            for (int i = 0; i < pulses.Count; i++)
            {
                //v�choz� pozice Y pro vykreslov�n� ze spodu panelu
                int startPositionY = PanelVisualise.Height - pulses[i];
                //ziskani stetce z palety
                SolidBrush stetec = new SolidBrush(defaultPalette[i]);
                g.FillRectangle(stetec, startPositionX, startPositionY, impulseWidth, pulses[i]);
                startPositionX += impulseWidth; // po vykreslen� se posuneme o ���ku vpravo
            }
        }

        private void PulsGenerator_Tick(object sender, EventArgs e)
        {
            //po ka�d�m impulus je n�hodn� zvolena doba n�sleduj�c�ho impulsu
            if (pulseCount != NumImpulseCount.Value)
            {
                // do seznamu je p�id�na v��ka sloupce dle d�lky impulzu
                pulses.Add(PulsGenerator.Interval / 2);
                PulsGenerator.Interval = 100 * rndPulse.Next(1, 6);
                pulseCount++;
                ProgressPulse.Value = pulseCount;
                PanelVisualise.Refresh();

            }
            else
            {
                // po vykreslen� v�ech impulz� zastavujeme b�h a upravujeme data
                EditPulses();
                PulsGenerator.Stop();
                PulsGenerator.Enabled = false;
                MessageBox.Show($"Done [Po�et �prav:{editCounter}]");
            }

        }
        /// <summary>
        /// Rekurzivn� funkce, kter� sni�uje hodnotu impulz� o 5% dokud nen� pr�m�r pod 120px
        /// </summary>
        private void EditPulses()
        {
            double avg = pulses.Average();
            if (avg > 120)
            {
                for (int i = 0; i < pulses.Count; i++)
                {
                    pulses[i] = (int)(pulses[i] * 0.95); // sn�en� v�ech hodnot o 5 %
                }
                editCounter++;
                EditPulses();
            }
            else
            {
                // data vykreslujeme a� v moment� vhodnosti dat
                PanelVisualise.Refresh();
            }
        }

        // Pulzy jsou generov�ny v moment�, kdy u�ivatel zad� po�et impulz�
        private void NumImpulseCount_ValueChanged(object sender, EventArgs e)
        {
            // validace vstupn� hodnoty
            if (NumImpulseCount.Value < 10 || NumImpulseCount.Value > 20)
            {
                MessageBox.Show("Byla zad�na hodnota mimo interval <10, 20>");
                return;
            }
            // v p��pad� manu�ln�ho re�imu �ek�me na dal�� akci od u�ivatele
            if (!manualMode)
            {
                Restart();
                ProgressPulse.Maximum = (int)NumImpulseCount.Value;
                PulsGenerator.Start();
            }


        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("David Sl�de�ek �koln� rok 2023/2024");
        }

        private void n�pov�daProOvl�d�n�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"V prav� ��sti vyberte po�et impulz�{Environment.NewLine}" +
                $"Po zad�n� po�tu impulz� zapo�ne generov�n� impuls�.{Environment.NewLine}" +
                $"Po vygenerov�n� v�ech impulz� dojde ke korekci dat");
        }

        private void manu�ln�Re�imToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
            manualMode = true;
            BtnPulse.Enabled = true;

        }

        // Vyvol�n� manu�ln�ho impulzu sledujeme �as mezi jednotliv�mi kliknut�mi na tla��tko
        private void BtnPulse_Click(object sender, EventArgs e)
        {
            if (NumImpulseCount.Value < 10 || NumImpulseCount.Value > 20)
            {
                MessageBox.Show("Byla zad�na hodnota mimo interval <10, 20>");
                return;
            }
            ManualPulseGenerator.Start();
            ProgressPulse.Maximum = (int)NumImpulseCount.Value;

            if (pulseCount != NumImpulseCount.Value)
            {
                // hodnotu d�l�me 20 pro drobnou korelaci dat
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
                MessageBox.Show($"Done [Po�et �prav:{editCounter}]");
            }

        }

        private void ManualPulseGenerator_Tick(object sender, EventArgs e)
        {
            time += 1000;
        }
    }
}