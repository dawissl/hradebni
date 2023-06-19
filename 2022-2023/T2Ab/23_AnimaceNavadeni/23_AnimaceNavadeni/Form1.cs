namespace _23_AnimaceNavadeni
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;
        private bool sever, jih, zapad, vychod = true;

        private void PanelMotion_MouseDown(object sender, MouseEventArgs e)
        {
            // $ = alt + 36
          //  MessageBox.Show($"Kliknuto na bod [{e.X},{e.Y}]");

            // reseni smeru pro X souradnici
            if( e.X > x)
            {
                vychod = true;
                zapad = false;
            }
            else
            {
                vychod = false;
                zapad = true;
            }
            // reseni smeru pro Y souradnici
            if(e.Y > y)
            {
                jih = true;
                sever = false;
            }
            else
            {
                jih = false;
                sever = true;
            }
            // edit speed
            double speed = Math.Sqrt((e.X-x) * (e.X-x) + (e.Y-y) * (e.Y-y));

            if (speed > 0 && speed < 50) TimerMotion.Interval = 500;
            if (speed >= 50 && speed < 100) TimerMotion.Interval = 150;
            if(speed >=100) TimerMotion.Interval = 10;


            
        }

        private const int OBJECT_SIZE = 30;
        private void TimerMotion_Tick(object sender, EventArgs e)
        {
            if (x == PanelMotion.Width - OBJECT_SIZE)
            {
                vychod = false;
                zapad = true;
            }
            if (x == 0)
            {
                vychod = true;
                zapad = false;
            }

            if (y == 0)
            {
                jih = true;
                sever = false;
            }

            if (y == PanelMotion.Height - OBJECT_SIZE)
            {
                jih = false;
                sever = true;
            }


            if (vychod) x++;
            if (zapad) x--;
            if (sever) y--;
            if (jih) y++;

            PanelMotion.Refresh();
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void PanelMotion_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Blue, x, y, OBJECT_SIZE, OBJECT_SIZE);

        }
    }
}