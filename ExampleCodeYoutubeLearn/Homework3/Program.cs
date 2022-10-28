using System;
using System.Linq;
using System.Reflection;
/*namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 77.40;
            double EurToRub = 88.70;
            double USD;

            Console.WriteLine("Введите сумму в USD");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + "в RUB = " + USD * UsdToRub);

            Console.WriteLine(USD + "в EUR = " + USD * EurToRub);

        }
    }

}*/



/*namespace BoolType
{
    public class Program
    {
        static void Main( string [] args)
        {
            bool isInfected = true;

            if (!isInfected)
            {
                Console.WriteLine("Персонаж Здоров!");
            }
            else
            {
                Console.WriteLine("Персонаж инфицирован");
            } 
                
        }
    }
}*/

/*namespace BoolType2
{
    public class Program
    {
        static void Main (string [] args)
        {
            bool isHighTemperature = true;

            bool hasNoCooling = false;

            if (isHighTemperature && hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения проццессора!!!");
            }
            else
                Console.WriteLine("Температура впорядке!");
        }
    }
}*/

/*namespace RelationShip
{
    public class Program
    {
        public static void Main (string [] args)
        {
            int numOne = 5;

            int numTwo = 10;

            Console.WriteLine(numOne >= numTwo);
        }
    }
}*/

/*namespace Even
{
    public class Program
    {
        public static void Main (string [] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("a равно 5");
            }
            else
            {
                Console.WriteLine("a не равно 5");
            } 
                
        }
    }
}*/

/*namespace Even2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num;

            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}*/


/*namespace SwitchCase
{
    public class Program
    {
        public static void Main(string [] args)
        {
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Это число 1");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Это число 2");
                    }
                    break;
                default:
                    {
                         Console.WriteLine("Это неизвестное число");
                    }
                    break;
            }
        }
    }
}*/


/*namespace SwitchStringCase
{
    public class Program
    {
        public static void Main(string [] args)
        {
            int str = Console.ReadLine();

            switch (str)
            {
                case "asa":
                    {
                        Console.WriteLine("Вы ввели assa");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Вы не ввели assa");
                    }
                    break;
            }
        }
    }
}*/

/*namespace Key
{
    public class Program
    {
        public static void Main(string [] args)
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;

            switch (consoleKey) 
            {
                case ConsoleKey.Enter:
                    {
                        Console.WriteLine("Вы нажали клавишу Enter");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Хрен его знает, что вы нажали");
                    }
                    break;
            }
        }
    }
}*/

/*namespace Calc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();// Class Console. Method Clear

            double num, num2;
            string action;

            try // Если возникнемт ошибка
                {
                    Console.WriteLine("Введите число 1");
                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    num2 = int.Parse(Console.ReadLine());
                }
            catch (Exception)// Исключения
                {
                    Console.WriteLine("Введите корректные данные!");
                    Console.ReadLine();
                    continue;//попадет после исполнение в начало цикла While
                }

            Console.WriteLine("Введите число 1");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите действие '+' '-' '*' '/' ");
            action = Console.ReadLine();


                switch (action)
                {
                    case "+":
                        {
                            Console.WriteLine(num + num2);
                        }
                        break;

                    case "-":
                        {
                            Console.WriteLine(num - num2);
                        }
                        break;
                    case "*":
                        {
                            Console.WriteLine(num * num2);
                        }
                        break;
                    case "/":
                        {
                            Console.WriteLine(num / num2);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Указажите коррекное действие");
                        }
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}*/

/*namespace CalcIf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2;
            string action;

            Console.WriteLine("Введите первое число");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите операцию '+' '-' '*' '/' ");
            action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (action == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (action == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (action == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Введите корректную операцию");
            }
        }
         
    }
}*/


/*namespace DoWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;

            while ( count < 5)
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}*/


/*namespace DoWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numer = 0;

            do
            {
                numer++;
                Console.WriteLine(numer);
            }
            while (numer < 10);
            {
                Console.WriteLine("Превышено критическое значение");
            }
        }
    }
}*/

/*namespace Lessons
{
    public class Program
{ 
    public static void Main(string[] args)
    {
            uint oddNumbersCount = 0; //нечетные числа
            uint evenNumbersCount = 0; //четные числа

            int oddNumberSum = 0;
            int evenNumberSum = 0;

            Console.WriteLine("Введите первое число");
            int currentValue = int.Parse(Console.ReadLine());//начало диапазона

            Console.WriteLine("Введите последнее число");
            int limit = int.Parse(Console.ReadLine());//конец диапазона

            while(currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {                    
                    evenNumbersCount++;                    
                    evenNumberSum += currentValue;
                }
                else
                {
                    oddNumberSum += currentValue;
                    oddNumbersCount++;
                }
                currentValue++;
            }

            Console.WriteLine("Количество нечетных чисел:" + oddNumbersCount);
            Console.WriteLine("Количество четных чисел:" + evenNumbersCount);
            Console.WriteLine("Сумма нечетных чисел" + oddNumberSum);
            Console.WriteLine("Сумма четных чисел" + evenNumberSum);
            Console.ReadLine();
        }
    }
}*/





/*namespace ForExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < limit; i++)// double tab
            {
                Console.WriteLine(i);
            }
        }
    }
}*/

/*namespace whileFor
{
    public class Program
    {
        public static void Main(string [] args)
        {
            int limit = int.Parse (Console.ReadLine());

            int i = 0;

            while(i<limit)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}*/


/*namespace forReturn
{
    public class Program
    {
        public static void Main (string [] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for(int i = 0; i < limit; i++)
            {
                Console.WriteLine ("System for is working" + i);
                System.Threading.Thread.Sleep(500);
                break;// выход из цикла
            }

            Console.ReadLine();
        }
    }
}*/

/*namespace forExample
{
    class Program
    {
       public static void Main(string [] args)
        {

            int i = 0;


            for (; i < 3; i++)
            {
                Console.WriteLine("for 1" + i);
            }

            for (; i < 5; i++)
            {
                Console.WriteLine("for 2" + i);
            }
        }
    }
}*/



/*namespace forExample
{
    class Program
    {
        public static void Main (string [] args)
        {
            for (int i = 0, j = 5; i < 10 && j < 12; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
                //j++;
                //Console.WriteLine("j++:" +j)
            }
        }
    }
}*/


/*namespace forExample
{
    class Program
    {
        public static void Main(string [] args)
        {
            /*for (int i = int.Parse(Console.ReadLine()); i >= 0; i--)
            {
                Console.WriteLine(i);
            }*/

/*int i = int.Parse(Console.ReadLine())

for (; i >= 0; i--)
{
    Console.WriteLine(i);
}*/

/*for (int i = 0, j = 5; i < 5; i++, j--)
{
    Console.WriteLine("i : " + i);
    Console.WriteLine("j : " + j);
}

}
}
}*/
/*namespace Break
{
    public class Program
    {
        public static void Main(string [] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();


                if (msg == "exit")
                {
                    Console.WriteLine("Остановка работы");
                    break;
                }
                Console.WriteLine(i);

                /*if (i == 10)
                {
                    break;// прерывание цикла при условии
                }
            }

            Console.WriteLine();// чтобы программа не закрылась
        }
    }
}*/


/*namespace continueExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)// параметры
            {
                if (i==2)
                {
                    continue;//прерывание при соответствии
                }
                Console.WriteLine(i);// тело цикла
            }

            Console.ReadLine();
        }
    }
}*/


/*namespace cycleExample// вложенные циклы
{
    class Program
    {
        public static void Main(string []args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация N:" + i);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация N" + j);

                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tЦикл 3 итерация N" + k);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}*/


/*namespace cycleExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту квадрата:");
            int hight = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину квадрата:");
            int weidth = int.Parse(Console.ReadLine());


            for (int j = 0; j < hight; j++)
            {
                for (int i = 0; i < weidth; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                //Console.Write();
            }
            Console.ReadLine();
        }
    }
}*/



/*namespace randomArray
{
    class Program
    {
        static int[,] GetRandomArray( int rows, int columns)
        {
            Random random = new Random();// new Random
            var result = new int[rows,columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }

        static void Main(string [] args)
        {
            int rows = 5;
            int columns = 7;

            var myArray = GetRandomArray(rows, columns);

            for (int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}*/


/*namespace Cyrcle
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту квадрата");
            int height = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите ширину квадрата");
            //int weight = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");  
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i * 2; j++)
                {
                    Console.Write("#" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace Triangle
{
    public class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("\t");

            Console.WriteLine("\t\t");
            Console.WriteLine("Первый треугольник");
            Console.WriteLine("\t");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\t\t");
            Console.WriteLine("Второй треугольник");
            Console.WriteLine("\t");

            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j >= i; j--)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\t\t");
            Console.WriteLine("Третий треугольник");
            Console.WriteLine("\t");

            for (int i = 0; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\t\t");
            Console.WriteLine("Четвертый треугольник");
            Console.WriteLine("\t");


            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}*/


/*namespace Ternar
{
    class Program
    {
        public static void Main(string [] args)
        {
            bool acessAllowed;

            string storePassword = "1234";
            string enterPassword = Console.ReadLine();

            /*if (enterPassword == storePassword)
            {
                acessAllowed = true;
                Console.WriteLine("Введен верный пароль");
            }

            else
            {
                acessAllowed = false;
                Console.WriteLine("Неверный пароль");
            }//


            acessAllowed = enterPassword == storePassword ? true : false;

            Console.WriteLine(acessAllowed);

            Console.ReadLine();
        }
    }
}*/


/*namespace Plus
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = number > 0 ? number : 0;
            Console.WriteLine(number);

            Console.ReadLine();
        }

    }
}*/



/*namespace Array
{
    class Program
    {
        public static void Main(string [] args)
        {
            int[] myArray;//обьявляем массив

            myArray = new int[5];// выделяем место под массив
            //гарбдж коллектор сам убирает мусор

            myArray[1] = 3;
            myArray[0] = 10;

            int a = myArray[0];

            Console.WriteLine(myArray.Length + a);


            Console.ReadLine();
        }
    }
}*/


/*namespace Array
{
    class Program
    {
        public static void Main(string [] args)
        {
            //int[] myArray = new int[5] {10, 20, 30, 40, 59 };

            //int[] myArray2 = new int[] { 5, 7, 8 };

            //int[] myArray3 = new int[6]; 

            //int [] myArray4 = new [] { 1, 2, 3 };

            //int[] myArray5 = { 1, 2, 3, 4, 5, 6 };

            //int[] myArray6 = Enumerable.Repeat(5, 10).ToArray();
            //массив из 10 элементов и каждый элемент будет содержать 5

            int [] myArray7 = Enumerable.Range(4, 5).ToArray();
            //массив 5 элементов начиная с 4

            //Console.WriteLine(myArray2.Length + myArray.Length);

            Console.WriteLine(myArray7[0]);

            Console.ReadLine();
        }
    }
}*/

/*namespace ArrayBor
{
    class Program
    {
        public static void Main(string [] args)
        {
            int[] myArray = { 10, 3, 2, 55, 8 };

            //myArray. //поле переменной после точки

            for (int i = 0; i < myArray.Length; i++)
            {
                /*if (myArray[i] == myArray[2])//10
                {
                    Console.WriteLine("Пентаног взломан" + "\t" + myArray[2] + myArray[1]);
                }

                Console.WriteLine(myArray[i]);
            }
                
          //Console.WriteLine(myArray[3]);

            Console.ReadLine();
        }
    }
}*/


/*namespace ArrayExample
{
    class Program
    {
        public static void Main(string [] args)
        {


            Console.Write("Введите количество элементов массива:");
            int elementArray = int.Parse(Console.ReadLine());

            int [] myArray = new int[elementArray];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите элементы массива {i}:\t ");
                myArray[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }

    }
}*/




/*namespace ArrayKeyboard
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int elementArray = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementArray];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива: \t");
                myArray[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Вывод элементов массива: \t");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("Вывод элементов в обратном порядке: \t");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }


            Console.WriteLine("Сумма чётных чисел: \t");

            int res = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    res += myArray[i];
                }
            }
            Console.WriteLine(res);


            Console.WriteLine("Наименьшее число из массива: \t");

            int min = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                     min = myArray[i];
                }
            }
            Console.WriteLine(min);

            Console.WriteLine("Наибольшее число из массива: \t");

            int max = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }

            Console.WriteLine(max);
            
            Console.WriteLine("Количество элементов массива: \t");
            Console.WriteLine(myArray.Length);
        }
    }
}*/

/*namespace ArrayExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = { 111, 2, 111, 4, 343 };

            //int resMax = myArray.Max();// метод max

            //int resMin = myArray.Min();//метод min(Extension method)

            //Console.WriteLine(resMax);

            //Console.WriteLine(myArray.Sum());// сумма элементов

            //Console.WriteLine(myArray.Where(i => i % 2 == 1).Sum());

            //элементы массива где элементы нечетные

            //Console.WriteLine(myArray.Where(i => i % 2 == 1).Min());

            //самый маленький нечетный элемент

            //int [] result = myArray.Distinct().ToArray();

            //метод Distinct преобразовать в массив ToArray

            //int[] result2 = myArray.OrderBy(i => i).ToArray();

            // сортировка массива по возрастанию

            //int [] result3 = myArray.OrderByDescending(i => i).ToArray();

            //Array - obsract class

            //Array.Sort(myArray);//метод Sort параметр myArray

            //отсортировать массив по убыванию

            //int ress = Array.Find(myArray, i => i < 70);

            //первый элемент меньше 70

            //int ress = Array.FindLast(myArray, i => i < 70);

            //int[] ress = Array.FindAll(myArray, i => i > 2).ToArray();

            //int ress = Array.FindLastIndex(myArray, i => i == 111);

            //int ress = Array.FindIndex(myArray, i => i == 111);

            //int[] ress = myArray.Where( i => i > 5).ToArray();

            //int res = myArray.Where(i => i > 5).First();

            //int resss = myArray.Where(i => i < 0).FirstOrDefault();

            //Array.Reverse(myArray);

            Console.WriteLine(resss);

            Console.ReadLine();
        }
    }
}*/

/*namespace LearnX
{
   class Point
   {
        int z = 3;

        public int x = 1;

        private int y = 44;

      private void PrintX()
      {

      }
      public void PrintY()
      { 
          Console.WriteLine($"Y {y}");      
      }      
       public void PrintPoint()
       {

       }
   }
    
    class Program
    {
        static void Main(string[] args)
        {
            /*Point point = new Point();

            point.PrintY();

            point.PrintPoint();*/

/*var typeInfo = typeof(Point).
    GetFields(BindingFlags.Instance | 
    BindingFlags.NonPublic |
    BindingFlags.Public);

foreach (var item in typeInfo)
{
    Console.WriteLine($"{item.Name}\t IsPrivate:{item.IsPrivate}\t IsPublic: {item.IsPublic}");
}
}
}
}*/


namespace LessonXXX
{
    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");

            isLoaded = true;

            Console.WriteLine("Заряжено");
        }

        public void Shoot()
        {
            if (isLoaded)
            {
                Console.WriteLine("Оружие не заряжено");
                Reload();
            }
            Console.WriteLine("Пыщ-Пыщ\n");
            isLoaded = false;
        }
    }

class Program
    {
    static void Main(string[] args)
        {
            var typeInfo = typeof(Gun).
            GetFields(BindingFlags.Instance |
            BindingFlags.NonPublic |
            BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate:{item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }


            Gun gun = new Gun();
            gun.Shoot();
            Console.ReadLine();
        }
    }
}