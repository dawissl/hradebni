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
            int doubleNumber = number * 2;
            LblVystup.Text = $"{doubleNumber}";
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            BtnWork.BackColor = Color.Green;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            BtnWork.BackColor = Color.Red;
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            BtnWork.BackColor = Color.Blue;
        }
    }
}