using System;
using System.Collections.Generic;


namespace Example_LINQ_COPY_VSCODE
{
    class Program
    {
        public static void Main(string[] args)
        {
            LambdaExpressionSyntax();
        }
        static void LambdaExpressionSyntax()
        {
            List<int> arrList = new List<int>();
            arrList.AddRange(new int[] { 2, 15, 53, 75, 64, 233, 1245 });
            List<int> evenNumbers = arrList.FindAll(i => (i % 2) == 0);

            //Numbers %2 == 0 for example Linq
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
    }
}