using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceWarGame.GameObjectFactories;

namespace SpaceWarGame
{
    /*class PlayerShipMissileFactory : GameObjectFactory
    {
        public PlayerShipMissileFactory(GameSettings gameSettings)
            : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObjectPlace missilePlace = new GameObjectPlace() { XCoordinate = objectPlace.XCoordinate, YCoordinate = objectPlace.YCoordinate - 1}; ;
            GameObject missile = new PlayerShipMissile() { Figure = GameSettings.PlayerMissile, GameObjectPlace = missilePlace, GameObjectType = GameObjectType.PlayerShipMissile };///!!!!!warning LOCAL VALUE

            return missile;
        }
    }*/
}
