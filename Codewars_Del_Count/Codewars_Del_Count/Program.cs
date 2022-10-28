using NUnit.Framework;
using System;


namespace Del_Count
{
    public class Kata
    {
        public static int Divisors(int n)
        {

            
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    res++; ;
            }
            return res;
        }
    }

    public class SolutionTest : Kata
    {
        [Test]
        public void SampleTest()
        {
            //Assert.AreEqual($"Test 1:    " + 1, Kata.Divisors(1));
            Assert.AreEqual($"Test 2:    " + 4, Kata.Divisors(10));
            Assert.AreEqual($"Test 3:    " + 2, Kata.Divisors(11));
            Assert.AreEqual($"Test 3:    " + 8, Kata.Divisors(54));
        }
    }

    class Program
    {
        public static void Main()
        {
            SolutionTest solution = new SolutionTest();
            solution.SampleTest();

        }
    }
}