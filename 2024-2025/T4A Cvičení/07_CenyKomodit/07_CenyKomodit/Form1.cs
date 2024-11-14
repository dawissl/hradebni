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
                    // p�e�ten� prvn�ho ��dku "napr�zdno"
                    // z�hlav� nenese informaci
                    sr.ReadLine();
                    //�ten� souboru po ��dc�ch dokud nenaraz�me na konec souboru
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        //��dek m� form�t: datum YYYY-MM-DD;cena double
                        string[] splitted = line.Split(';');
                        Polozka p = new Polozka();
                        //parsov�n� vstupn�ch hodnot v upravenem formatu
                        // Trim() o�ez�n� stringu zleva i zprava od pr�zdn�ch znak� (whitespace)
                        p.Datum = DateTime.Parse(splitted[0].Replace('"', ' ').Trim());
                        p.Cena = double.Parse(splitted[1].Replace('"', ' ').Trim());
                        nactenaKomodita.Data.Add(p);
                    }
                    sr.Close();
                }
                // vykresleni grafu po na�ten� dat komodity
                PanelGraf.Refresh();
            }
        }

        private void PanelGraf_Paint(object sender, PaintEventArgs e)
        {
            // vykreslovat chceme a� v moment�, kdy je hodnota inicializovana
            if (nactenaKomodita != null) {
                Graphics g = e.Graphics;
                List<Point> points = new List<Point>();
                int shift =0;
                // vytvo�en� kolekce bod� vych�zej�c� z ceny komodity pro dan� datum
                foreach(Polozka p in nactenaKomodita.Data)
                {
                    // TODO ov��it fit do grafu (zlomkovy vzorec vyu��vaj�c� min a max hodnotu)
                    points.Add(new Point(shift, (int)(PanelGraf.Height - p.Cena))); // redukce ceny, aby se ve�la do panelu
                    shift ++; // posun na �asov� ose
                }
                g.DrawLines(Pens.Red, points.ToArray());
            }
        }
    }
}
