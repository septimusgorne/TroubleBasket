using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public static class CollisionDispatcher
    {
        public static void HandleCollisions(List<MovingObject> movingObjects, List<GameObject> staticObjects, List<MovingObject> alienShips, PlayerShip playerShip)
        {
            foreach (var obj in movingObjects)
            {
                //handle projectile collisions
                if (obj is Projectile)
                {
                    //If the owner of the projectile is the player, check if it hits an alien
                    //else check if the player is hit
                    if ((obj as Projectile).Owner == ProjectileOwner.Player)
                    {
                        foreach (var alien in alienShips)
                        {
                            if (obj.TopLeft.Row == alien.TopLeft.Row && obj.TopLeft.Col == alien.TopLeft.Col)
                            {
                                alien.RespondToCollision(CollisionType.Destruction);
                                obj.RespondToCollision(CollisionType.Destruction);
                                playerShip.IncreaseScore(1);
                            }
                        }

                        //player projecile colliding with a wall
                        foreach (var staticObj in staticObjects)
                        {
                            if (obj.TopLeft.Row == (staticObj.TopLeft.Row + 1) && obj.TopLeft.Col == staticObj.TopLeft.Col)
                            {
                                obj.RespondToCollision(CollisionType.Destruction);
                            }
                        }
                    }
                    else
                    {
                        if (obj.TopLeft.Row == playerShip.TopLeft.Row && obj.TopLeft.Col == playerShip.TopLeft.Col)
                        {
                            playerShip.RespondToCollision(CollisionType.Destruction);
                            obj.RespondToCollision(CollisionType.Destruction);
                        }
                    }

                    //alien projectile colliding with a wall
                    foreach (var staticObj in staticObjects)
                    {
                        if (!(staticObj is PlayerShip))
                        {
                            if (obj.TopLeft.Row == (staticObj.TopLeft.Row - 1) && obj.TopLeft.Col == staticObj.TopLeft.Col)
                            {
                                obj.RespondToCollision(CollisionType.Destruction);
                            }
                        }
                    }
                }


            }

            foreach (var obj in movingObjects)
            {
                //ensure aliens are bouncing off the walls
                if (obj is AlienShip)
                {
                    if (CollidesWithWall(obj, staticObjects))
                    {
                        //if one alien hits a wall, change direction for all aliens
                        ChangeAliensDirection(movingObjects);
                        break;
                    }
                }

                if (obj is Gift)
                {
                    if (obj is GiftPoints)
                    {
                        if (obj.TopLeft.Row == playerShip.TopLeft.Row && obj.TopLeft.Col == playerShip.TopLeft.Col)
                        {
                            playerShip.IncreaseScore(10);
                            obj.RespondToCollision(CollisionType.Destruction);
                        }
                    }
                    if (obj is GiftLife)
                    {
                        if (obj.TopLeft.Row == playerShip.TopLeft.Row && obj.TopLeft.Col == playerShip.TopLeft.Col)
                        {
                            playerShip.BonusLife();
                            obj.RespondToCollision(CollisionType.Destruction);
                        }
                    }
                }
            }
        }

        private static void ChangeAliensDirection(List<MovingObject> movingObjects)
        {
            foreach (var alien in movingObjects)
            {
                if (alien is AlienShip)
                {
                    alien.RespondToCollision(CollisionType.Bounce);
                }
            }
        }

        private static bool CollidesWithWall(MovingObject obj, List<GameObject> staticObjects)
        {
            foreach (var staticObj in staticObjects)
            {
                if (staticObj is Wall && obj.TopLeft.Row == staticObj.TopLeft.Row)
                {
                    if (obj.TopLeft.Col - 1 == staticObj.TopLeft.Col)
                    {
                        return true;
                    }
                    else
                    {
                        if (obj.TopLeft.Col + 1 == staticObj.TopLeft.Col)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
