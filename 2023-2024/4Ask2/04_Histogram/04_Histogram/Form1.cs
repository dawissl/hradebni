using System.Runtime.ConstrainedExecution;

namespace _04_Histogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] image;

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            image = new int[(int)NumHeight.Value, (int)NumWidth.Value];
            Random rnd = new Random();
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    image[i, j] = rnd.Next(0, 256);
                }
            }
            PanelImage.Refresh();
            PanelHist.Refresh();
            PanelHist.Refresh();

        }

        private void PanelImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (image == null) return;

            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    int clr = image[i, j];
                    SolidBrush stetec = new SolidBrush(Color.FromArgb(clr, clr, clr));
                    graphics.FillRectangle(stetec, i, j, 1, 1);
                }
            }

        }

        private void PanelHist_Paint(object sender, PaintEventArgs e)
        {
            if (image == null) return;

            int[] histogram = new int[256];

            foreach (int pixel in image)
            {
                histogram[pixel]++;
            }
            Graphics graphics = e.Graphics;
            int max = histogram.Max();
           for (int x = 0; x < histogram.Length; x++)
            {
                int y = (histogram[x] * 100) / max;
                SolidBrush stetec = new SolidBrush(Color.FromArgb(x, x, x));
                graphics.FillRectangle(stetec, x, PanelHist.Height - y, 1, y);
            }
        }
    }
}