using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Notebook_Example
{
    class Program
    {

        static uController uController;
        static void Main(string[] args)
        {
            /*List<string> socialNetworks =  new List<string>();

            List<string> socialNetworksList = new();

            socialNetworksList.AddRange(socialNetworksArray);


            //AddList();


            Abstraction();
            AddList();
            Console.ReadLine();
        }

        public static void AddList()
        {
            List<char> charsX = new List<char>();

            charsX.Add('%');//Add
            charsX.Add('$');
            charsX.Add('&');

            //?? List<char> charsXX = () { '%', '$', '@', '!'};

            //?? List<string> listX = () { "trtr", "aqqq", "qqaq"};


            List<string> FFF = new List<string>() { "dfdf", "ddfdf", "dfdf" };
            charsX.Insert(3, '^');//Insert

            //charsX.RemoveAt(0);//Remove

            charsX.Sort();//Sort

            Console.WriteLine(charsX[1]);//get for Index

            foreach (var item in charsX)
            {
                Console.Write(item);
            }

        }

        public static void Abstraction()
        {
            List<string> Casper = new List<string>()
            {
                "one",
                "two",
                "three"
            };

            foreach (var item in Casper)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/

/*namespace ExampleClass
{
    class Program
    {
        public class Rocket
        {
            /*public Rocket()
            {

            }
            public int Fuel { get; set; }
        }

        public Rocket CreateRocket (int fuel)
        {
            Rocket rocket = new Rocket ();

            rocket.Fuel = fuel;
            
            return rocket;
        }


        public static void Main(string[] args)
        {

        }
    }
}*/

/*namespace DelegatExample
{
    class Program
    {
        public delegate double MathDelegate(double value1, double value2);

        public static double Add(double value1,double value2)
        {
            return value1 + value2;
        }

        public static double Substract(double value1, double value2)
        {
            return value1 - value2;
        }
        //Console.ReadLine();


        public static void Main()
        {
            MathDelegate mathDelegate = Add;
            var result = mathDelegate(5, 2);

            mathDelegate = Substract;
            result = mathDelegate(5, 2);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}*/

/*namespace DelegateMulticastingExample
{
    class Programm
    {
        static void Hello(string s)
        {
            Console.WriteLine(" Hello, {0}!",s);
        }

        static void Goodbye(string s)
        {
            Console.WriteLine(" Goodbye, {0}!", s);
        }

        delegate void Del(string s);    

        public static void Main()
        {
            Del a, b, c, d;

            a = Hello;

            b = Goodbye;

            c = a + b;

            d = c - a;

            Console.WriteLine("Invoking delegate a:");
            a("A");
            Console.WriteLine("Invoking delegate b:");
            b("B");
            Console.WriteLine("Invoking delegate c:");
            c("C");
            Console.WriteLine("Invokibg delegate d");
            d("D"); 
        }
    }
}*/


namespace DelExample
{
    class Program
    {
        /*public delegate void NoParameters();

        private delegate float WithParameters(int x, bool y);

        protected delegate float WithParameters1(ref int x, bool y);*/

        public delegate void NoParameters();
        public static void Main()
        {
            NoParameters noPrm = new(ShowMessage);

            noPrm();

            Console.ReadLine();
        }

        private static void ShowMessage()
        {
            Console.WriteLine("Have fun");
        }
    }
}
