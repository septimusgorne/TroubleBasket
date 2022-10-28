using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class Gift : MovingObject
    {
        public Gift(MatrixPosition topLeft, MatrixPosition speed)
           : base(topLeft, new char[,] { { 'G' } }, speed)
        {
            this.framesPerMove = 5;

        }

        public Gift(MatrixPosition topLeft, char[,] image, MatrixPosition speed)
            : base(topLeft, image, speed)
        {
            this.framesPerMove = 5;
        }

        public override void RespondToCollision(CollisionType collisionType)
        {

            if (collisionType == CollisionType.Destruction)
            {
                this.Destroy();
            }
        }
    }
}
