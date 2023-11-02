namespace _04_Histogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] image;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            /// Deklarace dvourozmìrného pole dle vstupu od uživatele
            image = new int[(int)NumWidth.Value, (int)NumHeight.Value];
            Random rnd = new Random();

            /// Plnìní dvourozmìrného pole hodnotou v intervalu <0,255> 
            for (int x = 0; x < image.GetLength(0); x++)
            {
                for (int y = 0; y < image.GetLength(1); y++)
                {
                    image[x, y] = rnd.Next(0, 256);
                }
            }
            PanelImage.Refresh();
            PanelHistogram.Refresh();
        }

        private void PanelImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (image == null) return;

            for (int x = 0; x < image.GetLength(0); x++)
            {
                for (int y = 0; y < image.GetLength(1); y++)
                {
                    int clr = image[x, y];
                    SolidBrush stetec = new SolidBrush(Color.FromArgb(clr, clr, clr));

                    g.FillRectangle(stetec, x, y, 1, 1);

                }
            }




        }

        private void PanelHistogram_Paint(object sender, PaintEventArgs e)
        {
            int[] histogram = new int[256];
            if (image == null) return;
            for (int x = 0; x < image.GetLength(0); x++)
            {
                for (int y = 0; y < image.GetLength(1); y++)
                {
                    int tmp = image[x, y];
                    histogram[image[x, y]]++;
                }
            }

            Graphics grf = e.Graphics;
            for (int i = 0; i < histogram.Length; i++)
            {
                grf.FillRectangle(Brushes.Black, i, PanelHistogram.Height - histogram[i], 1, 1);
            }
        }

        public int[] Funkce(int a, int b, string s)
        {
            return new int[a];
        }
    }
}