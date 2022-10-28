using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;


namespace IPv4_Try
{
    public class Kata
    {
        /*public static bool is_valid_IP(string ipAdress)
        {

            Console.WriteLine(ipAdress);
            
            return true;
        }*/
    }


    class Program
    {
        public static bool IsValid(string ipAddres)
        {
           /* bool ss = true;
            foreach (char c in ipAddres)
            {
                ss = char.IsDigit(c);
            }*/
            string[] sort = ipAddres.Split('.');

            if (sort.Length != 4)
                return false;
            for (int i = 0; i < 4; i++)
            {
                int res;
                if (!int.TryParse(sort[i], out res))
                {
                    return false;
                }
                if (sort[i][0] == '0' && sort[i][0] != 0)
                {
                    return false;
                }
                if (res > 255 || res < 0)
                {
                    return false;
                }
                //if (Char.IsDigit(sort[i][1]) == false)
                    //Console.Write(i);
                    //return false;
            }
            return true;
        }



        /*
         * {
            string[] sort = ipAddres.Split('.');

            if (sort.Length != 4)
                return false;

            for (int i = 0; i < 4; i++)
              {
                int res;
                if (sort[i][0] == '0' && i >= 0)
                {
                    return false;
                }
                if (!int.TryParse(sort[i], out res))
                  {
                    return false;
                  }
                
                if (res > 255 || res < 0)
                  {
                    return false;
                  }
                
              }
          return true;
          }
         */
        public static void Main()
        {
            IsValid("abc.def.ghi.   jkl");
            //IsValid("123.456.789.0");

            string hh = ((int)(5 / 60)).ToString(); 
        }
    }
    /*public class SolutionTest
    {
        //[Test]
        public static void TestCases()
        {
            //Assert.AreEqual(true, Kata.is_valid_IP("0.0.0.0"));
            //Assert.AreEqual(true, Kata.is_valid_IP("12.255.56.1"));
            //Assert.AreEqual(true, Kata.is_valid_IP("137.255.156.100"));

            Assert.AreEqual(false, Kata.is_valid_IP(""));
            //Assert.AreEqual(false, Kata.is_valid_IP("abc.def.ghi.jkl"));
            //Assert.AreEqual(false, Kata.is_valid_IP("123.456.789.0"));
            //Assert.AreEqual(false, Kata.is_valid_IP("12.34.56"));
            //Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.00"));
            //Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.7.8"));
            //Assert.AreEqual(false, Kata.is_valid_IP("12.34.256.78"));
            //Assert.AreEqual(false, Kata.is_valid_IP("1234.34.56"));
            //Assert.AreEqual(false, Kata.is_valid_IP("pr12.34.56.78"));
            //Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.78sf"));
            //Assert.AreEqual(false, Kata.is_valid_IP("12.34.56 .1"));
            //Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.-1"));
            //Assert.AreEqual(false, Kata.is_valid_IP("123.045.067.089"));
        }

    }

    class Program : SolutionTest
    {
        public static void Main(string[] args)
        {
            SolutionTest.TestCases();
        }
    }*/
}
/*
 

using System.Net;

namespace Solution
{
    class Kata
    {
        public static bool is_valid_IP(string ipAddres)
        {
          string[] sort = ipAddres.Split('.');
          if(ipAddres == "0.0.0.0")
            return true;
          //foreach(var part in sort)
                  // {
                  //if (part.Length != part.Trim().Length)
                    // {
                      // return false;
                     //}
                   //}
            if (sort.Length != 4)
                return false;    
            for (int i = 0; i < 4; i++)
              {
                int res;
                if (!int.TryParse(sort[i], out res))
                  {
                    return false;
                  }                
                if (sort[i].Contains(" ") || (sort[i].Length >= 2 && sort[i].StartsWith("0")) || 
                   sort[i].Contains("-"))
                {
                  return false;
                } 
                if (res > 255 || res < 0)
                  {
                    return false;
                  }
                }
          return true;
          }
      /*   
           using System.Net; 
           var result = IPAddress.TryParse(ipAddres, out var ip);
           return result && ip.ToString() == ipAddres; 
      */
