
using System.Threading.Channels;

namespace _27_Greyscale
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        private bool loaded;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenImageDialog = new OpenFileDialog();
            if (OpenImageDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(OpenImageDialog.FileName);
                PictureDefault.Image = image;
                loaded = true;
            }

        }

        private void ComoGreyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded)
            {
                MessageBox.Show("Nejprve naètìte barevný obrázek");
                ComoGreyFilter.SelectedIndex = -1;
                return;
            }
            switch(ComoGreyFilter.SelectedIndex)
            {
                case 0:
                    PictureGrey.Image = ChannelGrey(image,"red");
                    break;
                    case 1:
                    PictureGrey.Image = ChannelGrey(image, "green");
                    break;
                    case 2:
                    PictureGrey.Image = ChannelGrey(image, "blue");
                    break;
                    case 3:
                    PictureGrey.Image = AverageGrey(image);
                    break;
            }
        }

        public Bitmap AverageGrey(Bitmap img)
        {
            Bitmap newImage = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color clr = img.GetPixel(x, y);
                    int avg = (clr.R + clr.G + clr.B)/3;
                    newImage.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }
            return newImage;
        }

        public Bitmap ChannelGrey(Bitmap img, string channel)
        {
            Bitmap newImage = new Bitmap(img.Width,img.Height);
            for(int x = 0; x < img.Width; x++)
            {
                for (int y=0; y < img.Height; y++)
                {
                    Color clr = img.GetPixel(x,y);
                    switch (channel.ToUpper())
                    {
                        case "RED":
                            newImage.SetPixel(x, y, Color.FromArgb(clr.R, clr.R, clr.R));
                            break;
                        case "GREEN":
                            newImage.SetPixel(x, y, Color.FromArgb(clr.G, clr.G, clr.G));
                            break;
                        case "BLUE":
                            newImage.SetPixel(x, y, Color.FromArgb(clr.B, clr.B, clr.B));

                            break;
                    }
                }
            }
            return newImage;
        }
    }
}
