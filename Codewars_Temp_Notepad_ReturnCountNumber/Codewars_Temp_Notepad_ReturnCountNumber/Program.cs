using System;
using System.Linq;

namespace Return_Number
{
    public class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = new List<int>();

            foreach (var item in arr)
            {
                if (result.Count(i1 => i1 == item) < x)
                {
                    result.Add(item);
                    Console.Write($" " + item);
                }
            }
            
            return result.ToArray();
        }
    }

    /*
     var result = new List<int>();
    foreach(var item in arr) {
      if(result.Count(i => i == item) < x)
        result.Add(item);
    }
    return result.ToArray();
     */

/*
 * return arr.Where((t,i)=>arr.Take(i+1).Count(s=>s==t) <= x).ToArray();
 * 
 * 
 */

/*
 * 
 * 
 * 
 * //LINQ-POWER-STYLE-------------
    

        => arr.Where((e, i) => arr.Where((f, j) => j <= i && e == f).Count() <= x).ToArray();*/

class Satamon : Kata
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 1, 3, 3, 7, 2, 2, 2, 2 };
        DeleteNth(array, 3);
    }
}
}
