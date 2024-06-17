using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _26_ObrazovySum
{
    public class NoiseLib
    {
        private Random rnd = new Random();

        public Bitmap SaltAndPepper(Bitmap img, double salt, double pepper)
        {
            Bitmap newImage = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    double noise = rnd.NextDouble();
                    if (noise < salt)
                    {
                        newImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        if (noise < salt + pepper)
                        {
                            newImage.SetPixel(x, y, Color.Black);
                        }
                        else
                        {
                            newImage.SetPixel(x, y, img.GetPixel(x, y));
                        }
                    }
                }
            }
            return newImage;
        }

        public Bitmap MedianFilter(Bitmap img, int maskWidth)
        {
            Bitmap newImage = new Bitmap(img.Width, img.Height);
            int offset = maskWidth / 2;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int[] mask = new int[maskWidth * maskWidth];
                    int index = 0;
                    for (int px = -offset; px <= offset; px++)
                    {
                        for (int py = -offset; py <= offset; py++)
                        {
                            int mx = x + px;
                            int my = y + py;
                            if (mx < 0 || my < 0 ||
                                mx > img.Width - 1 || my > img.Height - 1)
                            {
                                mask[index] = 0;
                            }
                            else
                            {
                                mask[index] = img.GetPixel(mx, my).R;
                            }
                            index++;
                        }
                    }
                    Array.Sort(mask);
                    int median = mask[mask.Length / 2];
                    newImage.SetPixel(x, y, Color.FromArgb(median, median, median));
                }
            }



            return newImage;
        }
    }
}
