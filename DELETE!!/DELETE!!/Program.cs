using System;
using System.Linq;

namespace Del
{
    class Program
    {
       public class Kotane
        {
            public static int[] PrintArray(int[] array, int x)
            {
                var res = new List<int>();

                foreach (var item in array)
                {
                    if (res.Count(i => i == item) < x)
                    {
                        res.Add(item);
                        Console.Write($" " + item);
                    }
                }
                return res.ToArray();
            }
        }

        public class Show : Kotane
        {
            public static int[] arr = { 1, 1, 2, 2, 3, 3, 3, 4, 6, 7, 8, 1, 9, 8, 8 };

            public static void Main(string[] args)
            {
                PrintArray(arr, 2);
            }
        }
    }
}
