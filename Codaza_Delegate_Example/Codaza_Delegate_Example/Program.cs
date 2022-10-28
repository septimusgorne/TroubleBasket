using System;

namespace Codaza_Delegate_Example
{

    //SingleCastDelegate NoParameters
    /*class Program
    {
        public delegate void NoParameters();
        //delegate without parameters

        static void Main()
        {
            NoParameters noPrm = new(ShowMessage);
            //type name noPrm, reference method ShowMessage
            noPrm();
            //call name delegate
            Console.ReadLine();
            //await
        }

        private static void ShowMessage()
        {
            Console.WriteLine("Have Fun!");
        }
    }*/

    //SingleCastDelegate WithParameters

    /*class Program
    {
        public delegate string WithParameters(string name1, string name2);  

        static void Main()
        {
            WithParameters withPrm = new WithParameters(ShowMessage);

            string value = withPrm("Await", "Async");

            Console.WriteLine(value);
        }

        public static string ShowMessage(string name1, string name2)
        {
            Console.WriteLine($"{name1}, {name2} Have FUN!");

            return "last return WPF................";
        }
    }*/

    //MultiCastDelegate
    /*class Program
    {
        public delegate void NoParameters();

        static void Main()
        {
            NoParameters noPrm = new(ShowMessage1);

            noPrm += ShowMessage2;
            //sum or delete
            noPrm();
            Console.ReadLine();
        }

        private static void ShowMessage1() => Console.WriteLine(" Have Fun!");
        private static void ShowMessage2() => Console.WriteLine("See you 2 Method");
    }*/

    //Delegate FOR references on AnonymousMethod
    
    /*class Program
    {
        public delegate void NoParameters();

        static void Main()
        {
            //NoParameters noPrm = delegate ()
            //{
              //  Console.WriteLine($"Have fun");
            //};

            NoParameters noPrm = delegate () { Console.Write("Lol"); };

            noPrm();

            Console.ReadLine();
        }
    }*/
    class Program
    {
        public delegate void NoParameters();

        static void Main()
        {
            NoParameters noPrm = delegate ()
            {
                Console.WriteLine($"Have Fun!");
            };

            Test(noPrm);

            Console.ReadLine();
        }

        private static void Test(NoParameters noPrm)
        {
            noPrm();
        }
    }


}