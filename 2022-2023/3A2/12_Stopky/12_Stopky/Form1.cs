namespace _12_Stopky
{
    public partial class Form1 : Form
    {
        private double time = 55000;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TimerStopWatch.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TimerStopWatch.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblStopky.Text = "00:00:0";
            time = 0;

        }

        private void TimerStopWatch_Tick(object sender, EventArgs e)
        {
            time += TimerStopWatch.Interval;

            int minuty = (int)time / 60000;
            int sekundy = ((int)time - 60000 * minuty) / 1000;
            int milisekundy = (int)time % 100;

            string minutyString = (minuty < 10) ? $"0{minuty}" : $"{minuty}";
            string sekundyString = (sekundy < 10) ? $"0{sekundy}" : $"{sekundy}";
            string miliSekundyString = (milisekundy < 10) ? $"0{milisekundy}" : $"{milisekundy}";


            LblStopky.Text = $"{minutyString}:{sekundyString}:{miliSekundyString}";
        }
    }
}