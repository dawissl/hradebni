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
            Zvire[] zoo = new Zvire[10];
            Zvire z = new Zvire("Kamil", 20, 80);
            Slon s = new Slon("Ludvik", 40, 100, 2700, 225);
            Zebra zb = new Zebra("Stripes", 7, 50, 27, 31);
            Gepard g = new Gepard("Milena", 3, 90, 300.7);

          //  MessageBox.Show(s.ToString());
           // MessageBox.Show(g.ToString());
            zoo[0] = g;
            zoo[1] = z;
            zoo[2] = zb;
            zoo[3] = s;

            Slon[] sloniVybeh = new Slon[3];
            sloniVybeh[0] = s;
            // sloniVybeh[1] = z; // nelze vložit

            g.Doktor();
            s.Doktor();
            zb.Bez();
            // MessageBox.Show(s.ToString());
            // MessageBox.Show(g.ToString());

            s.BFF(zb);
            s.BFF(g);

            MessageBox.Show(s.VypisKamarady());
            MessageBox.Show(zb.VypisKamarady()); 
            MessageBox.Show(g.VypisKamarady());

            double r = g.Rychlost;
            g.Rychlost = 500.8;

        }
    }
}