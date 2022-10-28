using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame.Menu
{
    public class StartResume : MenuItem
    {
        public static char[,] message = { { 'S', 'T', 'A', 'R', 'T' } };

        public StartResume(MatrixPosition topLeft)
            : base (topLeft, message)
        {

        }

        public override void TakeAction(Engine engine)
        {
            engine.Run();
        }
    }
}
