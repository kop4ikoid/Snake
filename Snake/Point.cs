using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    class Point
    {
        public int X;
        public int Y;
        public char Img;

        public void Draw()
        { 
            SetCursorPosition(X,Y);
            Write(Img);
        }
    }
}
