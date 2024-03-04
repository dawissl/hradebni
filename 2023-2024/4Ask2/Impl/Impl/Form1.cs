namespace Impl
{
    public partial class Form1 : Form
    {
        private List<Myrectangle> pulses = new List<Myrectangle>();
        private int pulseCounter;
        private int pulseWidth;

        public Form1()
        {
            InitializeComponent();
        }

        private int GenerateImpulse()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6) * 100;
        }

        private void AddPulseToList(int interval)
        {
            Rectangle r = new Rectangle(pulseCounter * pulseWidth,
                                        PanelPulses.Height - interval / 2,
                                        pulseWidth,
                                        interval / 2);
            pulses.Add(new Myrectangle(r));
        }

        private void PanelPulses_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Myrectangle rectangle in pulses)
            {
                SolidBrush rectBrush = new SolidBrush(rectangle.Clr);
                g.FillRectangle(rectBrush, rectangle.Rect);
            }
        }

        private void TimerGenPulses_Tick(object sender, EventArgs e)
        {
            if (pulseCounter < NumPulsCounter.Value)
            {
                AddPulseToList(TimerGenPulses.Interval);
                TimerGenPulses.Interval = GenerateImpulse();
                pulseCounter++;
                PanelPulses.Refresh();
            }
            else
            {
                TimerGenPulses.Stop();
                CropData();
                PanelPulses.Refresh();
            }
        }

        private void CropData()
        {
            double avg = 0;
            foreach (Myrectangle r in pulses)
            {
                avg += r.Rect.Height;
            }
            avg /= pulses.Count;

            if (avg > 120)
            {
                foreach (Myrectangle r in pulses)
                {
                    int newHeight = (int)(r.Rect.Height * 0.95);
                    int newY = PanelPulses.Height - newHeight;
                    Rectangle newRect = new Rectangle(r.Rect.X,newY,r.Rect.Width, newHeight);
                    r.Rect = newRect;
                }
                CropData();
            }
        }

        private void NumPulsCounter_ValueChanged(object sender, EventArgs e)
        {
            pulseCounter = 0;
            pulseWidth = (int)(PanelPulses.Width / NumPulsCounter.Value);
            pulses.Clear();
            TimerGenPulses.Start();
        }
    }
}