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
            double firstValue, secondValue;

            Console.WriteLine("Введите число 1");// вывод сообщения в консоль

            firstValue = double.Parse(Console.ReadLine());//возвращает метод Parse, тип Double

            Console.WriteLine("Введите число 2");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;

            Console.WriteLine("Среднее арифметическое = " + result);
        }

    }
}