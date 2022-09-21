namespace Cinema
{
    public partial class Form1 : Form
    {
        private Label[,] cinema;
        private Label cinemaPlane;
        public Form1()
        {
            InitializeComponent();


        }

        private void BtnCinema_Click(object sender, EventArgs e)
        {
            ClearCinema();
            
            int size = int.Parse(TxtSize.Text);
            cinemaPlane = CinemaPlane(size);
            Controls.Add(cinemaPlane);
            cinema = new Label[size, size];
            CinemaPlane(size);
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for(int j = 0; j < cinema.GetLength(1); j++)
                {
                    cinema[i,j] = CinemaSeat(i,j);
                    Controls.Add(cinema[i,j]);
                }
            }
        }

        private Label CinemaPlane(int size)
        {
            Label plane = new Label();
            plane.Location = new Point(50,50);
            plane.Width = 150;
            plane.Height = 20;
            plane.Text = "Plátno";
            plane.BackColor = Color.White;
            plane.TextAlign = ContentAlignment.MiddleCenter;
            return plane;


        }

        private Label CinemaSeat(int m, int n)
        {
            Label label = new Label();
            label.Location = new Point(50 + 30 * m, 80 + 30 * n);
            label.Width = 20;
            label.Height = 20;
            label.BackColor = Color.Aqua;
            label.Click += new EventHandler(LabelSeat_Click);
            label.Name = $"sedadlo #{n+1}-{m+1}";
            return label; 
            
        }

        private void LabelSeat_Click(object? sender, EventArgs e)
        {
            
            if((sender as Label).BackColor == Color.Aqua)
            {
                (sender as Label).BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show($"{(sender as Label).Name} je obsazeno.");
            }
        }

        private void ClearCinema()
        {
            if (cinema == null) return;
            if (cinemaPlane == null) return;

            Controls.Remove(cinemaPlane);
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                for (int j = 0; j < cinema.GetLength(1); j++)
                {
                    Controls.Remove(cinema[i, j]);
                }
            }
        }
       
       
    }
}