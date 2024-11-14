using System.Globalization;

namespace _07_CenyKomodit
{
    public partial class Form1 : Form
    {
        private Komodita nactenaKomodita;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(dialog.FileName))
                {
                    string nazevKomodity = dialog.FileName.Substring(dialog.FileName.LastIndexOf('\\'));
                    nactenaKomodita = new Komodita(nazevKomodity);
                    // pøeètení prvního øádku "naprázdno"
                    // záhlaví nenese informaci
                    sr.ReadLine();
                    //ètení souboru po øádcích dokud nenarazíme na konec souboru
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        //øádek má formát: datum YYYY-MM-DD;cena double
                        string[] splitted = line.Split(';');
                        Polozka p = new Polozka();
                        //parsování vstupních hodnot v upravenem formatu
                        // Trim() oøezání stringu zleva i zprava od prázdných znakù (whitespace)
                        p.Datum = DateTime.Parse(splitted[0].Replace('"', ' ').Trim());
                        p.Cena = double.Parse(splitted[1].Replace('"', ' ').Trim());
                        nactenaKomodita.Data.Add(p);
                    }
                    sr.Close();
                }
                // vykresleni grafu po naètení dat komodity
                PanelGraf.Refresh();
            }
        }

        private void PanelGraf_Paint(object sender, PaintEventArgs e)
        {
            // vykreslovat chceme až v momentì, kdy je hodnota inicializovana
            if (nactenaKomodita != null) {
                Graphics g = e.Graphics;
                List<Point> points = new List<Point>();
                int shift =0;
                // vytvoøení kolekce bodù vycházející z ceny komodity pro dané datum
                foreach(Polozka p in nactenaKomodita.Data)
                {
                    // TODO ovìøit fit do grafu (zlomkovy vzorec využívající min a max hodnotu)
                    points.Add(new Point(shift, (int)(PanelGraf.Height - p.Cena))); // redukce ceny, aby se vešla do panelu
                    shift ++; // posun na èasové ose
                }
                g.DrawLines(Pens.Red, points.ToArray());
            }
        }
    }
}
