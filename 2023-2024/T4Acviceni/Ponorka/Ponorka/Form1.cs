namespace Ponorka
{
    public partial class Form1 : Form
    {
        private Analyzer submarineAnalyzer;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateData_Click(object sender, EventArgs e)
        {
            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                new FileGenerator(SFDialog.FileName, 0, 100);

            }
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                submarineAnalyzer = new Analyzer(OFDialog.FileName);
                TxtData.Text = submarineAnalyzer.ToString();
            }
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            if (submarineAnalyzer != null)
            {
               LblResult.Text = submarineAnalyzer.AnalyzeData((int)NumStart.Value, (int)NumEnd.Value);
            }
            else
            {
                LblResult.Text = "Missing datafile";
            }
        }
    }

    public struct Record
    {
        public int Time { get; init; }
        public double Depth { get; init; }

        public Record(int t, double d)
        {
            Time = t;
            Depth = d;
        }

        public override string ToString()
        {
            return $"{Time}, {Depth}";
        }
    }
}