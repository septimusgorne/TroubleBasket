using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class Score : GameInformation
    {
        public Score(MatrixPosition topLeft, string msg)
            : base (topLeft, msg)
            {
        }
    }
}
