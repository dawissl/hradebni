namespace ScreenSaver
{
    public partial class Form1 : Form
    {
        int time = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            TimerAnimation.Enabled = false;
            time = 5;
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Random rnd = new Random();

            graphics.DrawRectangle(Pens.Red, rnd.Next(0, 200), rnd.Next(0, 200), 50, 50);
        }

        private void TimerScreen_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 0)
            {
                TimerAnimation.Enabled = true;
            }
            else
            {
                TimerAnimation.Enabled = false;
            }
        }
    }
}