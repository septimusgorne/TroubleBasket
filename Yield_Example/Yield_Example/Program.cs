using System;
using System.Collections.Generic;
using System.Collections;

namespace Yield_Example
{
    /*class Program
    {
        static List<int> myList = new List<int>();
        //create static collection myList

        static void Fill()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
        }
        //5 elemet in myList Collection

        static void Main(string[] args)
        {
            Fill();
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string ('_' , 20));

            foreach (int item in Method())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static List <int> Method()
        {
            List<int> list = new List<int>();
            {
                foreach (int item in myList)
                {
                    if (item > 2)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
        }
    }*/


    class Program
    {
        static List<int> myList = new List<int>();

        static void Add()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
        }

        static void Main(string[] args)
        {
            Add();
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_", 20);

            foreach  (int item in SelectMyList())
            {
                Console.WriteLine(item);
            }
        }



        /*static List<int> SelectMyList()
        {
            List<int> nextList = new List<int>();

            foreach (var item in myList)
            {
                if(item > 2)
                {
                    nextList.Add(item);
                }
            }
            return nextList;
        }*/

        static IEnumerable SelectMyList()
        {
            foreach  (int item in myList)
            {
                //if (item == 5)
                  //  yield break;
                //else 
                if(item > 2)
                    yield return item;
            }
        }
    }




   

}