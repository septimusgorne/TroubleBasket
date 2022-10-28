using System;
using System.Collections.Generic;
using System.Collections;

namespace Array_Collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = { "inere", "coins", "alias", "random", "secans" };

            Console.WriteLine("This array has {0} items.", arr.Length);

            foreach (string item in arr)
            {
                Console.WriteLine("Array Entry: {0}", item);
            }
            Console.WriteLine();

            Array.Reverse(arr);

            foreach (string item in arr)
            {
                Console.WriteLine("Array Entry: {0}", arr);
            }
            Console.ReadLine();
        }
    }
}