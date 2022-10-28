using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/*int main()
{
    float A = 0, B = 0;
    float i, j;
    int k;
    float z[1760];
    char b[1760];
    printf("\x1b[2J");
    for (; ; )
    {
        memset(b, 32, 1760);
        memset(z, 0, 7040);
        for (j = 0; j < 6.28; j += 0.07)
        {
            for (i = 0; i < 6.28; i += 0.02)
            {
                float c = sin(i);
                float d = cos(j);
                float e = sin(A);
                float f = sin(j);
                float g = cos(A);
                float h = d + 2;
                float D = 1 / (c * h * e + f * g + 5);
                float l = cos(i);
                float m = cos(B);
                float n = sin(B);
                float t = c * h * g - f * e;
                int x = 40 + 30 * D * (l * h * m - t * n);
                int y = 12 + 15 * D * (l * h * n + t * m);
                int o = x + 80 * y;
                int N = 8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n);
                if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
                {
                    z[o] = D;
                    b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                }
            }
        }
        printf("\x1b[H");
        for (k = 0; k < 1761; k++)
        {
            putchar(k % 80 ? b[k] : 10);
            A += 0.00004;
            B += 0.00002;
        }
        usleep(30000);
    }
    return 0;
}*/
namespace HaveADonate
{
     class Program
    {
        static void Main(string[] args)
        {
            {
                Console.SetCursorPosition(0, 0);
                float A = 0, B = 0;
                float i, j;
                int k;
                float[] z = new float[1760];
                float[] b = new float[1760];

                //float z = 1760; //[1760];
                //char b = 1760; [1760];
                Console.Write("\x1b[2J");
                /*for (; ; )
                {
                    memset(b, 32, 1760);
                    memset(z, 0, 7040);*/
                    for (j = 0; j < 6.28; j++) //j += 0.07)
                    {
                        for (i = 0; i < 6.28; i++)//i += 0.02)
                        {
                            float c = (float)Math.Sin(i);
                            float d = (float)Math.Cos(j);
                            float e = (float)Math.Sin(A);
                            float f = (float)Math.Sin(j);
                            float g = (float)Math.Cos(A);
                            float h = d + 2;
                            float D = 1 / (c * h * e + f * g + 5);
                            float l = (float)Math.Cos(i);
                            float m = (float)Math.Cos(B);
                            float n = (float)Math.Sin(B);
                            float t = c * h * g - f * e;
                            int x = (int)( 40 + 30 * D * (l * h * m - t * n));
                            int y = (int)(12 + 15 * D * (l * h * n + t * m));
                            int o = x + 80 * y;
                            int N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));
                            if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
                            {
                                z[o] = D;
                                b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                            }
                        }
                    }
                    Console.Write("\x1b[H");
                    for (k = 0; k < 1761; k++)
                    {
                        if (k % 80 > 10)
                        {
                        Console.Write(b[k]);
                        }
                    Console.Write(b[k]/10);
                        A = (float)(A + 0.00004);
                        B = (float)(B + 0.00002);

                        //putchar(k % 80 ? b[k] : 10);
                        //A += 0.00004);
                        //B += 0.00002;
                    }
                    Thread.Sleep(300);
            }
        }
    }
}
