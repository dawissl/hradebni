namespace _25_Histogram
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void naètiObrázekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
                PicImg.Image = image;
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelHist.Refresh();
        }

        private void PanelHist_Paint(object sender, PaintEventArgs e)
        {
            if (image == null) return;
            int[] histR = new int[256];
            int[] histG = new int[256];
            int[] histB = new int[256];
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    histR[image.GetPixel(x, y).R]++;
                    histG[image.GetPixel(x, y).G]++;
                    histB[image.GetPixel(x, y).B]++;
                }
            }
            Graphics g = e.Graphics;

            // vykreslení histogramu jako sloupce
            for (int x = 0; x < histR.Length; x++)
            {
                g.FillRectangle(Brushes.Red, 2 * x, PanelHist.Height - histR[x] / 8, 2, histR[x] / 8);
                g.FillRectangle(Brushes.Green, 2 * x, PanelHist.Height - histG[x] / 8, 2, histG[x] / 8);
                g.FillRectangle(Brushes.Blue, 2 * x, PanelHist.Height - histB[x] / 8, 2, histB[x] / 8);
            }
            //vykreslení jako spojitá èára
            Point[] p = new Point[256];
            for(int x=0; x < histR.Length; x++)
            {
                p[x] = new Point(x * 2, PanelHist.Height - histR[x] / 8);
            }
            //g.DrawLines(Pens.Green, p);
            //vykresleni jako polygon
            //g.FillPolygon(Brushes.Blue, p);
        }

        private void TrackTreshold_Scroll(object sender, EventArgs e)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);
            int threshold = TrackTreshold.Value;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y).R < threshold)
                    {
                        newImage.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        newImage.SetPixel(x, y, Color.White);
                    }
                }
            }
            

            PicImg.Image = newImage;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PicImg.Image = image;
        }
    }
}