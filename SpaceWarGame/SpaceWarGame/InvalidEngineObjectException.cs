using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class InvalidEngineObjectException : ApplicationException
    {
        public InvalidEngineObjectException(string msg)
            : base(msg)
        {

        }

        public InvalidEngineObjectException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {

        }
    }
}
