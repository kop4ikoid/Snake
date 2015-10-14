using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class SnakeGame
    {
        static void Main()
        {
            var p = new Point{Img = '#', X = 2, Y = 5};
            p.Draw();

            int rowV = 0;
            int colV = 0;
            int row = 10;
            int col = 10;

            for (int i = 0; i < 100; i++)
            {

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        rowV = 0;
                        colV = -1;
                    }

                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        rowV = 0;
                        colV = 1;
                    }

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        rowV = -1;
                        colV = 0;
                    }

                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        rowV = 1;
                        colV = 0;
                    }
                }

                row += rowV;
                col += colV;
                
                Console.Clear();
                Console.SetCursorPosition(col,row);
                Console.Write('o');
                
                Thread.Sleep(500);
            }


        }
    }
}
