using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codaza_Exchange_Example
{
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);

        public PriceChange PriceChangeHandler { get; set; }
        //через этот код метод сможет предоставлять оповещения
        // о новой цене

        public void Start()
        {
            while(true)
            {
                int bankOfAmericaPrice = (new Random().Next(100));
                //получим рандомную цену

                PriceChangeHandler(bankOfAmericaPrice);
                //оповестим о новой цене

                Thread.Sleep(2000);
            }
        }

    }
}
