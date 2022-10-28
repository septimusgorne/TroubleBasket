using System;

namespace Sort_Jump_TryAgain
{
    class Program
    {
        static int[] array = {12, 22, 24, 33, 35, 47, 48, 55, 59, 60, 66, 72, 76, 77, 79, 82};
        public static int SearchJump_Mod2()
        {
            //mod += mod % 2;
            int N = (int)Math.Sqrt(array.Length);
            int i = 0;
            int sum = i;

           for (int j = N; j <= array.Length; j++)
            {
                if (i < N)
                {
                    if (array[i] % 2 == 0)
                    {
                        sum += array[i];
                        Console.WriteLine("Суммируемое число: " + array[i]);
                    }
                    i++;
                }
                N = array[0];

                if (array[i] != i)
                    Console.WriteLine("\tПроверяется число" + array[i]);
            }
            Console.WriteLine("Сумма всех четных элементов: " + sum);
            Console.WriteLine("\n\t Общая длинна массива: " + array.Length);
            Console.WriteLine("\n\t Последний элемент массива: " + array[array.Length -1]);
            return sum;

        }

        public static void Main(string[] args)
        {
            SearchJump_Mod2();
        }
    }
}