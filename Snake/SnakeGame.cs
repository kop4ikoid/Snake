﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakeGame
    {
        static void Main()
        {
            var p = new Point{Img = '#', X = 2, Y = 5};
            p.Draw();
        }
    }
}
