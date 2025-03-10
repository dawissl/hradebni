namespace _14_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHi_Click(object sender, EventArgs e)
        {
            TxtVstup.Text = "Ahoj";
            BackColor = Color.Pink;
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(TxtVstup.Text);
            LblVystup.Text = $"{cislo * 10}";
            LblVystup.BackColor = Color.Teal;
        }
    }
}