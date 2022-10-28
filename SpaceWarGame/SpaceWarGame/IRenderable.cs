﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public interface IRenderable
    {
        MatrixPosition GetPosition();
        //returns the top left position
        char[,] GetImage();
    }
}
