namespace _23_AnimaceNavadeni
{
    public partial class Form1 : Form
    {
        private int x = 450, y = 0;
        private bool sever, jih=true, vychod=true, zapad;

        private void PanelDraw_MouseDown(object sender, MouseEventArgs e)
        {
          //  MessageBox.Show($"[{e.X},{e.Y}]");

            if(x < e.X)
            {
                zapad = false;
                vychod = true;
            }else
            {
                zapad = true;
                vychod = false;
            }

            if(y < e.Y)
            {
                jih = true;
                sever = false;
            }
            else
            {
                jih = false;
                sever = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TimerMove_Tick(object sender, EventArgs e)
        {
            if (x == PanelDraw.Width-20)
            {
                zapad = true;
                vychod = false;
            }
            if (x == 0)
            {
                vychod = true;
                zapad = false;
            }

            if(y == 0)
            {
                jih = true;
                sever = false;
            }
            if(y == PanelDraw.Height - 20)
            {
                jih = false;
                sever = true;
            }
            //ALT +38 = &
            if (vychod) x++;                    
            if (zapad)x--;    
            if (sever) y--;
            if (jih) y++;            

            PanelDraw.Refresh();
        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Red, x, y, 20, 20);
        }
    }
}