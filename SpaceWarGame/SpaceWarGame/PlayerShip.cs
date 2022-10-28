using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class PlayerShip : GameObject
    {
        private static PlayerShip instance;
        private bool isShooting;

        public int Score
        {
            get;
            protected set;
        }

        protected PlayerShip(MatrixPosition topLeft)
            : base(topLeft, new char[,] { { '^' } })
        {
            this.isShooting = false;
            this.life = 3;
            this.Score = 0;
        }

        public static PlayerShip Instance(MatrixPosition position)
        {
            if (instance == null)
            {
                instance = new PlayerShip(position);
            }

            return instance;
        }

        public void IncreaseScore(int bonus)
        {
            this.Score += bonus;
        }

        public void BonusLife()
        {
            this.life++;
        }

        public bool IsShooting
        {
            get { return isShooting; }
            set { isShooting = value; }
        }

        public void MoveLeft()
        {
            this.topLeft.Col--;
        }

        public void MoveRight()
        {
            this.topLeft.Col++;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> projectiles = new List<GameObject>();

            if (this.isShooting)
            {
                var projectile = new Projectile(new MatrixPosition(this.topLeft.Row, this.topLeft.Col), new MatrixPosition(-1, 0));
                projectile.Owner = ProjectileOwner.Player;
                projectiles.Add(projectile);
                this.isShooting = false;
            }

            return projectiles;
        }

        public override void RespondToCollision(CollisionType collisionType)
        {
            this.Destroy();
        }
    }
}
