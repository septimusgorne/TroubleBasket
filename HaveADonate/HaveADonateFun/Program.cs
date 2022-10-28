using System;
using System.Threading;

namespace HaveADonuteFun
{
        class Program
        {
            static double A = 1;
            static double B = 1;

            static void Main(string[] args)
            {
                int height, radius, speed;
            Console.Write("\n\n");
            Console.Write("------------------------------------------------------------------------");
            Console.Write("\n\n");
            
            Console.Write("Введите радиус Donute: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите толщину Donute: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите скорость вращения Donute: ");
            speed = Convert.ToInt32(Console.ReadLine());
            while (true)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.CursorVisible = false;
                    A += 0.07;
                    B += 0.03;

                    double cA = Math.Sin(A);
                    double sA = Math.Cos(A);//Sin(A)

                    double cB = Math.Sin(B);
                    double sB = Math.Cos(B);

                    char[] b = new char[1760];//1760
                    double[] z = new double[1760];

                    for (int k = 0; k < 1760; k++)
                    {
                        b[k] = k % 80 == 79 ? '\n' : ' ';
                        z[k] = 0;
                    }

                    for (double j = 0; j < 6.28; j += 0.07)
                    {
                        // j <=> theta
                        double ct = Math.Cos(j),//Cos(j)
                                st = Math.Sin(j);//Sin(j)
                        for (double i = 0; i < 6.28; i += 0.02)
                        {
                            // i <=> phi
                            double sp = Math.Sin(i),
                                    cp = Math.Cos(i),
                                    h = ct + 2 * (radius), // R1 + R2*cos(theta) 
                                    D = 1 / (sp * h * sA + st * cA + 5) , // this is 1/z
                                    t = sp * h * cA - st * sA * (height); // this is a clever factoring of some of the terms in x' and y'

                            int x = (int)(40 + 30 * D * (cp * h * cB - t * sB)),
                                    y = (int)(12 + 15 * D * (cp * h * sB + t * cB)),
                                    N =(int)(8 *
                                                ((st * sA - sp * ct * cA) * cB -
                                                sp * ct * sA -
                                                st * cA -
                                                cp * ct * sB)),
                                    o = x + 80 * y;
                            if (y < 22 && y >= 0 && x >= 0 && x < 79 && D > z[o])
                            {
                                z[o] = D;
                                b[o] = ".,-~:;=!*#$@".ToCharArray()[Math.Max(N, 0)];
                            }
                        }
                    }

                    Console.WriteLine(b);

                    Thread.Sleep(speed);

                    Console.Clear();


                }
            }
        }
}
