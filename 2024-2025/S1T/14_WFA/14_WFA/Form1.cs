namespace _14_WFA
{
    public partial class Form1 : Form
    {
        int cislo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TxtVstup.Text);
            LblOut.Text = $"{20 * num}";


        }

        private void BtnSecond_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

        }

        private void BtnFirst_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        public void Funkce()
        {

        }
    }
}