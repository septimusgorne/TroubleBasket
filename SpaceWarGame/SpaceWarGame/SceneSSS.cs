using SpaceWarGame.GameObjectFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame 
{
    /*class Scene 
    {
        public List<GameObject> swarm;
        public List <GameObject> ground;
        public GameObject playerShip;
        public List<GameObject> playerShipMissile;

        GameSettings _gameSettings;

        private static Scene _scene;

        private Scene()
        {

        }
        
        private Scene(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            swarm = new AlienShipFactory(_gameSettings).GetSwarm();
            ground = new GroundFactory(gameSettings).GetGround();
            playerShip = new PlayerShipFactory(gameSettings).GetGameObject();
            playerShipMissile = new List<GameObject>();///
        }

        public static Scene GetScene(GameSettings gameSettings)
        {
            if(_scene == null)
            {
                _scene = new Scene(gameSettings);
            }
            return _scene;
        }
    }*/
}
