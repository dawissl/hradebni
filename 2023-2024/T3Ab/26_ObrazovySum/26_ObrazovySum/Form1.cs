namespace _26_ObrazovySum
{
    public partial class Form1 : Form
    {
        private Bitmap img;
        private NoiseLib noiseLib = new NoiseLib();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(ofd.FileName);
                PictureDefault.Image = img;
            }
        }

        private void BtnSaltPepperNoise_Click(object sender, EventArgs e)
        {
            PictureEdit.Image = noiseLib.SaltAndPepper(img, 0.1, 0.04);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureEdit.Image = noiseLib.MedianFilter(img, 3);
        }
    }
}