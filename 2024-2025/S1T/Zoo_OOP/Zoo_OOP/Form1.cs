namespace Zoo_OOP
{
    public partial class Form1 : Form
    {
        private Zvire mojeMileZviratko;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string n = TxtName.Text;
            int v = int.Parse(TxtVek.Text);
            double w = double.Parse(TxtVaha.Text);
            if (checkBox1.Checked)
            {
                // do promìnné typu Zvire lze vložit promìnnou datového
                // typu, který rozšiøuje pùvodní tøídu
                mojeMileZviratko = new Plaz(n, v, w, false);
            }
            else
            {
                // inicializace promenne typu Zvire pomocí konstruktoru
                mojeMileZviratko = new Zvire(n, v, w);
            }

            LblVystup.Text = mojeMileZviratko.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pokud není pomocí konstruktoru incializována promìnná
            // obsahuje hodnotu null
            if (mojeMileZviratko != null)
            {
                mojeMileZviratko.Promluv();
            }
            else
            {
                MessageBox.Show("Nevím o jaké zvíøe se jedná");
            }
        }
    }
}
