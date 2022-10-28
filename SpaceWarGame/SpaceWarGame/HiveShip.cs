﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class HiveShip : AlienShip
    {
        public HiveShip(MatrixPosition topLeft, MatrixPosition speed)
            : base(topLeft, speed)
        {
            base.image = new char[,] { { '&' } };
            this.life = 5;
        }
    }
}
