using System.Drawing.Imaging;

namespace Histogram
{
    public partial class Form1 : Form
    {
        Bitmap img;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(opf.FileName);
                if (!IsGrayscale(img))
                {

                    img = ConvertTo8bit(img);
                }
                pictureBox1.Image = img;
            }
        }

        private Bitmap ConvertTo8bit(Bitmap img)
        {
            Bitmap grayscale = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
            using (Graphics g = Graphics.FromImage(grayscale))
            {
                g.DrawImage(img, 0, 0, img.Width, img.Height);
            }
            return grayscale;
        }

        private bool IsGrayscale(Bitmap img)
        {
            return img.PixelFormat == System.Drawing.Imaging.PixelFormat.Format8bppIndexed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] histogram = new int[256];
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color px = img.GetPixel(x, y);
                    histogram[px.R]++;
                }

            }
            string s = "";
            foreach(int x in histogram)
            {
                s += $"{x}, ";
            }
            MessageBox.Show(s);
        }
    }
}