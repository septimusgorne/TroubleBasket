using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Interface_Example_2
{
    /* interface IDataProvider
         //интерфейс предназначен для определения
         //контракта для класса, который будет
         //получать данные откуда-то!
         //
     {
         string GetData();
         //Нужно указать в каком формате будем получать
         //данные, и как будет называться метод, который
         //мы будем вызывать, чтобы эти данные получить 
         //------------------------------------------
         //в нашем случае мы хотим получить в виде строки 
         //возвращаемый тип string метода GetData();
     }

     interface IDataProcessor
     {
         void ProcessData(IDataProvider dataProvider);
         //в качестве параметра метод будет принимать
         //объект класса, который будет реализовывать 
         //интерфейс IDAtaProvider !!Warning property!!
         //--------------------------------------------
         //то что мы можем принимать тип данных, у которых
         //это тип интерфейса это ОЧЕНЬ ВАЖНЫЙ МОМЕНТ!
     }

     class ConsoleDataProcessor : IDataProcessor
         //реализуем в классе интерфейс
     {
         void IDataProcessor.ProcessData(IDataProvider dataProvider)
         {
             //сюда мы должны получать нечто, что реализует 
             //интерфейс IDataProvider
             Console.WriteLine(dataProvider.GetData());
             //мы можем получить данные вызвав метод GetData
             //и вывести это на косноль
         }
     }

     class DbDataProvider : IDataProvider
     {
         string IDataProvider.GetData()
         {
             return "Получены данные из Базы данных...";
         }
     }

     class APIDataProvider : IDataProvider
     {
         string IDataProvider.GetData()
         {
             return "Получены данные из API...";
         }
     }

     class FileDataProvider : IDataProvider
     {
         string IDataProvider.GetData()
         {
             return "Получены данные из файла";
         }
     }

     /*class Weapon
     {
         private void Fire()
         {
             Console.WriteLine("Пфщь");
         }
     }*/


    /*class Program
    {
        public static void Main(String[] args)
        {
            //IDataProcessor dataProcessor;
            //Это позволяет использовать ПОЛИМОРФИЗМ, как
            //и в случае с абстрактными классами и наследованием
            //---------------------------------------------
            //ссылка интерфейса может хранить объекты любого
            //класса, который этот интерфейс реализовывает

            IDataProcessor dataProcessor = new ConsoleDataProcessor();

            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            //присвоили в объект dataProcessor класс ConsoleDataProcessor();
        }
    }*/

    /*interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessorData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        void IDataProcessor.ProcessorData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());//!!!!
        }
    }
    class DbDataProvider : IDataProvider
    {
        string IDataProvider.GetData()
        {
            return "Get data for SQL1.....\n";
        }
    }
    class FileDataProvider : IDataProvider
    {
        string IDataProvider.GetData()
        {
            return "Geta data for open File...\n";
        }
    }
    class APIDataProvider : IDataProvider
    {
        string IDataProvider.GetData()
        {
            return "Get data for APIException...\n";
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessorData(new APIDataProvider());
            Console.WriteLine("Wait for 5 second");
            //Thread.Sleep(230);
            //---------------sleep for loading interface's
            dataProcessor.ProcessorData(new DbDataProvider());
            dataProcessor.ProcessorData(new FileDataProvider());
            //Console.Clear();
        }
    }*/


    interface IDataProvider
    {
        string GetData();
    }
    interface IDataProcessor
    {
        void DataProcessor(IDataProvider dataProvider);
    }
    class ConsoleDataProcessor : IDataProcessor
    {
        void IDataProcessor.DataProcessor(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        string IDataProvider.GetData()
        {
            return "For SQL...";
        }
    }

    class FileDataProvider : IDataProvider
    {
        string IDataProvider.GetData()
        {
            return "For open file...";
        }
    }

    class APIDataProvider : IDataProvider
    {
        string IDataProvider.GetData()
        {
            return "For API...";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();

            dataProcessor.DataProcessor(new DbDataProvider());
            dataProcessor.DataProcessor(new APIDataProvider());

            dataProcessor.DataProcessor(new FileDataProvider());
        }
    }
}