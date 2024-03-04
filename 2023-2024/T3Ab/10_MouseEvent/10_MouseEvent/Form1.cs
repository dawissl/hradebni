namespace _10_MouseEvent
{
    public partial class Form1 : Form
    {
        private int x, y;

        private List<Rectangle> drawings = new List<Rectangle>();
        private List<bool> rounded = new List<bool>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TrackHeight_Scroll(object sender, EventArgs e)
        {
            if (RadioCircle.Checked || RadioSquare.Checked)
            {
                TrackWidth.Value = TrackHeight.Value;
            }
        }

        private void TrackWidth_Scroll(object sender, EventArgs e)
        {
            if (RadioCircle.Checked || RadioSquare.Checked)
            {
                TrackHeight.Value = TrackWidth.Value;
            }
        }

      
        private void AddDrawing()
        {
            if (RadioEllipse.Checked || RadioCircle.Checked)
            {
                rounded.Add(true);
            }
            if (RadioRectangle.Checked || RadioSquare.Checked)
            {
                rounded.Add(false);
            }
            drawings.Add(new Rectangle(x, y, TrackWidth.Value, TrackHeight.Value));

        }

       

        private void RadioSquare_CheckedChanged(object sender, EventArgs e)
        {
            TrackHeight.Value = TrackWidth.Value;
        }

        private void RadioCircle_CheckedChanged(object sender, EventArgs e)
        {
            TrackHeight.Value = TrackWidth.Value;
        }

        private void PanelDraw_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < drawings.Count; i++)
            {
                if (rounded[i])
                {
                    g.FillEllipse(Brushes.Blue, drawings[i]);
                }
                else
                {
                    g.FillRectangle(Brushes.Blue, drawings[i]);
                }
            }

        }

        private void PanelDraw_MouseDown_1(object sender, MouseEventArgs e)
        {
            x = e.Location.X; y = e.Location.Y;
            AddDrawing();
            PanelDraw.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawings.Clear();
            rounded.Clear();
            PanelDraw.Refresh();
        }
    }
}