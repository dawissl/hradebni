namespace Animace
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerX_Tick(object sender, EventArgs e)
        {
            x++;
            MyPanel.Refresh();
        }

        private void TimerY_Tick(object sender, EventArgs e)
        {
            y++;
            MyPanel.Refresh();
        }

        private void BtnRunX_Click(object sender, EventArgs e)
        {
            TimerXVpravo.Enabled = true;
            TimerXVlevo.Enabled = false;
        }

        private void BtnRunY_Click(object sender, EventArgs e)
        {
            TimerYDolu.Enabled = true;
            TimerYNahoru.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
        }

        private void TimerXVlevo_Tick(object sender, EventArgs e)
        {
            x--;
            MyPanel.Refresh();
        }

        private void TimerYNahoru_Tick(object sender, EventArgs e)
        {
            y--;
            MyPanel.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerXVpravo.Enabled = false;
            TimerXVlevo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerYDolu.Enabled = false;
            TimerYNahoru.Enabled = true;
        }

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;

            grf.FillEllipse(Brushes.Red, x, y, 20, 20);
        }
    }
}