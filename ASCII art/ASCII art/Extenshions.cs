using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_art
{
    public static class Extenshions 
    {
        public static void ToGrayscale(this Bitmap bitmap)//Color to Grace
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var pixel = bitmap.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;//RED GREEN BLUE
                    bitmap.SetPixel(x, y, Color.FromArgb(pixel.A, avg, avg, avg));//ALPHA channel(transparency) ,AVERAGE COLOR
                }
            }
        }
    }
}
