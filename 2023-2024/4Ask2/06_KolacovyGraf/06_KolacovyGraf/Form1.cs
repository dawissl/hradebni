namespace _06_KolacovyGraf
{
    public partial class Form1 : Form
    {
        private List<Osoba> seznamOsob = new List<Osoba>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] jmena = { "Kamil", "Richard", "Petr", "Lukáš", "Patrik", "Marcel", "Lída", "Eliška", "Andrea" };

            using (StreamWriter sw = new StreamWriter("file.txt"))
            {
                for (int i = 0; i < 200; i++)
                {
                    sw.WriteLine($"{jmena[rnd.Next(0, jmena.Length)]}/{rnd.Next(1, 100)}");
                }
                sw.Close();
            }

        }

        private void BtnPie_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string radek = sr.ReadLine();
                    string jmeno = radek.Split("/")[0];
                    bool exist = false;
                    for (int i = 0; i < seznamOsob.Count; i++)
                    {
                        if (seznamOsob[i].Jmeno == jmeno)
                        {
                            seznamOsob[i].Pocet = 1;
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        seznamOsob.Add(new Osoba(jmeno));
                    }
                }

                sr.Close();
            }

            // vypis seznam osob
            string tmp = "";
            foreach (Osoba s in seznamOsob.Where(x => x.Pocet > 25))
            {
                tmp += s + Environment.NewLine;
            }

            MessageBox.Show(tmp);

            foreach (Osoba s in seznamOsob.OrderByDescending(x => x.Pocet).Take(1))
            {
                tmp = s + Environment.NewLine;
            }

            MessageBox.Show(tmp);
        }

        private void PanelPie_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.FillPie(Brushes.Aqua, 20, 20, 100, 100, 0, 120);
            graphics.FillPie(Brushes.Red, 20, 20, 100, 100, 120, 90);
            graphics.FillPie(Brushes.Yellow, 20, 20, 100, 100, 120+90, 240-90);
        }
    }
}