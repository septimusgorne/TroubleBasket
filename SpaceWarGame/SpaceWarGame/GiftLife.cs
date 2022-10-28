using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class GiftLife : Gift
    {
        public GiftLife(MatrixPosition topLeft, MatrixPosition speed)
            : base(topLeft, new char[,] { { '*' } }, speed)
        {
            this.framesPerMove = 5;

        }
    }
}
