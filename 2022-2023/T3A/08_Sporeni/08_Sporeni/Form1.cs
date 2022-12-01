namespace _08_Sporeni
{
    public partial class Form1 : Form
    {
        private Kasicka mojeKasicka = new Kasicka();
        public Form1()
        {
            InitializeComponent();
            LblAmount.Text = $"{mojeKasicka.Money}";
        }

        private void BtnNewEnvelope_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddMoney_Click(object sender, EventArgs e)
        {

        }
    }
}