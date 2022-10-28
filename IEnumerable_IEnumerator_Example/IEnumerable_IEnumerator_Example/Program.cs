using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * public interface IEnumerable
 * {
 *      IEnumerator GetEnumerator(); 
 * }
 * 
 * public interface IEnumerator
 * {
 *       bool MoveNext();
 * }
 * 
 */



namespace InterfIEnum
{
   /* class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 0, 2, 4, 6, 8, 10 };

            IEnumerator ie = numbers.GetEnumerator();

            while(ie.MoveNext())
            {
                int item = (int)ie.Current;
                Console.WriteLine(item);
            }
            ie.Reset();
            Console.Read();
        }
    }*/
   class WeekEnumerator : IEnumerator <string>
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }
        public string Current
            //return object Type!!!! :IEnumerator <string>
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();
                return days[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();
        //Exception! Initialize new object class NotImplementedException
        //standart properties
        public bool MoveNext()
        {
            if(position < days.Length - 1)
            {
                position+=2;
                //position++;
                return true;
            }
            else 
                return false;
        }
        public void Reset()
        {
            position = -1;  
        }
        public void Dispose() { }
    }
    /*class Week : IEnumerable
    {
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();    
        }
    }*/

    //class Week : IEnumerable
    class Week : IEnumerable
    {
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday", "LonelyDay" };
        public IEnumerator GetEnumerator()
        {
        return new WeekEnumerator(days);
        }   
}
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
            Console.Read();
        }
    }
}