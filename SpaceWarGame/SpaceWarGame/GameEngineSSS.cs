using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpaceWarGame;
using SpaceWarGame.GameObjectFactories;

namespace SpaceWarGame
{
    /*class GameEngine
    {
        private bool _isNotOwer;

        private static GameEngine _gameEngine;

        private SceneRender _sceneRender;

        private GameSettings _gameSettings;

        private Scene _scene;

        private GameEngine()
        {

        }

        public static GameEngine GetGameEngine(GameSettings gameSettings)
        {
            if (_gameEngine == null)
            {
                _gameEngine = new GameEngine(gameSettings);
            }
            return _gameEngine;

        }

        public GameEngine(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            _isNotOwer = true;
            _scene = Scene.GetScene(gameSettings);
            _sceneRender = new SceneRender(gameSettings);
        }

        public void Run()
        {
            int swarmMoveCounter = 0;
            int playerMissileCounter = 0;
            do
            {
                _sceneRender.Render(_scene);    

                Thread.Sleep(_gameSettings.GameSpeed);

                _sceneRender.ClearScene();

                if (swarmMoveCounter == _gameSettings.SwarmSpeed)///here
                {
                    CalculateSwarmMove();
                    swarmMoveCounter = 0; 
                }
                swarmMoveCounter++;


                if(playerMissileCounter == _gameSettings.PlayerMissileSpeed)
                {
                    CalculateMissilleMove();
                    playerMissileCounter = 0;
                }
                playerMissileCounter++;
            }
            while (_isNotOwer);

            Console.ForegroundColor = ConsoleColor.Red;
            _sceneRender.RenderGameOver();

        }
        public void CalculateMovePlayerShipLeft()
        {
            if (_scene.playerShip.GameObjectPlace.XCoordinate > 1)
            {
                _scene.playerShip.GameObjectPlace.XCoordinate--;
            }
        }
        public void CalculateMovePlayerShiftRight()
        {
            if (_scene.playerShip.GameObjectPlace.XCoordinate < _gameSettings.ConsoleWidth)
            {
                _scene.playerShip.GameObjectPlace.XCoordinate++;
            }
        }
        public void CalculateSwarmMove()
        {
            for (int i = 0; i < _scene.swarm.Count; i++)//max ship
            {
                GameObject alienShip = _scene.swarm[i];

                alienShip.GameObjectPlace.YCoordinate++;

                if (alienShip.GameObjectPlace.YCoordinate == _scene.playerShip.GameObjectPlace.YCoordinate)
                {
                    _isNotOwer = false;
                }
            }
        }
    
        public void Shot()
        {
            PlayerShipMissileFactory missileFactory = new PlayerShipMissileFactory(_gameSettings);//

            GameObject missile = missileFactory.GetGameObject(_scene.playerShip.GameObjectPlace);

            _scene.playerShipMissile.Add(missile);//add for collection

            Console.Beep(1000, 200); 
        }

        public void CalculateMissilleMove()
        {
            if (_scene.playerShipMissile.Count == 0)
            {
                return;
            }

            for (int x = 0; x < _scene.playerShipMissile.Count; x++)
            {
                    GameObject missile = _scene.playerShipMissile[x];

                    if(missile.GameObjectPlace.YCoordinate == 1)

                    {
                        _scene.playerShipMissile.RemoveAt(x);
                    }

                    missile.GameObjectPlace.YCoordinate--;

                    for (int i = 0; i < _scene.swarm.Count; i++)
                    {
                        GameObject alienShip = _scene.swarm[i];
                        if(missile.GameObjectPlace.Equals(alienShip.GameObjectPlace))
                        {
                            _scene.swarm.RemoveAt(i);

                            _scene.playerShipMissile.RemoveAt(x);

                            break;  
                        }
                    }
            }
         
        }
    }*/
}
