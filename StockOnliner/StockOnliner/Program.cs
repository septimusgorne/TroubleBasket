using System;

namespace StockOnliner
{
    class Program
    {
        static  void Main(string[] args)
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();// create new instance class StockExchangeMonitor

            stockExchangeMonitor.PriceChangeHandler = ShowPrice;// registration method through property "Handler" 
            stockExchangeMonitor.Start();// Start 
        }

        public static void ShowPrice(int price)//create method which show current price on the monitor
        {
            Console.WriteLine($" Текущая цена: {price}");//write current price
        }
    }
}