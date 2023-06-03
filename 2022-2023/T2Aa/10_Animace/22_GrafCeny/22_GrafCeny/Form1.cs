namespace _22_GrafCeny
{
    public partial class Form1 : Form
    {
        private List<int> obili = new List<int>();
        private List<int> med = new List<int>();
        private List<int> hovezi = new List<int>();

        public Form1()
        {
            InitializeComponent();
            LoadFiles();
        }

        private void LoadFiles()
        {
           
            using(StreamReader sr = new StreamReader("wheat.csv"))
            {
                //vyètení naprázdno pro pøeskoèení záhlaví tabulky
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string cena = line.Split(';')[1];
                    obili.Add(Convert.ToInt32(cena.Split('.')[0]));
                }
                sr.Close();
            }
            using (StreamReader sr = new StreamReader("beef.csv"))
            {
                //vyètení naprázdno pro pøeskoèení záhlaví tabulky
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string cena = line.Split(';')[1];
                    hovezi.Add(Convert.ToInt32(cena.Split('.')[0])*100);
                }
                sr.Close();
            }
            using (StreamReader sr = new StreamReader("cooper.csv"))
            {
                //vyètení naprázdno pro pøeskoèení záhlaví tabulky
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string cena = line.Split(';')[1];
                    med.Add(Convert.ToInt32(cena.Split('.')[0]));
                }
                sr.Close();
            }


        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {

        }
    }
}