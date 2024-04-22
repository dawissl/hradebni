namespace _22_ParkovaciDum
{
    public partial class Form1 : Form
    {
        private Spot[,] parkoviste = new Spot[10, 4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < parkoviste.GetLength(0); i++)
            {
                for (int j = 0; j < parkoviste.GetLength(1); j++)
                {
                    parkoviste[i, j] = new Spot(i, j);
                    Controls.Add(parkoviste[i, j]);
                }
            }
        }

        private void BtnPark_Click(object sender, EventArgs e)
        {
            int floor = EmptiestFloor();
            bool placed = false;
            for (int m = 0; m < parkoviste.GetLength(1); m++)
            {
                if (parkoviste[floor, m].SpotStatus == Spot.Status.FREE)
                {
                    parkoviste[floor, m].SpotStatus = Spot.Status.OCCUPIED;
                    placed = true;
                    break;
                }
            }
            if (!placed) MessageBox.Show("Nelze zaparkovat");
            UpdateCapacity();
        }

        private void UpdateCapacity()
        {
            double occupied = 0;
            for (int i = 0; i < parkoviste.GetLength(0); i++)
            {
                for (int j = 0; j < parkoviste.GetLength(1); j++)
                {
                    if (parkoviste[i, j].SpotStatus != Spot.Status.FREE) occupied++;
                }
            }
            double capacity = parkoviste.GetLength(0) * parkoviste.GetLength(1);
            LblCapacity.Text = $"{Math.Round(100 - (occupied / capacity) * 100, 2)} %";
        }

        private int EmptiestFloor()
        {
            int[] floors = new int[parkoviste.GetLength(0)];
            for (int i = 0; i < floors.Length; i++)
            {
                for (int j = 0; j < parkoviste.GetLength(1); j++)
                {
                    if (parkoviste[i, j].SpotStatus != Spot.Status.FREE) floors[i]++;
                }
            }
            return Array.IndexOf(floors, floors.Min());
        }
    }
}
