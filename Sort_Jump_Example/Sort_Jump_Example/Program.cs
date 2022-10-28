using System;

namespace Search_Jump
{
    class Program
    {

        static int[] array = { 5, 7, 10, 14, 15, 19, 23, 25, 33, 38, 42, 49, 55, 68, 69, 99 };
        public static int Jump_Search()
        {
            int N = (int)Math.Sqrt(array.Length);
            int left = array[0];
            //int right = array.Length;

            //int num = 14;
            int sum = 0;

            int i = 0;
            while (i < N)
            {
                if ((array[i]) % 2 == 0)
                {
                    sum += array[i];
                }
                i++;
                sum = i;

            }
            Console.WriteLine(sum);
            return sum;
        }


        public static void Main(string[] args)
        {
            Jump_Search();
        }
    }
}