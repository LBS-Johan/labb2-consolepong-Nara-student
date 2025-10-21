using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        public int x;
        public int y;
        public int size;

        public Paddle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public void Move(int yAmount)
        {
            //checks if paddle doesnt reach border 
            int newYPosition = y + yAmount;
            if(newYPosition != 0 && newYPosition + size != Console.WindowHeight - 1)
            {
                y += yAmount;
            }
        }

        public void Draw()
        {
            for(int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|");
            }
        }
    }
}
