namespace NakupniKosik
{
    public partial class Form1 : Form
    {
        Kosik mujKosik = new Kosik();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Zbozi z = new Zbozi(TxtName.Text, double.Parse(TxtPrice.Text));
            mujKosik.pridejZbozi(z);
        }
    }
}