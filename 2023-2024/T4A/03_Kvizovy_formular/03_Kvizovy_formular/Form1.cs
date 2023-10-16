namespace _03_Kvizovy_formular
{
    public partial class Form1 : Form
    {
        private int time = 10;
        private int progress;
        private bool[] progressB = new bool[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerQuiz_Tick(object sender, EventArgs e)
        {
            time--;
            LblTime.Text = $"Zbývající èas: {time} s";
            // | = alt + 124
            if (time == 0 || IsFilled())
            {
                TimerQuiz.Stop();
                TimerQuiz.Enabled = false;
                MessageBox.Show("konec testu");
                MessageBox.Show($"Vysledek testu: {ResolveTest()}/3");
            }

        }

        private int ResolveTest()
        {
            int result = 0;
            if (RadioQ1C.Checked) result++;
            if (RadioQ2A.Checked) result++;
            if (RadioQ3A.Checked) result++;

            return result;
        }

        private bool IsFilled()
        {
            //GroupQ1
            bool q1 = RadioQ1A.Checked || RadioQ1B.Checked || RadioQ1C.Checked;
            //GroupQ2
            bool q2 = RadioQ2A.Checked || RadioQ2B.Checked || RadioQ2C.Checked;
            bool q3 = RadioQ3A.Checked || RadioQ3B.Checked || RadioQ3C.Checked;
            // & = alt + 38
            return q1 && q2 & q3;
        }

        private void GroupQ1_Enter(object sender, EventArgs e)
        {

        }

        private void TimerProgress_Tick(object sender, EventArgs e)
        {
            progressB[0] = RadioQ1A.Checked || RadioQ1B.Checked || RadioQ1C.Checked;
            progressB[1] = RadioQ2A.Checked || RadioQ2B.Checked || RadioQ2C.Checked;
            progressB[2] = RadioQ3A.Checked || RadioQ3B.Checked || RadioQ3C.Checked;
            progress = 0;
            foreach (bool answer in progressB)
            {
                if (answer) progress++;
            }
            double val = ((double)progress / progressB.Length) * 100;
            ProgressFill.Value = (int)val;
        }
    }
}