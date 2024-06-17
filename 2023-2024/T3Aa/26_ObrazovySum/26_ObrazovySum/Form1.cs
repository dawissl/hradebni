namespace _26_ObrazovySum
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        private ImageNoiseLib imgNoise = new ImageNoiseLib();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (OpenImageDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(OpenImageDialog.FileName);
                pictureOriginal.Image = image;
            }
        }

        private void BtnSaltPepper_Click(object sender, EventArgs e)
        {
            pictureEdit.Image = imgNoise.SaltAndPepper(image, 0.02, 0.03);
        }

        private void BtnMedianFilter_Click(object sender, EventArgs e)
        {
            pictureEdit.Image = imgNoise.MedianFilter(image,3);
        }
    }
}
