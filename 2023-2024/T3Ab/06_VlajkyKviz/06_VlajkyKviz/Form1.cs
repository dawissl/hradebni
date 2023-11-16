namespace _06_VlajkyKviz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PanelQ1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.White, 0, 0, 200, 50);
            g.FillRectangle(Brushes.Red, 0, 50, 200, 50);
            Point[] triangle = { new Point(0, 0), new Point(100, 50), new Point(0, 100) };
            g.FillPolygon(Brushes.Blue, triangle);

        }

        private void PanelQ2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Green, 0, 0, 66, 100);
            g.FillRectangle(Brushes.White, 66, 0, 66, 100);
            g.FillRectangle(Brushes.Red, 132, 0, 66, 100);
        }

        private void PanelQ3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, 200, 100);
            g.FillRectangle(Brushes.Yellow, 66, 0, 20, 100);
            g.FillRectangle(Brushes.Yellow, 0, 40, 200, 20);
        }

        private void PanelQ4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, 0, 0, 200, 100);
            g.FillEllipse(Brushes.Red, 70, 20, 60, 60);
        }

        private void TabFlagQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Q = (TxtQ1.Text.ToUpper() == "ÈESKÁ REPUBLIKA") ? 1 : 0;
            Q += (TxtQ2.Text.ToUpper() == "ITÁLIE") ? 1 : 0;
            Q += (TxtQ3.Text.ToUpper() == "ŠVÉDSKO") ? 1 : 0;
            Q += (TxtQ4.Text.ToUpper() == "JAPONSKO") ? 1 : 0;
            Q += (TxtQ5.Text.ToUpper() == "VELKÁ BRITÁNIE") ? 1 : 0;
            Q += (TxtQ6.Text.ToUpper() == "JAMAJKA") ? 1 : 0;
            Q += (TxtQ6.Text.ToUpper() == "BAHRAJN") ? 1 : 0;

            TxtResult.Text = $"{Q}/7";

        }

        private void PanelQ5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Navy, 0, 0, 200, 100);

            Point[] LeftDiagThick = { new Point(0, 0), new Point(0, 20), new Point(180, 100), new Point(200, 100), new Point(200, 80), new Point(20, 0) };
            Point[] RightDiagThick = { new Point(0, 100), new Point(20, 100), new Point(200, 20), new Point(200, 0), new Point(180, 0), new Point(0, 80) };
            Point[] LeftDiagThin = { new Point(0, 0), new Point(0, 10), new Point(190, 100), new Point(200, 100), new Point(200, 90), new Point(10, 0) };
            Point[] RightDiagThin = { new Point(0, 100), new Point(10, 100), new Point(200, 10), new Point(200, 0), new Point(190, 0), new Point(0, 90) };



            g.FillPolygon(Brushes.White, LeftDiagThick);
            g.FillPolygon(Brushes.White, RightDiagThick);
            g.FillPolygon(Brushes.Red, LeftDiagThin);
            g.FillPolygon(Brushes.Red, RightDiagThin);

            g.FillRectangle(Brushes.White, 90, 0, 20, 100);
            g.FillRectangle(Brushes.White, 0, 40, 200, 20);

            g.FillRectangle(Brushes.Red, 95, 0, 10, 100);
            g.FillRectangle(Brushes.Red, 0, 45, 200, 10);


        }

        private void PanelQ6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] LeftDiagThin = { new Point(0, 0), new Point(0, 10), new Point(190, 100), new Point(200, 100), new Point(200, 90), new Point(10, 0) };
            Point[] RightDiagThin = { new Point(0, 100), new Point(10, 100), new Point(200, 10), new Point(200, 0), new Point(190, 0), new Point(0, 90) };
           
            Point[] upperTriangle = { new Point(0, 0), new Point(100,50),new Point(200,0)};
            Point[] lowerTriangle = { new Point(0, 100), new Point(100,50),new Point(200,100)};

            g.FillRectangle(Brushes.Black, 0, 0, 200, 100);

            g.FillPolygon(Brushes.DarkGreen, upperTriangle);
            g.FillPolygon(Brushes.DarkGreen, lowerTriangle);

            g.FillPolygon(Brushes.Yellow, LeftDiagThin);
            g.FillPolygon(Brushes.Yellow, RightDiagThin);


        }

        private void PanelQ7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.DarkRed, 0, 0, 200, 100);

            List<Point> zigZag = new List<Point>();
            zigZag.Add(new Point(0, 0));
            zigZag.Add(new Point(40, 0));
            for(int y = 0; y < PanelQ7.Height; y += 5)
            {
                if (y % 10 != 0)
                {
                    zigZag.Add(new Point(60, y));
                }
                else
                {
                    zigZag.Add(new Point(40, y));
                }
            }
            zigZag.Add(new Point(20, 100));
            zigZag.Add(new Point(0, 100));

            g.FillPolygon(Brushes.White, zigZag.ToArray());
        }
    }
}