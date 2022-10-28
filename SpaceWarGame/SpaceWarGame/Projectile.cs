using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public enum ProjectileOwner
    {
        Player = 1, Alien = 2
    }

    public class Projectile : MovingObject
    {
        public ProjectileOwner Owner { get; set; }

        public Projectile(MatrixPosition topLeft, MatrixPosition speed)
            : base(topLeft, new char[,] { { '|' } }, speed)
        {
        }

        public override void RespondToCollision(CollisionType collisionType)
        {
            if (collisionType == CollisionType.Destruction)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
