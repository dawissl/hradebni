namespace Pulses
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> pulses = new List<MyRectangle>();
        private int pulseCounter;
        private int pulseWidth;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumPulseCount_ValueChanged(object sender, EventArgs e)
        {
            pulseCounter = 0;
            pulses.Clear();
            pulseWidth = (int)(PanelPulses.Width / NumPulseCount.Value);
            TimerPulseGenerator.Start();
        }

        private void TimerPulseGenerator_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (pulseCounter < NumPulseCount.Value)
            {
                AddPulseToList(TimerPulseGenerator.Interval);
                TimerPulseGenerator.Interval = rnd.Next(1, 6) * 100;
                PanelPulses.Refresh();
                pulseCounter++;
            }
            else
            {
                TimerPulseGenerator.Stop();
                MessageBox.Show("Vše vygenerováno");
            }

        }

        private void AddPulseToList(int interval)
        {
            Rectangle r = new Rectangle(pulseCounter * pulseWidth,
                                        PanelPulses.Height - interval / 2,
                                        pulseWidth,
                                        interval / 2);
            pulses.Add(new MyRectangle(r));
        }

        private void PanelPulses_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach(MyRectangle r in pulses)
            {
                SolidBrush rectBrush = new SolidBrush(r.Clr);
                graphics.FillRectangle(rectBrush, r.Rect);
            }
        }
    }
}