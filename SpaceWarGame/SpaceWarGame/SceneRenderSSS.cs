using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    /*class SceneRender
    {
        int _screenWidth;
        int _screenHeight;

        char[,] _screenMatrix;

        public SceneRender(GameSettings gameSettings)
        {
            _screenWidth = gameSettings.ConsoleWidth ;
            _screenHeight = gameSettings.ConsoleHeight ;
            _screenMatrix = new char[gameSettings.ConsoleHeight, gameSettings.ConsoleWidth];

            Console.WindowHeight = gameSettings.ConsoleHeight;
            Console.WindowWidth = gameSettings.ConsoleWidth;

            Console.CursorVisible = false;// cursor false
            Console.SetCursorPosition(0, 0);//cursor reset zero
        }

        public void Render(Scene scene)
        {
            ClearScene();

            Console.SetCursorPosition(0, 0);

            AddListForRendering(scene.swarm);
            AddListForRendering(scene.ground);
            AddListForRendering(scene.playerShipMissile);

            AddGameObjectForRendering(scene.playerShip);

            StringBuilder stringBuilder = new StringBuilder();

            for (int y = 0; y < _screenHeight; y++)
            {
                for (int x = 0; x < _screenWidth; x++)
                {
                    stringBuilder.Append(_screenMatrix[y, x]);
                }

                stringBuilder.Append(Environment.NewLine);
            }
            Console.WriteLine(stringBuilder.ToString());
            Console.SetCursorPosition(0, 0);
        }

        public  void AddGameObjectForRendering(GameObject gameObject)
        {
            if(gameObject.GameObjectPlace.YCoordinate < _screenMatrix.GetLength(0) 
                && gameObject.GameObjectPlace.XCoordinate < _screenMatrix.GetLength(1))
            {
                _screenMatrix[gameObject.GameObjectPlace.YCoordinate, gameObject.GameObjectPlace.XCoordinate] = gameObject.Figure;
            }
            else
            {
                ;//_screenMatrix[gameObject.GameObjectPlace.YCoordinate, gameObject.GameObjectPlace.XCoordinate] = ' ';
            }
        }
        
        public void AddListForRendering(List<GameObject> gameObjects)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                AddGameObjectForRendering(gameObject);
            }
        }

        public void ClearScene()
        {
            for (int y = 0; y < _screenHeight; y++)
            {
                for (int x = 0; x < _screenWidth; x++)
                {
                    _screenMatrix[y, x] = ' ';
                }
            }
            Console.SetCursorPosition(0, 0);
        }
        public void RenderGameOver()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Game Over!!!!");

            Console.WriteLine(stringBuilder.ToString());
        }
    }*/
}
