namespace Parkoviste
{
    public partial class Form1 : Form
    {
        private bool draw = false;
        private ParkingLot parkoviste;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerateParkingLot_Click(object sender, EventArgs e)
        {
            parkoviste = new ParkingLot((int)NumPatra.Value, (int)NumMista.Value);
            draw = true;
            PanelParkingLot.Refresh();
        }

        private void PanelParkingLot_Paint(object sender, PaintEventArgs e)
        {
            if (!draw) return;
            Graphics graphics = e.Graphics;
            for (int p = 0; p < parkoviste.Parkoviste.GetLength(0); p++)
            {
                for (int m = 0; m < parkoviste.Parkoviste.GetLength(1); m++)
                {
                    if (parkoviste.Parkoviste[p, m] == null)
                    {
                        graphics.FillRectangle(Brushes.Green, m * 30, p * 25, 25, 20);
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.Red, m * 30, p * 25, 25, 20);
                    }
                }
            }
        }

        private void BtnPlace_Click(object sender, EventArgs e)
        {
            string[] name = { "a", "b", "c", "d", "e", "f" };
            string[] spz = { "a1a aaaa", "b2b bbbb", "c3c cccc", "d4d dddd", "e4e eeee", "f5f ffff" };
            Random r = new Random();
            Car newCar = new Car(name[r.Next(6)], spz[r.Next(6)]);
            if (TxtMisto.Text == "" && TxtPatro.Text == "")
            {
                parkoviste.Park(newCar);
                PanelParkingLot.Refresh();
                return;
            }
            if (TxtMisto.Text == "" || TxtPatro.Text == "")
            {
                MessageBox.Show("malo infa");
                return;
            }
            if (TxtMisto.Text != "" && TxtPatro.Text != "")
            {
                parkoviste.Part(newCar, int.Parse(TxtPatro.Text), int.Parse(TxtMisto.Text));
                PanelParkingLot.Refresh();
                return;
            }
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (TxtMisto.Text == "" || TxtPatro.Text == "")
            {
                MessageBox.Show("Chybìjici informace k zaparkovani");
            }
            else
            {
                parkoviste.Vyparkuj(int.Parse(TxtPatro.Text), int.Parse(TxtMisto.Text));
            }
            PanelParkingLot.Refresh();
            LblIncome.Text = $"Pøijem: {parkoviste.Income} Kè";
        }
    }
}