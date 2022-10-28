namespace Example_Cycles
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("\nцикл 1 интерация N: " + i);
                Console.WriteLine();
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine("\tЦикл 2, итерация N: " + j);
                }
            }*/

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("@");
                if(i == 3)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine("#");
                    }
                    //Console.WriteLine("\n#");
                    /*for (int x = 0; x <=20; i++)
                    {
                        Console.WriteLine(i);
                    }*/
                }
            }
            Console.WriteLine();
        }
    }
}