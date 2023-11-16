using System.Windows.Forms.VisualStyles;

namespace _06_KolacovyGraf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] druhyPeciva = { "rohlik", "chleb", "houska", "dalamanek", "bageta", "kobliha", "kolac" };
            using (StreamWriter sw = new StreamWriter("zbozi.txt"))
            {
                for (int i = 0; i < 50; i++)
                {
                    // vložení položky do soubory ve formatu druhPeciva-pocet
                    sw.WriteLine($"{druhyPeciva[rnd.Next(0, druhyPeciva.Length)]}-{rnd.Next(1, 21)}");
                }
                sw.Close();
            }
        }

        private void BtnPie_Click(object sender, EventArgs e)
        {
            List<Pecivo> pecivaNaSkladu = new List<Pecivo>();

            using (StreamReader sr = new StreamReader("zbozi.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] radek = sr.ReadLine().Split("-");
                    if (radek[0] == "") continue;

                    // overeni, zda jiz pecivo je v listu
                    bool exist = false;
                    for(int i = 0; i < pecivaNaSkladu.Count; i++)
                    {
                        if (pecivaNaSkladu[i].Druh == radek[0] && !exist)
                        {
                            pecivaNaSkladu.Add(new Pecivo(radek[0], int.Parse(radek[1])));
                            exist = true;
                            break;
                        }
                        else
                        {
                            pecivaNaSkladu[i].Pocet = int.Parse(radek[1]);
                        }

                    }
                }
                sr.Close();
            }

            // filtrovani produktu a jejich zobrazeni v MessageBoxu - využití LINQ

            string vystup = "";
            foreach (Pecivo p in pecivaNaSkladu)
            {
                vystup += p.ToString() + Environment.NewLine;
            }
            MessageBox.Show(vystup);

        }

        private void PanelGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillPie(Brushes.Red, 0, 0, 200, 200, 0, 120);
        }
    }
}