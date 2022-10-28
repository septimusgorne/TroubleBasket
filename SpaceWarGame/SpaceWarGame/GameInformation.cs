using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class GameInformation : GameObject
    {
        public GameInformation(MatrixPosition topLeft, string msg) : base(topLeft, new char[,] { { 'a' } })
        {
            char[] msgArr = msg.ToCharArray();
            this.image = new char[1, msgArr.Length];
            for (int i = 0; i < msgArr.Length; i++)
            {
                this.image[0, i] = msgArr[i];
            }

            this.topLeft = topLeft;
        }

        public virtual void RefreshMessage(string msg)
        {
            char[] msgArr = msg.ToCharArray();
            this.image = new char[1, msgArr.Length];
            for (int i = 0; i < msgArr.Length; i++)
            {
                this.image[0, i] = msgArr[i];
            }
        }
    }
}
