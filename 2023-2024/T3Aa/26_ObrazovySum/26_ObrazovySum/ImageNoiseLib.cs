using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_ObrazovySum
{
    public class ImageNoiseLib
    {
        private Random rnd = new Random();
        public Bitmap SaltAndPepper(Bitmap img, double salt, double pepper)
        {
            Bitmap newImg = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < newImg.Width; x++)
            {
                for (int y = 0; y < newImg.Height; y++)
                {
                    double noiseProbability = rnd.NextDouble();
                    if (noiseProbability < salt)
                    {
                        newImg.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        if (noiseProbability < salt + pepper)
                        {
                            newImg.SetPixel(x, y, Color.Black);
                        }
                        else
                        {
                            newImg.SetPixel(x, y, img.GetPixel(x, y));
                        }
                    }
                }
            }
            return newImg;
        }

        public Bitmap UniformNoise()
        {
            throw new NotImplementedException();
        }

        // reduce salt and pepper noise
        public Bitmap MedianFilter(Bitmap img, int maskSize)
        {
            Bitmap newImg = new Bitmap(img);
            int framesize = maskSize / 2;
            for (int x = 0; x < newImg.Width; x++)
            {
                for (int y = 0; y < newImg.Height; y++)
                {
                    int[] mask = new int[maskSize * maskSize];
                    int maskIndex = 0;
                    for (int fx = -framesize; fx <= framesize; fx++)
                    {
                        for (int fy = -framesize; fy <= framesize; fy++)
                        {
                            int px = x + fx;
                            int py = y + fy;
                            if (px < 0 || py < 0 ||
                                px > newImg.Width - 1 || py > newImg.Height - 1)
                            {
                                mask[maskIndex] = 0;
                            }
                            else
                            {
                                mask[maskIndex] = img.GetPixel(px, py).R;
                            }
                            maskIndex++;
                        }
                    }
                    Array.Sort(mask);
                    int median = mask[mask.Length / 2];
                    newImg.SetPixel(x, y, Color.FromArgb(median, median, median));

                }
            }
            return newImg;
        }
    }
}
