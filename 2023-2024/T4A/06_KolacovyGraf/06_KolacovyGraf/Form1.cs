namespace _06_KolacovyGraf
{
    public partial class Form1 : Form
    {
        private List<Hodnoceni> listHodnoceni = new List<Hodnoceni>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            string[] predmety = { "CJL", "MAT", "AGJ", "TEV", "OBN", "PGM", "FYZ", "PMK", "PVY", "EKO", "ZAE" };
            string[] jmena = { "A", "B", "C", "D", "E" };
            Random rnd = new Random();
            using (StreamWriter sw = new StreamWriter("file.txt"))
            {
                for (int i = 0; i < 200; i++)
                {
                    string predmet = predmety[rnd.Next(0, predmety.Length)];
                    string jmeno = jmena[rnd.Next(0, jmena.Length)];
                    int znamka = rnd.Next(1, 6);
                    sw.WriteLine($"{jmeno}-{predmet}-{znamka}");
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
                    if (radek == null) return;
                    string[] rozdelenyRadek = radek.Split("-");
                    Hodnoceni h = listHodnoceni.Find(x => x.Predmet == rozdelenyRadek[1]);
                    if (h != null)
                    {
                        h.SumaZnamek = int.Parse(rozdelenyRadek[2]);
                        h.PocetZnamek = 1;
                    }
                    else
                    {
                        listHodnoceni.Add(new Hodnoceni(rozdelenyRadek[1], int.Parse(rozdelenyRadek[2])));
                    }

                }
                sr.Close();
            }

            MessageBox.Show(PrintCollection());

            // vypsani pøedmìtu s prùmìrem lepším než 3
            var tmpList = listHodnoceni.OrderBy(x => x.Prumer()).Take(3);
            string tmp = "";
            foreach (Hodnoceni h in tmpList)
            {
                tmp += h.ToString() + Environment.NewLine;
            }
            MessageBox.Show(tmp);

            PanelPie.Refresh();

        }

        private string PrintCollection()
        {
            string tmp = "";
            foreach (Hodnoceni h in listHodnoceni)
            {
                tmp += h.ToString() + Environment.NewLine;
            }
            return tmp;
        }

        private void PanelPie_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (listHodnoceni.Count == 0) return;

            //var h = (Hodnoceni)listHodnoceni.OrderBy(x => x.Prumer()).Take(1);

            g.FillPie(Brushes.Red, 20, 20, 100, 100, 0, (int)(360 / 2.5));
        }
    }
}