namespace Ponorka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            new GenerovaniDat("soubor.csv"); // vytvoreni souboru
            AnalyzaData a = new AnalyzaData("soubor.csv"); // nacteni a zpracovani
            // pole bodu o stejne velikosti, kolik máme vygenerovaných záznamù
            Point[] poleBodu = new Point[a.Data.Count]; 
            for (int index = 0; index < poleBodu.Length; index++)
            {
                // v cyklu chceme na každou pozici bodu vložit ziskanou hodnotu
                // cas nasobime 5, abychom vizuelnì zvìtšili rozestupy mezi body
                // pro vykreslení hodnoty tak jak jsme zvykli je tøeba hodnout
                // hloubky odeèíst od výšky panelu
                // jinak platí, že hodnota 0 je na horní hranì panelu
                poleBodu[index] = new Point(a.Data[index].Cas * 5,
                                        panel1.Height - a.Data[index].Hloubka);
            }

            Graphics g = e.Graphics;
            g.DrawLines(Pens.Red, poleBodu); // vykreslení lomenné èáry
            // zjištìní zda je funkce v intervalu 30-50 rostouci/klesajici/konstantni
            string vysledek = a.AnalyzaIntervalu(30, 50); 
            // vykreslení ohranièení intervalu vèetnì výsledku pro daný interval
            g.DrawLine(Pens.Green, new Point(30 * 5, 0), new Point(30 * 5, panel1.Height));
            g.DrawLine(Pens.Green, new Point(50 * 5, 0), new Point(50 * 5, panel1.Height));
            g.DrawString(vysledek, new Font("Arial", 25), Brushes.Blue, new Point(10, 10));

            // vykreslení bodù (koleèka), které mají hloubku vìtší než 200 m
            foreach (Point p in a.hodnotyNad200())
            {
                g.FillEllipse(Brushes.Black, p.X - 3, panel1.Height - p.Y - 3, 6, 6);
            }
            // hranice 200m
            g.DrawLine(Pens.LightGreen, new Point(0, panel1.Height - 200), new Point(panel1.Width, panel1.Height - 200));
            g.DrawString("200 m", new Font("Arial", 18), Brushes.DarkGreen, panel1.Width - 75, panel1.Height - 230);


        }
    }
}