using System;

namespace Sort_Bubble_Example1
{
    class Program
    {
        static int[] array = { 1454, 222, 323, 68, 9, 76, 34, 2, 28, 37};
        public static void CallSort()
        {
            int buff;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        buff = array[i];
                        array[i] = array[j];
                        array[j] = buff;
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
            CallSort();
        }
    }
}