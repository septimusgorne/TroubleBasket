using System;

namespace CodeWars_Walking
{

    public class Program
    {

        //insert brilliant code here
        static bool Walking()
        {
            //string[] walk = { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" };//false
            string[] walk = { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };//true

            int shag = 0;
            int count = 0;


            for (int i = 0; i < walk.Length; i++)
            {
                    if (walk[i] == "n")
                    {
                        shag++;
                    }
                    else if (walk[i] == "s")
                    {
                        shag++;
                    }
                    else if (walk[i] == "w")
                    {
                        shag++;
                    }
                    else if (walk[i] == "e")
                    {
                        shag++;
                    }
                }

            for (int i = 0; i < walk.Length - 1; i++)
            {
                if (walk[i + 1] == walk[i])
                    shag--;
            }

            count = shag;

            Console.WriteLine(count);

            if (count == 10)
            {
                Console.WriteLine("Проверка пройдена");
                return true;
            }
            else
                Console.WriteLine("проверка не пройдена");
                return false;
        }



        public static void Main(string[] args)
        {
            Walking();
        }
    }
}
