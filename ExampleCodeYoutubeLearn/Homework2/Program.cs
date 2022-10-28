using System;


namespace Homework

/* Вычисление среднего арифметического 
 * 
 * */
{
    class Program

    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите число 1");// вывод сообщения в консоль

            firstValue = double.Parse(Console.ReadLine());//возвращает метод Parse, тип Double

            Console.WriteLine("Введите число 2");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3");

            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;

            double multiResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Сумма чисел = " + sumResult);
            Console.WriteLine("Произведение чисел = " + multiResult);
        }

    }
}
