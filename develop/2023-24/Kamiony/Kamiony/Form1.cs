namespace Kamiony
{
    public partial class Form1 : Form
    {
        private List<Ride> rides = new List<Ride>();
        private List<Point> tmpRide = new List<Point>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void PanelRides_MouseDown(object sender, MouseEventArgs e)
        {
            tmpRide.Add(new Point(e.X, e.Y));
            PanelRides.Refresh();
        }

        private void PanelRides_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (tmpRide.Count == 0 && rides.Count == 0) return;
            if (tmpRide.Count >= 1)
            {
                foreach (Point p in tmpRide)
                {
                    g.FillEllipse(Brushes.Aqua, p.X - 5, p.Y - 5, 10, 10);
                }
            }
            if (tmpRide.Count >= 2)
            {
                g.DrawLines(Pens.Green, tmpRide.ToArray());
            }

            foreach (Ride r in rides)
            {
                g.DrawLines(Pens.Blue, r.RideList.ToArray());
                Font f = new Font("Arial", 16);
                g.DrawString(r.Name, f, Brushes.Red, r.RideList[0].X + 5, r.RideList[0].Y - 5);
            }
        }

        private void BtnAddRide_Click(object sender, EventArgs e)
        {
            if (TxtTruck.Text == "")
            {
                MessageBox.Show("Chybí název kamionu");
                return;
            }
            Ride newRide = new Ride(tmpRide, TxtTruck.Text);
            rides.Add(newRide);
            ListRides.Items.Add(newRide);
            tmpRide = new List<Point>();
            PanelRides.Refresh();
        }

        private void BtnLoadRides_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string name = "";
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == "-")
                        {
                            Ride newRide = new Ride(tmpRide, name);
                            rides.Add(newRide);
                            ListRides.Items.Add(newRide);
                            tmpRide = new List<Point>();
                        }
                        else if (line.Contains(";"))
                        {
                            string[] tmpPoint = line.Split(';');
                            tmpRide.Add(new Point(int.Parse(tmpPoint[0]), int.Parse(tmpPoint[1])));
                        }
                        else
                        {
                            name = line;
                        }

                    }
                    sr.Close();
                }
            }
            PanelRides.Refresh();
        }

        private void ListRides_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((ListRides.SelectedItem as Ride).Print());

        }
    }
}