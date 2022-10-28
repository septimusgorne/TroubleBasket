using Codaza_Exchange_Example;
using System;

namespace StockOnliner
{

    class Program
    {

        static void Main()
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();

            stockExchangeMonitor.PriceChangeHandler = ShowConsole;
            //регистрируем метод через свойство PricaChangeHandler

            stockExchangeMonitor.Start();
            //Запускаем монитор
        } 

        public static void ShowConsole(int price)
        {
            Console.WriteLine($"New price is:  + { price} ");
        }
    }
}