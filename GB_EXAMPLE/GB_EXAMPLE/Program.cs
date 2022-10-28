using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Xml;



/*namespace BLABLA

{
    class Program
    {
        public static void Main()
        {
            int num1 = 1;
            int num2 = 1;

            Console.WriteLine("Введите номер элемента: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N - 2; i++)
            {
                int fsum = num1 + num2;
                num1 = num2;
                num2 = fsum;
            }
            Console.WriteLine($"Значение элемента: {num2}");
        }
    }
}*/

/*namespace Unique_Elements_Array
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Ввод количества элементов массива: \t");
            var N = Console.ReadLine();
            int numb;

            var isNumber = int.TryParse(N, out numb);
            if (isNumber == false)
            {
                Console.WriteLine("Введите целое число");
                Console.ReadKey();
            }
            else
            { 

                int[] myArr = new int[numb];

                for (int i = 0; i < myArr.Length; i++)
                {
                    Console.Write($"Введите элемент индекса {i}: \t"); ;
                    myArr[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("\nУникальные элементы массива: ");
                foreach (var m in myArr.Distinct<int>())
                {
                    Console.Write("\n{0}", m);
                }
                Console.ReadKey();
            }

            
        }
    }
}*/


/*using System;
using System.Linq;

namespace Unique_Elements_Array
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Введите число элементов массива: \t");
            var N = Console.ReadLine();
            int numb;

            var isNumber = int.TryParse(N, out numb);
            if (isNumber == false)
            {
                Console.WriteLine("Введите целое число");
                Main(args);
            }
            else
            {
                Unique_Arr(numb);
            }
        }
        private static void Unique_Arr(int numb)
        {
            int[] myArr = new int[numb];

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write($"Введите элемент индекса {i}: \t"); ;
                myArr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nУникальные элементы массива: ");
            foreach (var uniq in myArr.Distinct<int>())
            {
                Console.Write("\n{0}", uniq);
            }
            Console.ReadKey();
        }
    }
}*/




//int[] ints = { 1, 2, 3, 3, 4, 10, 5, 6, 7, 9, 3, 1 };
//int[] ints2;

/*for (int i = 0; i < ints.Length; i++)
 {
     for (int j = i + 1; j < ints.Length; j++)
     {
         if (ints[i] == ints[j])
         {

         }
     }
 }*/
//Дан массив. Выведите те его элементы, которые встречаются
//в массиве только один раз. Элементы нужно выводить
//в том порядке, в котором они встречаются в списке
//
//

/*using System;

namespace Unique_Elements_Array
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Введите число элементов массива: \t");
            var N = Console.ReadLine();
            int numb;

            var isNumber = int.TryParse(N, out numb);
            if (isNumber == false)
            {
                Console.WriteLine("Введите целое число");
                Main(args);
            }
            else
            {
                Unique_Arr(numb);
            }
            Unique_Arr(numb);
        }
        private static void Unique_Arr(int numb)
        {
            int[] myArray = new int[numb];
            int x = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент индекса {i}: \t"); ;
                myArray[i] = int.Parse(Console.ReadLine());
            }

            var notUniqEl = 0;//считаем повторяющиеся элементы
            for (int i = 1; i < myArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (myArray[i] == myArray[j]) //проверяем на уникальность
                    {
                        notUniqEl++;     //Если элемент повторился, добавляем, по циклу идём к следующему элементу
                    }
                }
            }

            int[] uniqueArray = new int[myArray.Length - notUniqEl]; // Создаем массив уникальных элементов(из него вычитаем повторяющиеся)
            uniqueArray[0] = myArray[0];   //Записываем первый элемент( так как выводим по заданию с первого уникального элемента, первый уже уникальный) 
            for (int i = 1, index = 1; i < myArray.Length; i++)
            {
                var uniqueElement = true;   //Для проверки уникальности присваиваем true
                for (int j = 0; j < i; j++)
                {
                    if (myArray[i] == myArray[j])//Проверяем уникальность для записи в новый массив
                    {
                        uniqueElement = false;
                        break;//Пропускаем если элемент повторяется
                    }

                    if (uniqueElement)//Если уникальный
                    {
                        uniqueArray[index] = myArray[i];// Записываем уникальный элемент в массив
                        index++; //Индекс для записи в массив уникальных чисел
                    }
                }
                foreach (var el in uniqueArray)
                {
                    Console.WriteLine(el);
                }

                Console.ReadKey();
            }
        }
    }
}*/

namespace Unique_Elements_Array
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[] numbers = { 1, 8, 3, 8, 2, 6, 8, 8 };
            int index = 0;

            int maximum = numbers[index];
            int count_maximal = 0;
            while (index < numbers.Length)
            {
                if(numbers[index] > maximum)
                {
                    maximum = numbers[index];
                    count_maximal = 1;
                }
                if (numbers[index] == maximum)
                {
                    count_maximal++;
                }
                index ++;
                Console.WriteLine(count_maximal);
            }
        }
    }
}

/*namespace Unique_Elements_Array
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = { 2, 5, 13, 7, 6, 4 };
            int size = 6; 
            int sum = 0;
            int avg = 0 ;
            int index = 0 ;

            while(index < size)
            {
                sum += numbers[index];
                index++;
            }
            avg = sum / size;
            Console.WriteLine(avg);
        }
    }
}*/
