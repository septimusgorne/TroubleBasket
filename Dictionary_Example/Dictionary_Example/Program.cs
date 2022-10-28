using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {

        /*Dictionary<int, string> dict = new Dictionary<int, string>();
        //<type key, type value> how List<>();
        dict.Add*/

        //or

        /*Dictionary<int, string> dict = new Dictionary<int, string>
        {
            [2] = "Строка 2",
            [4] = "Строка 4",
            [6] = "Строка 6",
            [8] = "Строка 8",
        };

        Console.Write(dict[2]);*/

        //or

        /*Dictionary<string, string> dic = new Dictionary<string, string>
        {
            ["hello"] = "world",
            ["seven"] = "secret"
        };

        Console.Write(dic["seven"]);
    }*/


        /*
                string last = Console.ReadLine();

                public static class Dict
                {

                    public static string Translate(string line)
                    {
                        var res = russian[line];
                        return res;
                        //return english[line];
                    }

                    public static Dictionary<string, string> russian = new Dictionary<string, string>
                    {
                        ["Hello"] = "Привет",
                        ["Goodbye"] = "Пока"
                    };

                   public static Dictionary<string, string> english = new Dictionary<string, string>
                    {
                        ["Hello"] = "Hey!",
                        ["Goodbye"] = "Bye!"
                    };
                    public static void Main(string[] args)
                    {


                        Console.WriteLine("Введите язык eng/rus");
                        var lang = Console.ReadLine();

                        Console.WriteLine(Dict.Translate("Hello"));

                    }
                }*/


        public static Dictionary<string, string> russian = new Dictionary<string, string>
        {
            ["Hello"] = "Привет",
            ["Goodbye"] = "Пока"
        };

        public static Dictionary<string, string> english = new Dictionary<string, string>
        {
            ["Hello"] = "Hey!",
            ["Goodbye"] = "Bye!"
        };

        public static void Main(string[] args)
        {
            var eng = english;
            var rus = russian;

            Console.WriteLine("Введите язык eng/rus");
            var lang = Console.ReadLine();

            if (lang == "rus")
            {
                Console.WriteLine(rus["Hello"]);
            }
            else
                Console.WriteLine(eng["Hello"]);
        }

        //return english[line];

       

            //var res = russian[line];
            //return res;
            //return english[line];

        
    }
}