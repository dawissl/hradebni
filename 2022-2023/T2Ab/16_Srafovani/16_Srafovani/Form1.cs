using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace _16_Srafovani
{

    public partial class Form1 : Form
    {
        private Brush background = new SolidBrush(Color.Blue);
        private Pen foreground = new Pen(Color.Yellow,3);
        private int step = 10;
        public Form1()
        {
            InitializeComponent();
            LblBackground.BackColor = Color.Blue;
            LblForeground.BackColor = Color.Yellow;
        }

        private void PanelRect_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int rectSize = 400;
            g.FillRectangle(background, 0, 0, rectSize, rectSize);

            
            for (int i = rectSize; i >= 0; i -= step)
            {
                g.DrawLine(foreground, new Point(rectSize - i, 0), new Point(0, rectSize - i));
            }

            for (int i = step; i <= rectSize; i += step)
            {
                g.DrawLine(foreground, new Point(rectSize, i), new Point(i, rectSize));
            }
        }

        private void LblBackground_Click(object sender, EventArgs e)
        {
            if(ClrDialog.ShowDialog() == DialogResult.OK)
            {
                LblBackground.BackColor = ClrDialog.Color;
                background = new SolidBrush(ClrDialog.Color);
                PanelRect.Refresh();
            }
        }

        private void LblForeground_Click(object sender, EventArgs e)
        {
            if (ClrDialog.ShowDialog() == DialogResult.OK)
            {
                LblForeground.BackColor = ClrDialog.Color;
                foreground = new Pen(ClrDialog.Color,3);
                PanelRect.Refresh();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            step = (int)numericUpDown1.Value;
            PanelRect.Refresh();
        }
    }
}