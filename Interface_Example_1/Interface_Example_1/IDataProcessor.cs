using Interface_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_1
{
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
        //интерфейс обработчика данных
        //в классе который будет реализовывать этот интерфейс
        //будет присутствовать метод ProcessorData
        //который в качестве параметра будет принимать 
        //объект класса, который будет реализовывать интерфейс
        //IDataProvider
    }
}
