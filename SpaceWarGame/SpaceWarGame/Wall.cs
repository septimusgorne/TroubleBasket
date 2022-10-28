using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class Wall : GameObject
    {
        public Wall(MatrixPosition topLeft)
            : base(topLeft, new char[,] { { '#' } })
        {

        }
    }
}
