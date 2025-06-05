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
                // do prom�nn� typu Zvire lze vlo�it prom�nnou datov�ho
                // typu, kter� roz�i�uje p�vodn� t��du
                mojeMileZviratko = new Plaz(n, v, w, false);
            }
            else
            {
                // inicializace promenne typu Zvire pomoc� konstruktoru
                mojeMileZviratko = new Zvire(n, v, w);
            }

            LblVystup.Text = mojeMileZviratko.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pokud nen� pomoc� konstruktoru incializov�na prom�nn�
            // obsahuje hodnotu null
            if (mojeMileZviratko != null)
            {
                mojeMileZviratko.Promluv();
            }
            else
            {
                MessageBox.Show("Nev�m o jak� zv��e se jedn�");
            }
        }
    }
}
