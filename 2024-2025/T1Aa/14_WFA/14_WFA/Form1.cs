namespace _14_WFA
{
    public partial class Form1 : Form
    {
        int pocitadlo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            TxtVstup.Text = "Ahoj";
            BackColor = Color.GreenYellow;
        }

        private void BtnSecond_Click(object sender, EventArgs e)
        {
            LblVystup.Text = TxtVstup.Text;
        }

        private void BtnThird_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            LblVystup.Text = $"{pocitadlo}";
        }
    }
}