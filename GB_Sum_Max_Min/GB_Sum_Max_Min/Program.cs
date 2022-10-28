/*using System;

namespace Sum_Min_Between_Max
{
    class Program
    {
        public static void Main()
        {
            //Объявляем и инициализируем массив и переменную для подсчета суммы
            int[] array = { 1589, 342, 3, 43, 25, 16, 1, 99, 120, 4, 6 };
            int sum = 0;

            //Сортируем----------------------------------
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;

                    }
                    
                }
                
            }
            //Проверяем сортировку-----------------------
            Console.WriteLine("Отсортированные элементы массива:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\n{array[i]}");
            }
            //Вычисляем сумму от второго элемента(отсчет в массивах с нуля от минимального
            //до максимального, последний элемент не считаем(от последнего элемента отнимаем 1)
            for (int i = 1; i < array.Length - 1; i++)
            {
                sum = sum + array[i];
            }
            //Выводим максимальный элемент массива
            Console.WriteLine($"\tСумма элементов между MIN и Max: {sum}");
        }
    }
}*/

/*using System;

namespace Average_Array
{
    class Program
    {
        public static void Main()
        {
            int[] array = { 2, 4, 6 };
            int sum = 0;
            int res = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                res /= array.Length;
            }
            Console.WriteLine(res);
        }
    }
}*/

/*using System;

namespace Reverse_Array
{
    class Program
    {
        public static void Main()
        {
            int[] array = { 1589, 342, 3, 43, 25, 16, 1, 99, 120, 4, 6 };

            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}*/





/*Ближе к реальности 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//Кидаем на вход массив, хотя на практике скорее была бы коллекция List<object?>
int[] array = { 12, 15, 5, 19, 1, 8, 20, 4, 13, 19, 100 };

int max = array.Max();
int min = array.Min();

//Без Exception и проверок
var indexMax = Array.FindLastIndex(array, delegate (int i) { return i == max; });
var indexMin = Array.FindLastIndex(array, delegate (int i) { return i == min; });
Console.WriteLine($"Индекс максимального элемента: {indexMax}, Индекс минимального элемента: {indexMin}");

*/

/*using System.Diagnostics.CodeAnalysis;

namespace Search_Index_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -3, 4, -8, 0, 8 };

            int min, max, temp; 
                int sum =0 ;
            //Сортируем массив-------------------------------------
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                if (i == array.Length - 2)
                    Console.Write(array[i]);

                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
            /*
            //Выводим отсортированный массив----------------------
            foreach (int numb in array)
            {
                Console.WriteLine(numb);
            }
            //Находим индекс искомых чисел------------------------
            for (int i = 0; i < array.Length; i++)
            {
               if(i == 0)
                {
                    Console.WriteLine($"\nМинимальный элемент: {array[i]}");
                }
               if(i == array.Length - 1)
                {
                    Console.WriteLine($"Максимальный элемент: {array[i]}");
                }
            }
            Console.ReadLine();*/
// }
// }
//}




/*namespace Sum_Min_Max
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 18, 15, 5, 19, 2, 8, 20, 0, 4, 13, 99, 19, 108 };

            int min = array[0];
            int max = array[0];
            int sum = 0; 
            int imin = 0;
            int imax = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i]; 
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                {
                    imin = i + 1;
                    Console.WriteLine($"Индекс мин.элемента: {i}");
                }
                if(array[i] == max)
                {
                    imax = i;
                    Console.WriteLine($"Индекс макс.элемента: {i}");
                }
            }

            for (int i = imin; i < imax; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"Сумма элементов между макс. и мин. : {sum}");
            Console.WriteLine($"Минимальный элемент массива: {min}");
            Console.WriteLine($"Максимальный элемент массива: {max}");



            Console.ReadLine();
        }
    }
}*/







/*using System;
using System.Diagnostics.CodeAnalysis;

namespace Yest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[100];
            int i = 0;
            //string test;
            int count = 0;
            
            Console.WriteLine("Введите элементы массива, после ввода" +
                    "всех елементов напишите end");
            do
            {
                test = Console.ReadLine();
                if (test == "end") break;
                mas[i] = Convert.ToInt32(test);
                ++i; ++count;
            } while (true);

            Console.WriteLine("Вывод массива: ");
            for (int j = 0; j < count; j++)
            {
                Console.Write("{0} ", mas[j]);
            }

            for (int s = 0; s < mas.Length; s++)
            {
                int sum = mas[s];
                Console.WriteLine(sum);
            }
        }
    }
}*/

//using System;

/*namespace Average_Array
{
    class Program
    {
        public static void Main()
        {
            int[] array = { 2, 4, 6 };
            int sum = 0;
            int res = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                res = sum / array.Length;
            }
            Console.WriteLine(res);
        }
    }
}*/

namespace Search_Index_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;

            Console.WriteLine("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 2; i++)
            {
                int sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
            Console.WriteLine($"Значение этого элемента: {num2}");
        }
    }
}

