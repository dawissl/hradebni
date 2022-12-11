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
            int procenta = int.Parse(TxtProcenta.Text);
            //| = alt + 124
            if (procenta >= 100 || procenta <= 0)
            {
                MessageBox.Show("neplatná hodnota!");
                return;

            }
            Obalka ob = new Obalka(procenta, TxtNote.Text);
            mojeKasicka.VlozitObalku(ob);

        }

        private void BtnAddMoney_Click(object sender, EventArgs e)
        {
            int money = int.Parse(TxtMoney.Text);
            if (money <= 0)
            {
                MessageBox.Show("neplatná hodnota!");
                return;
            }
            mojeKasicka.VlozitPenize(money);

            LblAmount.Text = $"{mojeKasicka.Money}";
            LblOut.Text = "";
            foreach (Obalka ob in mojeKasicka.ObalkaList)
            {
                LblOut.Text += $"{ob}{Environment.NewLine}";
            }
        }
    }
}