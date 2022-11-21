namespace _04_ElektronickeVolby
{
    public partial class Form1 : Form
    {
        private int voteForX = 0;
        private int voteForY = 0;
        private int voteForZ = 0;
        private const int MAX_SIZE = 400;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            // TODO pøidat hlas kandidatovi + obnovit panel
            if (RadioCandX.Checked) voteForX++;
            if (RadioCandY.Checked) voteForY++;
            if (RadioCandZ.Checked) voteForZ++;

            PanelResult.Refresh();
        }

        private void PanelResult_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font myFont = new Font("Arial", 14);

            double sum = voteForX + voteForY + voteForZ;
            // kandidat X
            int rectangleSize = (int)(MAX_SIZE * (voteForX / sum));
            g.FillRectangle(Brushes.Blue,
                            50,
                            PanelResult.Height - rectangleSize,
                            50,
                            rectangleSize);

            g.DrawString($"{Math.Round((voteForX / sum) * 100, 0) } %",
                myFont,
                Brushes.Black,
                new PointF(55, PanelResult.Height - rectangleSize - 25));

            // kandidat Y
            rectangleSize = (int)(MAX_SIZE * (voteForY / sum));
            g.FillRectangle(Brushes.Red,
                            150,
                            PanelResult.Height - rectangleSize,
                            50,
                            rectangleSize);
            g.DrawString($"{Math.Round((voteForY / sum) * 100, 0) } %",
                myFont,
                Brushes.Black,
                new PointF(155, PanelResult.Height - rectangleSize - 25));
            // kandidat Z
            rectangleSize = (int)(MAX_SIZE * (voteForZ / sum));
            g.FillRectangle(Brushes.Green,
                            250,
                            PanelResult.Height - rectangleSize,
                            50,
                            rectangleSize);
            g.DrawString($"{Math.Round((voteForZ / sum) * 100, 0) } %",
                myFont,
                Brushes.Black,
                new PointF(255, PanelResult.Height - rectangleSize - 25));

        }

        private void BtnRandomVote_Click(object sender, EventArgs e)
        {
            TimerVoter.Enabled = !TimerVoter.Enabled;
        }

        private void TimerVoter_Tick(object sender, EventArgs e)
        {
            int random = new Random().Next(1, 4);
            if (random == 1) voteForX++;
            if (random == 2) voteForY++;
            if (random == 3) voteForZ++;
            PanelResult.Refresh();
        }
    }
}