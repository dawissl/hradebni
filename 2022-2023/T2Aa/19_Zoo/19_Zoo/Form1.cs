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
            List<Zvire> zoo = new List<Zvire>();

            Zvire z = new Zvire("Kamil", 14, 100);
            Lef l = new Lef("Ftefan", 8, 40,"sigma");
            Slon s = new Slon("Ludvik", 30, 80, Lokace.INDICKY);

            zoo.Add(z);
            zoo.Add(l);
            zoo.Add(s);

            z.BFF(s);
            z.BFF(l);

            MessageBox.Show(z.Animalbook());
            MessageBox.Show(l.Animalbook());
            MessageBox.Show(s.Animalbook());
         }
    }
}