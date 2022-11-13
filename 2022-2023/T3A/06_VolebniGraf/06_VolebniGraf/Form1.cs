namespace _06_VolebniGraf
{
    public partial class Form1 : Form
    {
        private int candidateX;
        private int candidateY;
        private int candidateZ;
        private const int MAX_SIZE = 500;

        public Form1()
        {
            InitializeComponent();
            candidateX = 0;
            candidateY = 0;
            candidateZ = 0;
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            if (RadCandidateX.Checked) candidateX++;
            if (RadCandidateY.Checked) candidateY++;
            if (RadCandidateZ.Checked) candidateZ++;

            PanelResult.Refresh();
        }

        private void PanelResult_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            double suma = candidateX + candidateY + candidateZ;
            if (suma == 0) return;


            // kandidat X
            int size = (int)( MAX_SIZE * (candidateX / suma));
            int locCand = MAX_SIZE - size;

            g.FillRectangle(Brushes.Blue, 50, locCand, 50, size);
            double perc = Math.Round((candidateX / suma) * 100,0);
            g.DrawString($"{perc} %",
                new Font("Arial", 14),
                Brushes.Black,
                new Point(55, locCand-20));
            // kandidat Y
            size = (int)(MAX_SIZE * (candidateY / suma));
            locCand = MAX_SIZE - size;
            g.FillRectangle(Brushes.Red, 150, locCand, 50, size);
            perc = Math.Round((candidateY / suma) * 100, 0);
            g.DrawString($"{perc} %",
                new Font("Arial", 14),
                Brushes.Black,
                new Point(155, locCand - 20));

            // kandidat Z
            size = (int)(MAX_SIZE * (candidateZ / suma));
            locCand = MAX_SIZE - size;
            g.FillRectangle(Brushes.Green, 250, locCand, 50, size);
            perc = Math.Round((candidateZ / suma) * 100, 0);
            g.DrawString($"{perc} %",
                new Font("Arial", 14),
                Brushes.Black,
                new Point(255, locCand - 20));
        }

        private void BtnRandomVote_Click(object sender, EventArgs e)
        {
            TimeToVote.Enabled = !TimeToVote.Enabled;
        }

        private void TimeToVote_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int vote = rnd.Next(1, 4);
            if (vote == 1) candidateX++;
            if (vote == 2) candidateY++;
            if (vote == 3) candidateZ++;
            PanelResult.Refresh();
        }
    }
}