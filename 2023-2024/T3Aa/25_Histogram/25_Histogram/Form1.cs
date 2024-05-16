namespace _25_Histogram
{
    public partial class Form1 : Form
    {
        private Bitmap img;
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                img = new Bitmap(ofd.FileName);
                PictureImage.Image = img;
            }
        }

        private void PanelHist_Paint(object sender, PaintEventArgs e)
        {
            if (img == null) return;
            // spoètení histogramu
            int[] histR = new int[256];
            int[] histG = new int[256];
            int[] histB = new int[256];
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color px = img.GetPixel(x, y);
                    histR[px.R]++;
                    histG[px.G]++;
                    histB[px.B]++;
                }
            }
            Graphics g = e.Graphics;
            // sloupeèky
            for (int i = 0; i < histR.Length; i++)
            {
                g.FillRectangle(Brushes.Red, 2 * i, PanelHist.Height - histR[i] / 8, 2, histR[i] / 8);
                g.FillRectangle(Brushes.Green, 2 * i, PanelHist.Height - histG[i] / 8, 2, histG[i] / 8);
                g.FillRectangle(Brushes.Blue, 2 * i, PanelHist.Height - histB[i] / 8, 2, histB[i] / 8);
            }
           /* // spojita èára
            Point[] h = new Point[256];
            for (int x = 0; x < h.Length; x++)
            {
                h[x] = new Point(2 * x, PanelHist.Height - histG[x] / 16);
            }
            Point[] h2 = new Point[256];
            for (int x = 0; x < h.Length; x++)
            {
                h2[x] = new Point(2 * x, PanelHist.Height - histB[x] / 16);
            }
            g.DrawLines(Pens.Green, h);
            // polygon
            g.FillPolygon(Brushes.Blue, h2);*/
        }

        private void MenuHistogram_Click(object sender, EventArgs e)
        {
            PanelHist.Refresh();
        }

        private void TresholdBar_Scroll(object sender, EventArgs e)
        {
            int treshold = TresholdBar.Value;
            Bitmap newimg = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < newimg.Width; x++)
            {
                for (int y = 0; y < newimg.Height; y++)
                {
                    if (img.GetPixel(x, y).R <= treshold)
                    {
                        newimg.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        newimg.SetPixel(x, y, Color.Black);
                    }
                }
            }
            PictureImage.Image = newimg;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PictureImage.Image = img;
        }
    }
}
