using System.IO;
using System.Text;

namespace _05_KnihaJizd
{
    public partial class Form1 : Form
    {
        private List<Jizda> seznamJizd = new();
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnReadFile_Click_1(object sender, EventArgs e)
        {
            seznamJizd = new List<Jizda>();
            if (TxtFileName.Text == "")
            {
                MessageBox.Show("Zadejte n�zev souboru");
                return;
            }
            // na�ten� souboru od u�ivatele s j�zdami s p�id�n�m k�dov�n�

            using (StreamReader sr = new StreamReader(TxtFileName.Text, Encoding.Latin1))
            {
                while (!sr.EndOfStream)
                {
                    Jizda tmp = GetJizda(sr.ReadLine());
                    if (tmp != null) seznamJizd.Add(tmp);
                }

            }
            // na�ten� prvn�ho z�znamu - index == 0
            ZobrazJizdu();
        }

        private Jizda GetJizda(string? v)
        {

            // p�esko�en� z�hlav� tabulky
            if (v.Contains("stroj;spz"))
                return null;
            //rozd�len� �et�zce  - zn�me jeho podobu
            string[] vstup = v.Split(";", 5);

            return new Jizda(vstup[1],
                vstup[0],
                vstup[2],
                vstup[3],
                vstup[4]);

        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (seznamJizd == null || seznamJizd.Count == 0)
            {
                MessageBox.Show("Soubor nebyl na�ten");
                return;
            }
            index++;
            if (index == seznamJizd.Count - 1)
            {
                index = 0;
            }
            ZobrazJizdu();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            if (seznamJizd == null || seznamJizd.Count == 0)
            {
                MessageBox.Show("Soubor nebyl na�ten");
                return;
            }
            index--;
            if (index == -1)
            {
                index = seznamJizd.Count - 1;
            }
            ZobrazJizdu();
        }

        // zobrazen� jizdy do p�ipraven�ch kolonek dle indexu
        private void ZobrazJizdu()
        {
            Jizda j = seznamJizd[index];
            LblDriver.Text = j.Ridic;
            LblGood.Text = j.Zbozi;
            LblMachine.Text = j.Vozidlo;
            LblSPZ.Text = j.Spz;
            LblDate.Text = j.Datum;
        }
    }
}