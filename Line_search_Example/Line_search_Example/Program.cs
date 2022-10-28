using System;

namespace Line_Search
{
    class Program
    {
        /*public static List<string> listFamily = new List<string>
            {   "dfdfd",
                C,
                "Сидоровы",
                "Ивановы,",
                "Наркомановы"
             };*/

        public static string[] listFamily = { "asdasd", "Сидоровы", "Ивановы", "Наркомановы" };    


        public static int Main(string[] args)
        {
            string writeFamily = Console.ReadLine();

            for (int i = 0; i < listFamily.Length; i++)
            {
                if (listFamily[i] == writeFamily)
                    Console.WriteLine("Здесь есть\t" + listFamily[i]);
            }
            return -1;
        }
    
    }
}