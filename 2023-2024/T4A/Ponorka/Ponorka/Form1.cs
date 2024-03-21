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
            // pole bodu o stejne velikosti, kolik m�me vygenerovan�ch z�znam�
            Point[] poleBodu = new Point[a.Data.Count]; 
            for (int index = 0; index < poleBodu.Length; index++)
            {
                // v cyklu chceme na ka�dou pozici bodu vlo�it ziskanou hodnotu
                // cas nasobime 5, abychom vizueln� zv�t�ili rozestupy mezi body
                // pro vykreslen� hodnoty tak jak jsme zvykli je t�eba hodnout
                // hloubky ode��st od v��ky panelu
                // jinak plat�, �e hodnota 0 je na horn� hran� panelu
                poleBodu[index] = new Point(a.Data[index].Cas * 5,
                                        panel1.Height - a.Data[index].Hloubka);
            }

            Graphics g = e.Graphics;
            g.DrawLines(Pens.Red, poleBodu); // vykreslen� lomenn� ��ry
            // zji�t�n� zda je funkce v intervalu 30-50 rostouci/klesajici/konstantni
            string vysledek = a.AnalyzaIntervalu(30, 50); 
            // vykreslen� ohrani�en� intervalu v�etn� v�sledku pro dan� interval
            g.DrawLine(Pens.Green, new Point(30 * 5, 0), new Point(30 * 5, panel1.Height));
            g.DrawLine(Pens.Green, new Point(50 * 5, 0), new Point(50 * 5, panel1.Height));
            g.DrawString(vysledek, new Font("Arial", 25), Brushes.Blue, new Point(10, 10));

            // vykreslen� bod� (kole�ka), kter� maj� hloubku v�t�� ne� 200 m
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