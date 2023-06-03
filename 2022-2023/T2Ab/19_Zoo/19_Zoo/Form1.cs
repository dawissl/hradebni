namespace _19_Zoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zvire z = new Zvire("Karel", 20, 100);
            Vlk v = new Vlk("Akela", 15, 80,"alfa");
            Slon s = new Slon("Ludvik", 30, 40, "indicky");

            Zvire[] zoo = new Zvire[3];
            zoo[0] = z;
            zoo[1] = v;
            zoo[2] = s;

            s.Doktor();
            s.Zdravi = 50;

            // v.Doktor();

            // MessageBox.Show(v.Vyti());

            z.BFF(v);
            z.BFF(s);

            MessageBox.Show(z.VypisKamarady());
            MessageBox.Show(v.VypisKamarady());
            MessageBox.Show(s.VypisKamarady());


        }
    }
}