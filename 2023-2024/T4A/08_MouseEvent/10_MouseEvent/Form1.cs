namespace _08_MouseEvent
{
    public partial class Form1 : Form
    {
        private int x, y;

        private List<Drawing> drawings = new List<Drawing>();
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

        private void PanelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X; y = e.Location.Y;
            AddDrawing();
            PanelDraw.Refresh();
        }

        private void AddDrawing()
        {
            Rectangle r = new Rectangle(x, y, TrackWidth.Value, TrackHeight.Value);
            drawings.Add(new Drawing(r, MenuPickColour.BackColor, RadioEllipse.Checked || RadioCircle.Checked));
        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < drawings.Count; i++)
            {
                SolidBrush brush = new SolidBrush(drawings[i].Clr);
                if (drawings[i].Rounded)
                    g.FillEllipse(brush, drawings[i].Rect);
                else
                    g.FillRectangle(brush, drawings[i].Rect);
            }
        }

        private void RadioSquare_CheckedChanged(object sender, EventArgs e)
        {
            TrackHeight.Value = TrackWidth.Value;
        }

        private void RadioCircle_CheckedChanged(object sender, EventArgs e)
        {
            TrackHeight.Value = TrackWidth.Value;
        }

        private void MenuPickColour_Click(object sender, EventArgs e)
        {
            if (ClrDialog.ShowDialog() == DialogResult.OK)
                MenuPickColour.BackColor = ClrDialog.Color;

        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            drawings.Clear();
            PanelDraw.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public struct Drawing
    {
        public Color Clr { get; set; }
        public Rectangle Rect { get; set; }
        public bool Rounded { get; set; }

        public Drawing(Rectangle r, Color c, bool round)
        {
            Rect = r;
            Clr = c;
            Rounded = round;
        }
    }
}