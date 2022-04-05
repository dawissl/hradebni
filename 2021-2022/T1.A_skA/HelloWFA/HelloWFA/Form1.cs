namespace HelloWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            int number = int.Parse(TxtVstup.Text);
            number *= 2;
            //MessageBox.Show($"{number}");
            LblVystup.Text = $"{number}";
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            BtnWork.ForeColor = Color.Blue;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            BtnWork.ForeColor = Color.Red;
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            BtnWork.ForeColor = Color.Green;
        }
    }
}