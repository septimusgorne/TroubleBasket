using System;
using System.Linq;

namespace Reverse_String
{
    public class Kata
    {
        public static void ReturnString(string str)
        {
            String[] words = str.Split(" ");
            String reversedString = String.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                String word = words[i];
                String reverseWord = String.Empty;
                for (int j = word.Length - 1; j >= 0; j--)
                {   
                    reverseWord += word[j];
                }
                reversedString +=   reverseWord + " " ;
            }


            str = reversedString.TrimEnd();
            Console.Write(str);
        }

        public class Test : Kata
        {
            public static void Main(string[] args)
            {
                string str = "This is an Example!";

                ReturnString(str);
            }
        }
    }
}
