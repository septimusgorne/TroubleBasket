using System;

namespace Input_Array_example
{
    class Program
    {
        static void Input_Array()
        {
            Console.Write("Введите количество элементов массива");

            int countArray = int.Parse(Console.ReadLine());

            int[] array = new int [countArray];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод элементов массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Находим минимальный элемент массива");

            int minValue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                minValue = array[i];
                if(array[i + 1] < minValue)
                    minValue = array[i];    
            }

            Console.WriteLine(minValue);
        }

        public static void Main(string[] args)
        {
            Input_Array();
        }
    }
}
