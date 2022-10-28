using System;


namespace Sort_Binary
{
    class Program
    {

        public static int Binary_Sort(int num)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            /*List<int> list = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };*/

            int left = array[0];
            int right = array.Length;
            //int num = int.Parse(Console.ReadLine());


            while (true)
            {
                int mid = (left + right) / 2;
            if (array[mid] < num)
                        left = mid;
                if (array[mid] > num)
                    right = mid;
                else if (array[mid] == num)
                    return mid;
            Console.WriteLine(array[mid]);
            }
            return -1;
        }
        

        public static void Main(string[] args)
        {

            Binary_Sort(6);
        }
    }
}

