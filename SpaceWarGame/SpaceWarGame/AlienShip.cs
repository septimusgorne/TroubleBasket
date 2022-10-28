using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class AlienShip : MovingObject
    {
        // alien shooting added
        public bool IsShooting { get; set; }

        public AlienShip(MatrixPosition topLeft, MatrixPosition speed)
            : base(topLeft, new char[,] { { '@' } }, speed)
        {
            this.framesPerMove = 5;
        }

        private void ChangeSymbol()
        {
            switch (this.life)
            {
                case 1:
                    this.image[0, 0] = '@';
                    break;
                case 2:
                    this.image[0, 0] = '?';
                    break;
                case 3:
                    this.image[0, 0] = '~';
                    break;
                default:
                    break;
            }
        }

        public override void RespondToCollision(CollisionType collisionType)
        {
            if (collisionType == CollisionType.Bounce)
            {
                if (this.currentFrame == 0)
                {
                    this.Speed.Col *= -1;
                    this.topLeft.Row++;
                }
            }

            if (collisionType == CollisionType.Destruction)
            {
                this.Destroy();
                this.ChangeSymbol();
            }
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsShooting)
            {
                var projectile = new Projectile(this.topLeft, new MatrixPosition(1, 0));
                projectile.Owner = ProjectileOwner.Alien;
                producedObjects.Add(projectile);
                this.IsShooting = false;
            }

            Gift producedGift = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
            if (this.IsDestroyed)
            {
                producedGift = GameData.GetGift();

                if (producedGift is GiftLife)
                {
                    producedGift = new GiftLife(new MatrixPosition(this.TopLeft.Row + 1, this.TopLeft.Col), new MatrixPosition(1, 0));
                    producedObjects.Add(producedGift);
                }

                if (producedGift is GiftPoints)
                {
                    producedGift = new GiftPoints(new MatrixPosition(this.TopLeft.Row + 1, this.TopLeft.Col), new MatrixPosition(1, 0));
                    producedObjects.Add(producedGift);
                }
            }

            return producedObjects;
        }

        public override void Update()
        {
            if (GameData.ShootingProbability())
            {
                this.IsShooting = true;
            }

            this.UpdatePosition();
        }
    }
}
