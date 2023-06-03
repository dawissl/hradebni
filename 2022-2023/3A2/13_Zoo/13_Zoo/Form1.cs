namespace _13_Zoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zvire zv = new Zvire("Karel", 14, 80);
            Krokodyl kr = new Krokodyl("Milam", 33, 76, 85600.20);
            Kapybara ka = new Kapybara("Tomáš", 7, 100);
            Zirafa zi = new Zirafa("Lída", 11, 99, 11.6);

            Zvire[] zoo = new Zvire[4];
            zoo[0] = zv;
            zoo[1] = kr;
            zoo[2] = ka;
            zoo[3] = zi;

            zoo[2].Jmeno = "Kamil";

            // vypsani zoo do MessageBoxu
            string tmp = "";
            for (int i = 0; i < zoo.Length; i++)
            {
                tmp += zoo[i].ToString() + Environment.NewLine;
            }
            MessageBox.Show(tmp);

            NavstevaVeterinare(zoo);

            tmp = "";
            for (int i = 0; i < zoo.Length; i++)
            {
                tmp += zoo[i].ToString() + Environment.NewLine;
            }
            MessageBox.Show(tmp);

            ka.BFF(zi);
            zv.BFF(zi);

            MessageBox.Show(ka.VypisKamaradu());
            MessageBox.Show(zv.VypisKamaradu());
            MessageBox.Show(zi.VypisKamaradu());

        }

        private void NavstevaVeterinare(Zvire[] zoo)
        {
            foreach (Zvire z in zoo)
            {
                if (z.Zdravi != 100) z.Doktor();
            }
        }
    }
}