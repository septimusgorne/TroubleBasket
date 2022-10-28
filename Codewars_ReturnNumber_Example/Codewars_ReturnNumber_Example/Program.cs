using System;

namespace Codewars_ReturnNumber
{
    class Program
    {

        static int[] array = { 1, 1, 3, 3, 7, 2, 2, 2, 2 };

        //static List<int> array = new List<int> { 4, 1, 2, 3, 1, 2, 1, 2, 3 };
        public static void TryNumber(int num)
        {
            //IEnumerable<int> evens = array.Where(i => array[i] == array[i]);

            /*IEnumerable <int> evens = from i in array
                               where array[i] == array[i]
                               select i;*/

            //var returnArray = array.Where(i => i % 2 == 0);

            //var returnNumber = array.Where(i => i + 1 ==i);

            //int buf = 0;

            /*for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                        if (array[i] < array[j])
                        {
                            buf = array[i];
                            array[i] = array[j];
                            array[j] = buf;
                        }
                }
            }*/
            //----------------Sorting

            /*int maxNumber = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                    maxNumber = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length ; j++)
                {
                        if (array[i] == array[j])
                        {
                            //maxNumber = 0;
                            //array[j] = maxNumber;
                        }
                }
            }*/


            /*for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (array[i].Count <= num)
                        Console.WriteLine(array[j]);
                        //maxNumber = 0;
                        //array[j] = maxNumber;
                        //array.DistinctBy(j, num);
                        //array.GroupBy(j, j);
                        //array.RemoveAt(j);
                        //--j;
                    }
                }
            }*/


            //var result = array.Where(d => array.Count(d1 => d1 == d) == 2);
            //var result = array.GroupBy(s => s).Where(g => g.Count() == 2).Select(g => g.Key);
            //var result = array.GroupBy(s => s).Where(g => g.Count() <= 2).Select(g => g.Key);

            //var result = array.Where(i =>  array.Count(i1 => i1 == i) <= num);


            /*for (int i = 0; i < array.Count; i++)
            {
                if(array.Count(d => d == i) == 2)
                {
                    for (int j = 0; j < array.Length; j++)
                    {

                    }
                }
            }*/

            //int[] newArray = new int[array.Lengtha];

            //int[] newArray = array.Distinct().ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                            
                    }
                }
            }





            foreach (var item in result)
            {
                Console.Write($"  " + item);
            }
        }

       /* static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(3);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    RemoveAt(ref arr, i);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {

            }
        }
    }*/

        public static void Main(string[] args)
        {
            TryNumber(3);
            //RemoveAt(ref array, 2);
        }
    }
}