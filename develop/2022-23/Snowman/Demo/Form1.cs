/// <summary>
/// @author=DWS
/// </summary>
namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;

            //tìlo
            grf.FillEllipse(Brushes.White, 200, 300, 100, 100);
            grf.FillEllipse(Brushes.White, 210, 220, 80, 80);
            grf.FillEllipse(Brushes.White, 220, 160, 60, 60);

            //ruce
            grf.FillEllipse(Brushes.White, 150, 240, 60, 30);
            grf.FillEllipse(Brushes.White, 290, 240, 60, 30);

            //nos
            Point[] nos = {
                new Point(245,185),
                new Point(270,190),
                new Point(245,195)
           };
            grf.FillPolygon(Brushes.Orange, nos);

            //oèi

            grf.FillRectangle(Brushes.Black,235,170,10,10);
            grf.FillRectangle(Brushes.Black, 255, 170, 10, 10);

            //klobouk
            grf.FillRectangle(Brushes.Black, 210, 155, 80, 10);
            grf.FillRectangle(Brushes.Black, 220, 105, 60, 50);



        }
    }
}