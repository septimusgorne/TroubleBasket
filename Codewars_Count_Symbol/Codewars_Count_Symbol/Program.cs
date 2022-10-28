using System;
using System.Linq;
using Xunit;

namespace Codewars_Count_Symbol
{
    public class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> map = new ();

            foreach (var item in str)
            {
                if(map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                    map[item] = 1;
            }

            var res = new Dictionary<char, int>();
            var showConsole = String.Empty;

            foreach (var pair in map)
            {
                showConsole = ($"{pair.Key} = {pair.Value}");
                res.Add(pair.Key, pair.Value);
            }
            Console.WriteLine(showConsole);
            return res;
        }
    }

    public class Test: Kata
    {
        public static void FixedTest_aabb()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.Equal(d, Count("aabb"));
        }

        public static void FixedTest_aaaa()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.Equal(d, Kata.Count("aaaa"));

        }
    }
    class Program
    {
        public static void Main()
        {
            Test.FixedTest_aaaa();
            Test.FixedTest_aabb();
        }
    }

}