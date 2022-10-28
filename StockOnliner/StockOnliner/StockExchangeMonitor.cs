using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOnliner // create library for Program.cs
{
    public class StockExchangeMonitor// create class for get price from VirtualExchange
    {
        public delegate void PriceChange(int price);// delegate method (accept int price parameter)

        public PriceChange PriceChangeHandler { get; set; } // method which alert new price
        
        public void Start() // start ExchangeMonitor
        {
            while(true)// get price exchange in infinity cycles
            {
                int bankOfAmerikaPrice = (new Random()).Next(2, 100);// Random pice 2 to 100$

                PriceChangeHandler(bankOfAmerikaPrice);// alert price all 

                Thread.Sleep(2000);// sleep wait 2 seconds
            }
        }
    }
}
