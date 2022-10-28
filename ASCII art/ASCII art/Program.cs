using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//accept librari 
using System.Drawing;
using System.IO;

namespace ASCII_art
{
    class Program
    {
        private const double WIDTH_OFFSET = 1.5;//const number scale bitmap1.5
        private const int MAX_WiDTH = 100;// const max size picture (350)474
        [STAThread]
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;   
            var openFileDialog = new OpenFileDialog//open file with reference WNiForm

            {
                Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG"// filter file type
            };
            Console.WriteLine("Press Enter to start...\n");

            while (true)
            {
                Console.ReadLine();//press Enter for wait

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    continue;

                Console.Clear();

                var bitmap = new Bitmap(openFileDialog.FileName);//picture in bitmap
                bitmap = ResizeBitmap(bitmap);//call method after open picture
                bitmap.ToGrayscale();// converting to Grace

                var converter = new BitmapToASCIIConverter(bitmap);
                var rows = converter.Convert();

                foreach (var row in rows)
                    Console.WriteLine(row);

                var rowNegative = converter.ConvertNegative();//FOR NEGATIVE
                //Save file(Using System.I.O;)
                File.WriteAllLines("Image.txt", rows.Select(r => new string(r)));

                Console.SetCursorPosition(0, 0);
            }
        }
            private static Bitmap ResizeBitmap(Bitmap bitmap)//resize bitmap
            {
            var newHeight = bitmap.Height / WIDTH_OFFSET * MAX_WiDTH/bitmap.Width;

            if (bitmap.Height > MAX_WiDTH|| bitmap.Height > newHeight)//if picture > maxWith than Resize
                bitmap = new Bitmap(bitmap, new Size(MAX_WiDTH, (int)newHeight));
            return bitmap;
            }
    }
}
