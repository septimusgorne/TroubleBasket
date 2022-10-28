using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame.Menu
{
    public abstract class MenuItem : GameObject
    {
        protected char[,] message;

        protected MenuItem(MatrixPosition topLeft, char[,] message)
            :base (topLeft, message)
        {

        }
        public abstract void TakeAction(Engine engine);
    }
}
