using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    /*class Program
    {
        static GameEngine gameEngine;
        static GameSettings gameSettings;
        static UIController uIController;
        static MusicController musicController;

        static void Main(string[] args)
        {
            Initialize();

            gameEngine.Run();
        }

        public static void Initialize()
        {
            gameSettings = new GameSettings();
            gameEngine = GameEngine.GetGameEngine(gameSettings);

            uIController = new UIController();
            uIController.OnAPressed += (obj, arg) => gameEngine.CalculateMovePlayerShipLeft();
            uIController.OnDPressed += (obj, arg) => gameEngine.CalculateMovePlayerShiftRight();
            uIController.OnSpacePressed += (obj, arg) => gameEngine.Shot();


            Thread uIthread = new Thread(uIController.StartListning);
            
            uIthread.Start();

            musicController = new MusicController();
            Thread musicThread = new Thread(musicController.PlayerBackgroundMusic);
            musicThread.Start();

            Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
        }
    }*/
}
