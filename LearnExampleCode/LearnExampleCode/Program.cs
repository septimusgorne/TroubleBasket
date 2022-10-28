using ProgramExample;
using System;
using System.Drawing;



namespace ProgramExample
{
    class BitFigure
    {
        public static char dateChar = '$';
        public char[] arrayChar = { '^', '%', '#' };

        public int rows;
        public int cols;

        

        

        public static void Count(int numCount)
        {
            /*for (int i = 0; i <= numCount; i++)
            {
                Console.Write(i);
            }*/
            int x = 0;
            while (x <= numCount)
                x++;
            Console.Write(x);

            /*for (int i = 0; i < numCount; i++)
            {
                for (int x = numCount; x < i; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine(" ");
                Console.Write(i);
            }*/

        }

        public static void TriangleD(int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write('$');
                }
            }
        }

        public static void Ex()
        {
            int i, j, n;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");
            Console.Write("----------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows for this pattern :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }

        public static void Print1()
        {
            for (int x = 0; x <= 9; x++)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        public static void BLABLA()
        {
            for (int x = 0; x <= 9; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write("*");
                }
            }
        }


        public static void DrawTriangle(int rows, int startCount)
        {
            for (int x = startCount; x <= rows; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write("&");
                }
                Console.WriteLine();
            }
        }

        public static void TriangleExample()
        {
            for (int row = 1; row <= 6; row++)
            {
                for (int y = 0 ; y < row; y++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

        public static void DrawQuad(int rows, int cols)
        {
                for (int x = 1; x <= rows; x++)
                {
                    Console.Write("%");
                    for (int y = 1; y <= cols; y++)
                    {
                        Console.Write(" ");
                        Console.Write("*");

                        if (y == cols)
                            {
                                Console.Write("%");
                            }
                        while(rows < cols)
                        rows++;
                    }
                    Console.WriteLine();
                }
        }


        public static void Mels()
        {
            int n;
            Console.WriteLine("\nВведите максимальную длинну элементов пирамиды: ");
            n = Convert.ToInt32(Console.ReadLine());


            /*for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }*/

            int cosX = 10;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i - cosX; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
            }
        }
        
         
        
    class Program
        {
            public static void Main(string[] args)
            {
                //BitFigure.DrawQuad(5, 5);
                //BitFigure.DrawTriangle(8, 1);
                //Bitmap.Print1();
                //BitFigure.DrawPon();
                //BitFigure.NumberCount(5);
                //BitFigure.Count(5);
                //BitFigure.TriangleD(4,8);
                //BitFigure.Ex();
                //BitFigure.BLABLA();
                //BitFigure.TriangleExample();
                BitFigure.Mels();
            }
        }
    }
}
