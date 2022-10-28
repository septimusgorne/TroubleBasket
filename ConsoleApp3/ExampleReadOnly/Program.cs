using System;

namespace ExampleReadOnly
{
    class MyLogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|INFO|: {message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|ERROR|: {message}");
        }

        public void Warm(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|WARN|: {message}");
        }
    }

    class Car
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "Двигатель запущен!";
        private const string ATTEMPT_TO_START_ENGINE_ACESS = "Завожу двигатель!";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Двигатель уже запущен!";
        private const string ATTEMPT_TO_DRIVE_MESSAGE = "Нажимай газ!";
        private const string DRIVE_MESSAGE = "Поехали!";
        private const string DRIVE_ERROR_MESSAGE = "Сначала заведи двигатель!";

        private readonly MyLogger _myLogger;

        private bool isEngineStarted;

        public Car(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }

        public void StartEngine()
        {
            _myLogger.Info(ATTEMPT_TO_START_ENGINE_ACESS);//try acess engine

            if(isEngineStarted)
            {
                _myLogger.Warm(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isEngineStarted = true;//engine is started
                _myLogger.Info(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
        }

        public void Drive()
        {
            _myLogger.Info(ATTEMPT_TO_DRIVE_MESSAGE);

            if(isEngineStarted)
                _myLogger.Warm(DRIVE_MESSAGE);
            else
                _myLogger.Info(DRIVE_ERROR_MESSAGE);    
        }

    }


    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car(new MyLogger());
            car.Drive();
            car.StartEngine();
            car.StartEngine();
            car.Drive();
        }
    }
}