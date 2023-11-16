namespace _07_Jizdy
{
    public partial class Form1 : Form
    {
        private List<Jizda> listJizd = new List<Jizda>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string[] jmena_ridicu = { "Kamil", "Franta", "Pepa", "Robert", "Sam", "Lojza" };
            string[] spz_vozidel = { "1A2 3532", "2B6 1236", "7C3 9735", "2T8 7739", "3H6 2237" };
            string[] naklady = { "-", "-", "lednice", "dobytek", "odpad", "cihly" };

            Random rnd = new Random();

            using (StreamWriter writer = new StreamWriter("jizdy.csv"))
            {
                writer.WriteLine("DATUM;RIDIC;VOZIDLO;NAKLAD");

                for (int i = 0; i < 50; i++)
                {
                    writer.WriteLine($"{new DateTime(2023, 11, rnd.Next(1, 31))};" +
                    $"{jmena_ridicu[rnd.Next(0, jmena_ridicu.Length)]};" +
                    $"{spz_vozidel[rnd.Next(0, spz_vozidel.Length)]};" +
                    $"{naklady[rnd.Next(0, naklady.Length)]}");
                }
                writer.Close();
            }
        }

        private void BtnReadData_Click(object sender, EventArgs e)
        {
            TxtRides.Text = "";

            using (StreamReader reader = new StreamReader("jizdy.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string radek = reader.ReadLine();
                    string[] rozdelenyRadek = radek.Split(";");

                    Jizda jizda = new Jizda(DateTime.Parse(rozdelenyRadek[0]),
                                            rozdelenyRadek[1],
                                            rozdelenyRadek[2],
                                            rozdelenyRadek[3]);
                    listJizd.Add(jizda);
                }

                reader.Close();
            }

            string tmp = "";
            foreach (Jizda j in listJizd)
            {
                tmp += j.ToString() + Environment.NewLine;
            }
            TxtRides.Text = tmp;
        }
    }
}