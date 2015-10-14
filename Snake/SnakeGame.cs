using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Snake
{
    class SnakeGame
    {
        static void Main()
        {
            Draw(0,5,'*');
            Draw(1,6,'#');
            
        }

        private static void Draw(int x, int y, char img)
        {
            SetCursorPosition(x,y);
            Write(img);
        }
    }
}
