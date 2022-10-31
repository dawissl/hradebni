namespace _04_VolebniVysledky
{
    public partial class Form1 : Form
    {
        private int voteForX;
        private int voteForY;
        private int voteForZ;
        // konstanta pro maximální velikost sloupce
        private const int MAX_SIZE = 600;
        public Form1()
        {
            InitializeComponent();
            voteForX = 0;
            voteForY = 0;
            voteForZ = 0;
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            if (RadioCandidateX.Checked) voteForX++;
            if (RadioCandidateY.Checked) voteForY++;
            if (RadioCandidateZ.Checked) voteForZ++;

            PanelResult.Refresh();
        }

        private void PanelResult_Paint(object sender, PaintEventArgs e)
        {
            // panel ma rozmer 400 x 500
            Graphics g = e.Graphics;
            double sum = voteForX + voteForY + voteForZ;
            if (sum == 0) return;
            // novy font pro psani textù
            Font f = new Font("Arial", 12);

            int size = (int)(MAX_SIZE * (voteForX / sum));

            // kandidat X
            g.FillRectangle(Brushes.Blue, 50, 500 - size, 50, size);
            //$ = alt + 36
            int percent = (int)Math.Round((voteForX / sum) * 100, 0);
            int textYPosition = 500 - size -20;
            g.DrawString($"{percent} %", f, Brushes.Black, new Point(57, textYPosition));

            //kandidat Y
            size = (int)(MAX_SIZE * (voteForY / sum));
            g.FillRectangle(Brushes.Red, 150, 500 - size, 50, size);
            textYPosition = 500 - size - 20;
            percent = (int)Math.Round((voteForY / sum) * 100, 0);
            g.DrawString($"{percent} %", f, Brushes.Black, new Point(157, textYPosition));

            // kandidat Z
            size = (int)(MAX_SIZE * (voteForZ / sum));
            g.FillRectangle(Brushes.Green, 250, 500 - size, 50, size);
            textYPosition = 500 - size - 20;
            percent = (int)Math.Round((voteForZ / sum) * 100, 0);
            g.DrawString($"{percent} %", f, Brushes.Black, new Point(257, textYPosition));
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int candidate = random.Next(1, 4);
            if (candidate == 1) voteForX++;
            if (candidate == 2) voteForY++;
            if (candidate == 3) voteForZ++;
            PanelResult.Refresh();
        }
    }
}