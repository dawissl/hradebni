namespace Kamiony
{
    public partial class Form1 : Form
    {
        private List<Point> docasnaJizda = new List<Point>();
        private List<JizdaKamionu> jizdyKamionu = new List<JizdaKamionu>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            JizdaKamionu jizda = new JizdaKamionu(docasnaJizda, TxtTruck.Text);
            jizdyKamionu.Add(jizda);
            docasnaJizda = new List<Point>();
            PanelRide.Refresh();
        }
        private void PanelRide_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (JizdaKamionu jizda in jizdyKamionu)
            {
                graphics.DrawLines(Pens.Red, jizda.Jizda.ToArray());
                graphics.DrawString(jizda.Nazev,
                                    new Font("Arial", 10),
                                    Brushes.Green, jizda.Jizda[0]);
            }
        }

        private void PanelRide_MouseClick(object sender, MouseEventArgs e)
        {
            docasnaJizda.Add(new Point(e.X, e.Y));
        }

        private void BtnLoadRide_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("kamiony.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string nazev = "";
                    string line = sr.ReadLine();
                    if (!line.Contains(";") && line.Contains("-"))
                    {
                        nazev = line;
                    }
                    if (line.Contains(";"))
                    {
                        string[] souradnice = line.Split(';');
                        docasnaJizda.Add(
                            new Point(int.Parse(souradnice[0]),
                                      int.Parse(souradnice[1])));
                    }
                    if (line.Contains("-"))
                    {
                        jizdyKamionu.Add(new JizdaKamionu(docasnaJizda, nazev));
                        docasnaJizda = new List<Point>();
                    }

                }


                sr.Close();
            }
            PanelRide.Refresh();
        }
    }
}