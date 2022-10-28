using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


/*namespace ArrayIndex
{
    class Program
    {
        public static void Main(string [] args)
        {
            int[] myArray = { 2, 10, 5, 6, 77, 89, 134343 };

            /*int[] myArray2 = myArray[1..4];
            //начало и конец диапазона в новый массив из первого

            int[] myArray3 = myArray[..2];
            //если нужно с нулевого элемента можно не указывать нулевой элемент

            int[] myArray4 = myArray[5..];
            //от 5го элемента и до конца можно не указывать последний
            

            Index myIndex = ^2;// это структура. пример аналогии

            myIndex = ^3;

            //Console.WriteLine($"value {myIndex.Value} isFromEnd{myIndex.IsFromEnd}");
            //вывели поля, само значение переменной в виде значения индекса
            //и булевое значение истина\ложь показывающая сначала или с конца
            //работает индекс

            Range myRange = 1..4;
            //это структура

            Range myRange2 = new Range(1,4);//тоже что 1..4
            //это тоже структура

            int[] myArray4 = myArray[myRange];

            Range myRange4 = ^4..^2;

            string hello = "Hello world!";

            //Console.WriteLine(myArray[myIndex]);
            //Console.WriteLine(myArray[^1]);
            //первый элемент с конца ^1

            //Console.WriteLine(myArray[myIndex]);

            foreach (var item in hello[..^5])
            {
                if (item == 5)
                {
                    Console.Write(hello);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            //Console.WriteLine(hello[^7..^4] + hello[3..5]);

            Console.ReadLine();
        }
    }
}*/


/*namespace SecondLesson
{
    public class Program
    {
        public static void Main(string [] args)
        {

            //тип_данных [,] имя_массива;

            //int[] myArray;

            //int[,] myArray2;//создан ярлык указывающий на контейнер с данными

            //myArray2 = new int[3, 5];//объявление самого массива

            //int[,] myArray = new int[3, 5];

            int[,] myArray2 = new int[3, 5]
            {
                {23, 2, 5, 6, 7 },
                {56, 54, 76, 4, 3 },
                {576, 36, 87, 87, 98 }
            };

            //myArray[2, 3] = 50;



            //int height = myArray2.GetLength(0);
            //int weight = myArray2.GetLength(1);

            //какое количество элементов по высоте и ширине
            // содержится в массиве



            /*for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    Console.Write(myArray2[i, j] + "\t");
                }
                Console.WriteLine();
            }*/

/*string hello = "Hello world";

int lane = int.Parse(Console.ReadLine());

for (int i = lane; i < hello.Length; i++)
{
    Console.WriteLine("\t" + hello[i]);
}*/




/*foreach (var item in myArray2)
{
    //Console.WriteLine(item + " ");
}

//Console.WriteLine(myArray2[2, 3]);

//myArray2.GetLength(2);

//Console.WriteLine(myArray2.Rank);


Console.ReadLine();
}
}
}*/

/*namespace ExampleArray
{
    class Program
    {
        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
            
        }



        static void Main(string [] args)
        {
            Console.WriteLine("Введите символ:");
            //string symbol = Console.ReadLine();
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("\nВведите количество символов:");
            uint symbolsCount = uint.Parse(Console.ReadLine());


            PrintLine("\t " + symbol, symbolsCount);
            Console.ReadLine();
        }
    }
}*/


/*namespace Example
{
    class Program
    {
        static void Iterator(char symb, uint count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symb);
            }
        }

        public static void Main(string [] args)
        {
            Console.WriteLine("Введите символ:");
            char symb = char.Parse(Console.ReadLine());

            Console.WriteLine("\n Введите количество символов:");
            uint count = uint.Parse(Console.ReadLine());

            Iterator( symb, count);
            Console.ReadLine();
        }

    }
}*/

/*namespace LessonSymbol
{
    class Program
    {
        static void Iteration(string symbol, uint CountArray)
        {
            for (int i = 0; i < CountArray; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void Main (string [] args)
        {
            Console.WriteLine("Введите символ:");
            string symbol = Console.ReadLine();

            Console.WriteLine("Введите количество символов:");
            uint CountArray = uint.Parse(Console.ReadLine());

            Iteration(symbol, CountArray);

            Console.ReadLine();
        }
    }
}*/




/*namespace IndexArray
{
    class Program
    {
        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 12, 43, 54, 65 };

            //int value = int.Parse(Console.ReadLine());

            //int result = IndexOf(myArray, 54);

            Console.WriteLine(result);

        }

        
    }
}*/

/*namespace IndexOf
{
    class Program
    {
        static void Iteration(string symb, uint CountIter)
        {
            for (int i = 0; i < CountIter; i++)
            {
                Console.Write(symb);
            }
        }

        public static void Main(string [] args)
        {
            Console.WriteLine("\tВведите символ:");
            string symb = Console.ReadLine();

            Console.WriteLine("\tВведите количество символов:");
            uint CountIter = uint.Parse(Console.ReadLine());

            Iteration(symb, CountIter);

            Console.ReadLine();
        }
    }
}*/


//поиск индекса по введенному значению 
/*namespace FindIndex
{
    public class Program
    {
        static void Main (string [] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, };

            Console.WriteLine ("\t Введите значение массива:");
            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == index)
                {
                    Console.WriteLine (i);
                    //return i;
                }
                
            }
            
            Console.WriteLine("Значение вне диапазона");
            // return -1;

            Console.ReadLine();
        }
    }
}*/

/*namespace ExampleIndexOf
{
    class Program
    {
        static int IndexOf(int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }       
            return -1;
        }

        static void Main(string [] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, };

            int result = IndexOf(myArray, 4);

            Console.WriteLine(result);
        }
    }
}*/

/*namespace ForExample!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
{
    class Program
    {
        static int IndexOf(int[] myArray, int value)//static int!!!!
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random random = new Random();// class Random

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static void Main (string[] args)
        {

            int[] myArray2 = GetRandomArray(10, -3, 5);

            //int[] myArray2 = { 34, 45, 5656, 23, 656, 23 };

            int res = IndexOf(myArray2, 3);

            Console.WriteLine(res);

        }
    }
}*/


//области видимости и конфликты областей видимости 
//область видимости и контекст это одно и то же
/*namespace ExampleFor
{
    class Program
    {

        static void Maxus()
        {
            int b = 9;

        }
        static void Main(string [] args)
        {
            int b = 10;
            Console.WriteLine(b);
        }
    }
}*/

/*namespace NULL
{
    class MyClass// класс
    {

    }

    struct MyStruct// структура
    {

    }
    class Program
    {

        static void Foo()
        {
            int[] a = new int[10];
        }
        public static void Main(string [] args)
        {

            bool b;

            int a;

            double d;

            Random random;

            int[] arr;

            MyClass myClass;

            MyStruct myStruct;

            int [] x; //stack

            x = new int[10]; //heap

            x = null; //разрыв stack and HEAP 

            Foo();

            Console.ReadLine();
        }


        


    }
}*/

/*namespace Proga

    //оператор объединения NULL ??
{
    class Program
    {
        static void Main (string [] args)
        {

            /*string str = null;
            
            
            string res;

            if (str == null)
            {
                res = "нет данных";
                //Console.WriteLine("блабла");
            }
            else
            {
                res = str;
            }*/


/*string str = null;

Console.WriteLine (str?? "нет данных");// проверка на NULL объединение, тип данных должен совпадать . оператор NULL объединения ??
*/


/*string str = null;

//string res = str ?? "";
string res = str ?? string.Empty;// присвоение строки пустой.

Console.WriteLine ("Количество символов в строке" + res.Length);

/*int[] a = new int[10];

a = null;// without adress(где-то потеряли данные)


Console.WriteLine(a[4]);

}
}
}*/


/*namespace nullExample
{
     class Program
     {
        static int[] GetArray()
        {
            int[] myArray = null;

            return myArray;

        }

         static void Main(string [] args)
         {
            /*
            //string str = null;

            string str = "зфкфьуек";

            str ??= string.Empty;//изменение на пустое значение

            string res = str ??= "default string";

            //Console.WriteLine("Количество символов в строке" + res.Length);
            Console.WriteLine(str);// ??= оператор меняет значение переменной, ?? просто заменяет значения, не меняя значение NULL переменной
            */


/*int[] array = GetArray();

array ??= new int[0];

Console.WriteLine("Количество элементов массива" + array.Length);

}
}
}*/

/*namespace ExampleNull
    // опрератор условного NUll ?.
{
    class Program
    {
        static int [] GetArray()
        {
            int [] array = {1, 2, 3}; 

            //int[] array = null;// ярлык который ссылается на данных которых не существует
            return array;
        }


        static void Main(string [] args)
        {
            int[] myArray = GetArray();

            /*if (GetArray() == null)
            {
                Console.WriteLine("Сумма элементо массива 0");
            }
            else



            //Console.WriteLine("сумма элементов массива: " + myArray.Sum());// метод расширения SUM

            Console.WriteLine("Сумма элементов массива: " + (myArray?.Sum()??0));//проверка на NULL сразу c default NULL выводом

        }
    }
}*/

/*namespace NumberExanple
{
    class Program
    {
        static void Person()
        {

        }
        static void GetPerson()
        {

        }


        static Person Getperson()
        {
            Person person = null;
            return person;
        }



        static void Main (string [] args)
        {
            Person person = Getperson();

            string phoneNumber = person?.Contact?.PhoneNumber ?? "нет данных";// после person NULL не будет ничего выполняться, остальное аналогично
        }
    }
}*/

/*namespace RefExample
{
    struct MyStruct
    {
        public int a;
        public double b;
        public float c;
    }

    class MyClass
    {
        public int a;
        public float b;
        public double c;
    }
    class Program
    {

        /*static void Foo(ref int a, ref int b, ref int c)//void - не возвращает никакого значения//передает значение по ссылке ref
        {
            a = -5;
        }*/

/*static void Foo(ref MyStruct myStruct)
{
    myStruct.a = -5;
}

static void Foo (ref MyClass myClass)
{

}


static void Bar( ref int[] array)
{
    //Array[0] = -5;
    //array = null;

    array = new int[10];
}


public static void Main(string [] args)
{
    int a = 2;//this is struct
    MyStruct myStruct = new MyStruct();

    //Foo(ref myStruct);// ref - данные передаются по ссылке, не будут копироваться(как ярлык а не перемещение файла)

    MyClass myClass = new MyClass();

    //Foo(ref myClass);

    int[] myArray = { 1, 2, 4, 6, 5 };

    Bar(ref myArray);

    Console.WriteLine(myArray.Sum());

}
}
}*/

/*namespace RefLessons
{
    class Program
    {
        static void Resize(ref int [] array)
        {
            array = new int[5];
            //int [] array = { 1, 34, 5, 545, 67 };
        }

       static void Main(string [] args)
        {
            //int [3] myArray = {1, 2, 3};
            int [] myArray = new int[3];

            int res = Resize(myArray);

            Console.WriteLine(res);
        }
    }
}*/

/*namespace ReSize// изменение размера массива
{
    public class Program
    {
        static void ReSize(ref int[] array, int newSize)
        {
            int [] newArray = new int[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }


        public static void Main (string [] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            //Array.Resize( ref myArray, 2);
            ReSize(ref myArray, 12);

            Console.WriteLine(myArray);
        }
    }
}*/



/*namespace reSizeGeneric
{
    class Program
    {
        static void Resize<T>(ref T[] array, int newSize)//generic T - type вместо типа данных массива указываем Т для того, чтобы использовать не только int
        {
            //теперь с T работает с любым типо данных
            T[] newArray = new T [newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        static void Main(string[] args)
        {
            string [] myArray2 = {"test", "ramps", "sectum"};

            Program.Resize(ref myArray2, 6);
        }
    }
}*/

/*namespace InsertArray
{
    class Program
    {
        static void Insert(ref int [] array,  int Value, int index)// void for ref 
        {
            int [] newArray = new int[array.Length + 1];  

            newArray[index] = Value;

            for ( int i = 0; i < index ; i++ )
                newArray[i] = array[i];
            for (int i = 0; i < array.Length; i++)
                newArray[i + 1] = array[i];

        }

        static void AddFirst(ref int [] array, int Value)
        {
            Insert(ref array, Value, 0);
        }


        static void AddLast(ref int [] array, int Value)
        {
            Insert(ref array, Value, array.Length);
        }
        static void Main(string [] args)
        {
            int[] myArray = { 1, 2, 3 };

            //Insert(ref myArray, -5, 0);
            //AddFirst(ref myArray, 5);
            AddLast(ref myArray, -5);
        }
    }
}*/


/*namespace DeleteArray
{
    class Program
    {
        static void RemoveAt (ref int [] array, int element)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < element; i++)
                newArray[i] = array[i];
            for (int i = element + 1; i < array.Length; i++)

                newArray[i - 1] = array[i];
        }

        static void RemoveFirst(ref int [] array)
        {
            RemoveAt(ref array, 0);
        }

        static void RemoveLast(ref int[] array)
        {
            RemoveAt(array, array.Length - 1);
        }
        static void Main(string [] args)
        {
            int [] myArray = { 1, 2, 3 };
            
            RemoveAt(ref myArray, 0);

            RemoveLast(ref myArray);

            RemoveFirst(ref myArray);

        }
    }
}*/

/*namespace OutExample

    //ref - копируем данные а не просто ссылку
    //out - в случае с out мы обязаны изначально присвоить значение переменной
{
    class Program
    {
        /*static void Foo(out int value)
        {
            //value = 5;//обязаны при out присвоить значение
            value++;
            Console.WriteLine(value);
        }*/

/*static void Main(string [] args)
{
    //int a;

     //int a = 10;

    //Foo(out a);

    Foo(out int value);//с ref объявить переменную внутри вызова метода не можем, только c out
}

static void Main(string [] args)
{
    string str = Console.ReadLine();

    int.TryParse(str, out int result);// задача метода преобразование string в int, сразу объявляем переменную result

    Console.WriteLine(result);
}
}
}*/

/*namespace InExample
    //in - при присвоении параметра нельзя больше присвоить значение - "ReadOnly"
{
    class Program
    {

        static void Foo(in int value)
        {
            //value = 5;
            Console.WriteLine(value); // - можем только читать данные , как строчкой выше нельзя сделать
        }
        static void Main(string [] args)
        {
            int a = 5;

            Foo(a);
        }
    }
}*/

/*namespace Param
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum2(int a, int b, int c, int d)
        {
            return a + b + c;
        }

        static int Sum3(params int[] paramet)// двух методов params быть не может
        {
            int result = 0;

            for (int i = 0; i < paramet.Length; i++)
            {
                result+=paramet[i];
            }

            return result;  
        }
        public static void Main(string [] args)
        {
            //int res = Sum(5, 10);

            //int res = Sum2()

            int [] myArray = {10, 25, 387};
            int res = Sum3(myArray);

            //int res = Sum3(); //- можно писать без параметров, тогда слово params будет игнорировать ОТСУТСТВУЮЩИЕ ДАННЫЕ

            Console.Write(res);
        }
    }
}*/

/*namespace ParamsExample
{
    class Program
    {

        static void Foo(params object [] parameters)
        {
            string msg = " Тип данных {0}, значение {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(msg, item.GetType(), item);
            }
        }
        public static void Main(string[] args)
        {
            Foo("star", 454, "qq", 5.4f, true );
        }
    }
}*/


/*namespace ParametrExample
{
    class Program
    {

        static int Sum(int a, int b, bool enableLogging = false)// - необязательные параматеры должны быть указаны в конце всех параметров 
        {
            int res = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Результат перемемнной a " + a);
                Console.WriteLine("Результат переменной b " + b);
                Console.WriteLine("Результат сложения " + res);
            }

            return res;
        }
        static void Main (string [] args)
        {
            //int result = Sum(2, 12);

            int result = Sum(2, 22, false);// можно и присвоить третий параметр 

            Console.WriteLine(result);
        }
    }
}*/

/*namespace nameParametres
{
    class Program
    {

        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Значение переменной a: " + a);
                Console.WriteLine("Значение переменной b: " + b);
                Console.WriteLine("Значение результата сложения: " + result);
            }
            return result;
        }
        

        public static void Main(string[] args)
        {
            int firstValue = 5;
            int secondValue = 20;

            int result = Sum(firstValue, secondValue,enableLogging: true);// экономия времени для понимания

            Console.WriteLine("Результат: " + result);
            /*int result = Sum(b:5,a:3);// именованые парамеры указываю какой переменной что передать. Порядок в данном случае неважен
            Console.WriteLine (result);
        }
    }
}*/

/*namespace Recursion
    //рекурсия
{
    class Program
    {
        static void Foo(int i)
        {
            Console.WriteLine(i);

            if (i >= 3)
            {
                return;
            }// условие выхода цикла

            i++;
            Foo(i);// внутри метода вызываем сам метод
        }

        static void Main(string [] args)
        {
            Foo(0);//следить за stackoverflow - переполнение стэка
        }// f9 - f5 - f11(шаг break Point
    }
}*/

/*namespace RecursionExample2
{
    class Program
    {
        class Item
        {
            public int Value { get; set; }
            public Item Child { get; set; }
        }

        static Item InitIntem()
        {
            return new Item()
            {
                Value = 5,
                Child = new Item()
                {
                    Value = 10,
                    Child = new Item()
                    {
                        Value = 2
                    }
                }
            };
        }


        static void Print(Item item)
        {

            if (item != null)
            {
                Console.WriteLine(item.Value);
                Print(item.Child);
            }
        }

        static void Main(string[] args)
        {
                  Item item = InitIntem();

            //Print(InitIntem());


            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }


        }

        
    }
}*/

// реализовать вывод массива рекурсией

// найти сумму элементов массива с помошью рекурсии

// найти сумму цифр числа с помощью рекурсии 561 = 12


/*namespace RecursionArray
{
    class Program
    {
        static void PrintArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i + 1]);
                PrintArray(myArray, i + 1);
            }
        }

            public static void Main(string[] args)
        {
            int[] myArray = {5, 3, 2};

            PrintArray(myArray);
        }
    }
}*/

/*namespace SumArrays
{
    class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)

                return 0;

                int result = Sum(myArray, i + 1);

                return myArray[i] + result;
            
        }

        public static void Main(string[] args)
        {
            int [] myArray = { 1, 2, 3 };
            
            int result = Sum(myArray);

            Console.WriteLine(result);
        }
    }
}*/


/*namespace SumChisel
{
    class Program
    {
        static int Fool(int chis)
        {
            if (chis < 10)
                return chis;

            int digit = chis % 10;

            int nextValue = chis / 10;

            return digit + Fool(nextValue);

        }

        static void Main(string[] args)
        {
            //int chislo = 11232;

            int chislo = int.Parse(Console.ReadLine());

            int result = Fool(chislo);

            Console.WriteLine(result);
        }
    }
}*/




/*namespace SumChisla
{
    class Program
    {
        static int Foo(int Value)
        {
            if (Value < 10)
            {
                return Value;
            }
            else
            {
                int degr = Value % 10;

                int dig = Value / 10;

                return degr + Foo(dig);
            }

            /*int res = 0;

            while (Value > 0)
            {
                res += Value % 10;
                Value = Value / 10;
            }

            //return res;
        }


        static void Main(string[] args)
        {
            //int Va = int.Parse(Console.ReadLine());

            int Va = 2234234;

            int result = Foo(Va);

            //Console.WriteLine(result);
        }
    }
}*/

/*namespace Enought
{
    class Program
    {
        static void Main(string[] args)
        {
            byte agression = 1;

            byte democracyModifier = 2;//1

            try
            {
                agression = checked((byte)(agression - democracyModifier));// сужающее преобразование данных

                Console.WriteLine(agression);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка выполнения");// если в блоке try возникает исключение, мы перехватываем его и выдаем данную ошибку
            }

            
        }
    }
}*/


/*namespace Nullable
{

    // совместимые значимые типы (Nullable)
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            //int a = null;// - нельзя присвоить тип данных null значимому типу

            //DateTime dateTime = null;// - тоже нельзя присвоить дате null

            int? a = null;

            DateTime? dateTime = null;// - так можно присвоить null ссылочному типу данных в heap

            Console.WriteLine(a.HasValue);//flag .HasValue - bool true/false false - если не присвоено значение в переменную. 
            Console.WriteLine(a == null);
            Console.WriteLine(a.GetValueOrDefault(3));// если переменная null , то появляется этот метод, иначе будет значение дефолта, иначе если не указано будет 0
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(a ?? 55);// если Null , сравнивается и выводится значение
            Console.WriteLine(a.Value);// доступ к полю переменной - если null, то получаем ошибку

            Console.WriteLine(a);
        }
    }
}*/


/*namespace varExample// неявно типизированная переменная
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = 5;

            var t = "Hello world!";

            var b = new float[10];

            int a = 7;

            var x = (string)null;//приведение к null

            Console.WriteLine(t.GetType());// узнать тип данных переменной
            Console.WriteLine(b.GetType());
            Console.WriteLine(c + a);
        }
    }
}*/


/*namespace varExample3
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            var t = Sum(2, 3);
            Console.WriteLine(t);
        }
    }
}*/



/*namespace exampleKey
{
    class Program
    { 
        public static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                // метод ReadKey возвращает структуру консили KeyInfo в которой есть поле Key, в которой хранится информация
                // о том какая клавиша нажата
                //.Key и есть объект типа enum

                int keyCode = (int) key;

                Console.WriteLine($"\tEnum {key} \t Key Code{keyCode}");// выводим название нажатой клавиши и ее код


                if (key == ConsoleKey.Enter)// если key = Enter 
                {
                    Console.WriteLine("Вы нажали enter!");
                }

            }
        }
    }
}*/


/*namespace myEnum
{
    class Program
    {
        /*enum DayofWeek : byte // можно указать тип данных : byte - делается, чтобы уменьшить объем используемой памяти на byte вместо int
        {
            Monday  = 1, // нумерация с нуля, можно не указывать Monday = 1
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Yellow
        }

        static void Main(string[] args)
        {
            //DayOfWeek dayOfWeek = DayOfWeek.Monday; // присвоили значение Monday

            /*byte value = 55;

            dayOfWeek = (DayOfWeek) value;

            if (Enum.IsDefined(typeof(DayofWeek), value))//инф-я о типе данных (typeof) проверка есть ли в этом Enum данное приведенное значение 55
            {
                dayOfWeek = (DayOfWeek) value;
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value");
            }*/

            /*var values = Enum.GetValues(typeof(Color));

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }*/

            //Parsing Enum

            
            /*string str = Console.ReadLine();
            Color color = (Color) Enum.Parse(typeof(Color), str, ignoreCase: true);
            Console.WriteLine(color);

            switch (color)//switch for color
            {
                case Color.White:
                    break;
                case Color.Red:
                    break;
                default:
            }

            //Console.WriteLine(Enum.GetUnderlyingType(typeof(DayofWeek))); //тип данных enum, typeof - информация о типе данных

            //Console.WriteLine(dayOfWeek); // день недели

            /*Console.WriteLine((int) dayOfWeek); //номер 

            Console.WriteLine((DayOfWeek) 3); // приводим int к DayOfWeek

            //DayOfWeek nextDay = GetNextDay(dayOfWeek); // получаем следующий день, передавая текущий день в метод GetNextDay

            //Console.WriteLine(nextDay);

        }

         static DayOfWeek GetNextDay(DayOfWeek day) // в качестве параметра передаем переменную day параметра DayOfWeek
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;
            
            return DayOfWeek.Monday;
        }
    }
}*/

//lesson 74
namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}