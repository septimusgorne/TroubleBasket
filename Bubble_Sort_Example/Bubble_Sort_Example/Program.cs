using System;

namespace Buble_Sort
{
    class Program
    {

        static int[] array = {1, 24, 10, 111, 25, 8, 7, 99, 5 };
        public static void Sort()
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;    
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Main(string[] args)
        {
            Sort();
        }
    }
}
