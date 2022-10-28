using System;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace GB_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Cube_Numbers();//23_Cube_Numbers
            //Coordinates_Delta();//21_Coordinates_Delta
            TryIsPalindrom();
        }

        static void Cube_Numbers()
        {
            int numb;
            int i = 1;

            Console.WriteLine("Введите число: ");
            int.TryParse(Console.ReadLine(), out numb);
            while(i <= numb)
            {
                Console.WriteLine($"Куб числа {i}: \n {Math.Pow(i, 3)}");
                i++;   
            } 
        }
        static void Coordinates_Delta()
        {
            char Numb_Coordinate;
            double x1, y1, x2, y2, z1, z2, delta;

            Console.Write("Нажмите Enter и введите координаты");
            char.TryParse(Console.ReadLine(), out Numb_Coordinate);

                    Console.WriteLine("Введите координаты A(x): ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                
                    Console.WriteLine("Введите координаты A(y): ");
                    y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координаты A(z): ");
                    z1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координаты B(x): ");
                    x2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координаты B(y): ");
                    y2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите координаты B(z): ");
                    z2 = Convert.ToDouble(Console.ReadLine());
 
            delta = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"Дистанция между точками равна: {Math.Round(delta, 2)}");
        }

        static void TryIsPalindrom()
        {
        /*start_Try:
        int numb = 0;
        int numbRev = 0;
        int numbFirst = 0;
        int numbMem = numb;
        Console.WriteLine("Введите число для проверки");
        int.TryParse(Console.ReadLine(), out numb);

        while(numb < 0)
        {
            var cureDig = numbMem % 10;
            numbRev = numbRev * 10 + cureDig;
            numb /= 10;
        }
        if(numbRev == numb)
        {
            Console.WriteLine("Палиндром");
            goto start_Try;
        }
        else
        {
            Console.WriteLine("Не палиндром");
            goto start_Try;
        }*/

            start_Try:
            int number;
            Console.WriteLine("Введите число для проверки");
            int.TryParse(Console.ReadLine(), out number);

            int oldValue = number;
            int newValue = 0;
            while (number > 0)
            {
                int dig = number % 10;
                newValue = newValue * 10 + dig;
                number = number / 10;
            }
            if (newValue == oldValue)
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом");
            goto start_Try;
            /*if (numb < 0 || (numb % 10 == 0 && numb != 0))
                //Console.WriteLine("не палиндром");
                return false;

            int reverNumb = 0;
            while(numb > reverNumb)
            {
                reverNumb = reverNumb * 10 + numb % 10;
                numb /= 10;
            }
            return numb == reverNumb || numb == reverNumb;*/

        }
    }
}
