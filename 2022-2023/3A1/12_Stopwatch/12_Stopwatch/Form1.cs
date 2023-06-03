namespace _12_Stopwatch
{
    public partial class Form1 : Form
    {
        private double timer = 50000;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TimerStopwatch.Enabled = true;

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TimerStopwatch.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            timer = 0;
            LblTime.Text = "0:00:00";
        }

        private void TimerStopwatch_Tick(object sender, EventArgs e)
        {
            timer += 15;
            int ms = (int)(timer % 1000);
            int s = ((int)timer - ms) / 1000;
            int m = s / 60;
            // aktualizace sekund
            s = s - (m * 60);
            // zobrazení dvouciferných hodnot minut
            string stringMinutes = (m < 10) ? $"0{m}" : $"{m}";

            // zobrazení dvouciferných hodnot sekund
            string stringSeconds = (s < 10) ? $"0{s}" : $"{s}";

            string stringMiliSeconds = (ms < 10) ? $"0{ms}" : $"{ms}";


            LblTime.Text = $"{stringMinutes}:{stringSeconds}:{stringMiliSeconds}";
            PanelWatch.Refresh();
        }

        private void PanelWatch_Paint(object sender, PaintEventArgs e)
        {
            int sX = PanelWatch.Width / 2;
            int sY = PanelWatch.Height / 2;

            int index = ((int)timer / 1000) % 12;
            Point[] body = {
                new Point(sX,sY -40),
                new Point(sX+10,sY -30),
                new Point(sX+20,sY -20),
                new Point(sX+30,sY -10),
                new Point(sX+40,sY),
                new Point(sX+30,sY +10),
                new Point(sX+20,sY +20),
                new Point(sX+10,sY +30),
                new Point(sX,sY +40),
                new Point(sX-10,sY +30),
                new Point(sX-20,sY +20),
                new Point(sX-30,sY +10)
            };

            e.Graphics.DrawLine(Pens.Red, new Point(sX, sY), body[index]);
        }
    }
}