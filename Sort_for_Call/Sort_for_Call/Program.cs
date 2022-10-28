
//--------------------ERROR!!!!!!!!!!!!!!-----------------
using System;

namespace Sort_for_Call
{
    class Program
    {
        public static void Sorting()
        {
            int[] array = { 1, 23, 45, 13, 76, 44, 25, 4, 7, 10 };

            int temp = 0;

            for (int i = array.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
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
            Sorting();
        }
    }
}