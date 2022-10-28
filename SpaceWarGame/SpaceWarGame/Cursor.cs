using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class Cursor : GameObject
    {
        public bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public Cursor(MatrixPosition topLeft)
            : base(topLeft, new char[,] { { '>', '>' } })
        {
            this.isActive = false;
        }

        public void MoveUp()
        {
            if (this.topLeft.Row > 3)
            {
                this.topLeft.Row -= 2;
            }
        }

        public void MoveDown()
        {
            this.topLeft.Row += 2;
        }

    }
}
