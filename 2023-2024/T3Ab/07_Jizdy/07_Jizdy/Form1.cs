namespace _07_Jizdy
{
    public partial class Form1 : Form
    {
        private List<Jizda> seznamJizd = new List<Jizda>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            // databaze hodnot, ze kterých náhodnì vybíráme hodnoty pro vytváøený záznam
            string[] jmena_ridicu = { "Kamil", "Pepa", "Franta", "Jacek", "Bohuslav", "Cyril" };
            string[] spz_vozidel = { "1A5 1298", "2S3 7833", "7BA 5973", "6H9 9817", "1E5 1152", "5T5 2261" };
            string[] seznam_nakladu = { "-", "-", "obili", "lednice", "dobytek", "maso" };

            Random rnd = new Random();

            using (StreamWriter writer = new StreamWriter("jizdy.csv"))
            {
                writer.WriteLine("DATUM;RIDIC;VOZIDLO;NAKLAD");

                for (int i = 0; i < 100; i++)
                {
                    // vlozeni jednoho radku jizdy v prislusnem csv formatu
                    writer.WriteLine($"{new DateTime(2023, 11, rnd.Next(1, 31))};" +
                        $"{jmena_ridicu[rnd.Next(0, jmena_ridicu.Length)]};" +
                        $"{spz_vozidel[rnd.Next(0, spz_vozidel.Length)]};" +
                        $"{seznam_nakladu[rnd.Next(0, seznam_nakladu.Length)]}");
                }


                writer.Close();
            }

        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            TxtRides.Text = "";

            // TODO nacteni souboru a ulozeni do kolekce List
            using(StreamReader reader = new StreamReader("jizdy.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string radek = reader.ReadLine();
                    string[] rozdeleny_radek = radek.Split(";");
                    Jizda j = new Jizda(DateTime.Parse(rozdeleny_radek[0]),
                                        rozdeleny_radek[1],
                                        rozdeleny_radek[2],
                                        rozdeleny_radek[3]);
                    seznamJizd.Add(j);
                }

                reader.Close();
            }
            string vystup = "";
            foreach(Jizda j in seznamJizd)
            {
                vystup += j.ToString() + Environment.NewLine;
            }
            TxtRides.Text = vystup;
        }
    }
}