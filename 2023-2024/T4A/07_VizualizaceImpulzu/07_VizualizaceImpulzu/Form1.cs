using System.DirectoryServices.ActiveDirectory;

namespace _07_VizualizaceImpulzu
{
    public partial class Form1 : Form
    {
        private int impulseCounter = 0;
        private List<MyRectangle> rectangles = new List<MyRectangle>();
        private int sirka;
        private int editCounter = 0;
        private int numPulses = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void GenPulseTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (impulseCounter < numPulses)
            {
                int vyska = 500;
                rectangles.Add(new MyRectangle(new Rectangle(impulseCounter * sirka, PanelPulses.Height - vyska, sirka, vyska)));
                TxtIntervals.Text += $"#{impulseCounter + 1} {GenPulseTimer.Interval}{Environment.NewLine}";
                impulseCounter++;
                GenPulseTimer.Interval = 1;
                PanelPulses.Refresh();
            }
            else
            {
                GenPulseTimer.Stop();
                EditDatas();
                PanelPulses.Refresh();
                MessageBox.Show($"Data byla zmenšena o {editCounter * 5}%");
            }

        }

        private void EditDatas()
        {
            double average = 0;
            foreach (MyRectangle rect in rectangles)
            {
                average += rect.Rect.Height;
            }
            average /= rectangles.Count;
            if (average > 120)
            {
                // TODO oøez dat
                foreach (MyRectangle rect in rectangles)
                {
                    int novaVyska = (int)(rect.Rect.Height * 0.95);
                    Rectangle newRect = new Rectangle(rect.Rect.X, PanelPulses.Height - novaVyska, rect.Rect.Width, novaVyska);
                    rect.Rect = newRect;
                }
                editCounter++;

                EditDatas();
            }
        }

        private void PanelPulses_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            foreach (MyRectangle rect in rectangles)
            {
                SolidBrush stetec = new SolidBrush(rect.RectColor);
                graphics.FillRectangle(stetec, rect.Rect);
            }
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            numPulses = (int)NumPulses.Value;
            sirka = PanelPulses.Width / numPulses;
            GenPulseTimer.Enabled = true;
            rectangles.Clear();
            impulseCounter = 0;
            TxtIntervals.Text = "";
            editCounter = 0;
        }
    }
}