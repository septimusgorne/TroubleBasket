using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASCII_art
{
    public class BitmapToASCIIConverter//converter picture for ASCII
    {
        private readonly char[] _asciiTableNegative = { '.', ',', ':', '+', '*', '?', '%', '$', '#', '@' };
        private readonly char[] _asciiTable = { '@', '#', '$', '%', '?', '*', '+', ':', ',', '.' };
        //char[] _asciiTable = { '.', ',',':', '+', '*', '?', '%', '$', '#', '@' };
        //char[] _asciiTable = { '@', '#', '$', '%', '?', '*', '+', ':', ',', '.' };
        private readonly Bitmap _bitmap;

        public BitmapToASCIIConverter(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        public char[][] Convert()
        {
            return Convert(_asciiTable);
        }

        public char[][] ConvertNegative()
        {
            return Convert(_asciiTableNegative);
        }


        private char[][] Convert(char[] asciiTable)
        {
            var result = new char[_bitmap.Height][];

            for (int y = 0; y < _bitmap.Height; y++)
            {
                result[y] = new char[_bitmap.Width];
                for (int x = 0; x < _bitmap.Width; x++)
                {
                    int mapIndex = (int)Map(_bitmap.GetPixel(x, y).R, 0, 255, 0, _asciiTable.Length - 1);
                    result[y][x] = asciiTable[mapIndex];//convert insex ascii(assign index)
                }
            }
            return result;
        }

        private float Map(float valueToMap, float start1, float stop1, float start2, float stop2)//value from one range to another range
        {
            return((valueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
    }
}
