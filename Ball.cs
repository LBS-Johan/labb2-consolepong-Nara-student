using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Ball
    {
        private int x;
        private int xVelocity;
        private int y;
        private int yVelocity;

        public Ball(int x, int y, int xVelocity, int yVelocity)
        {
            this.x = x;
            this.y = y;
            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
        }

        public void Move()
        {
            x += xVelocity;
            y += yVelocity;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }

        public void CheckCollisions(Paddle player1, Paddle player2, int width, int height)
        {
            if(y == 0)
            {
                yVelocity = 1;
            }

            if(y == height - 1)
            {
                yVelocity = -1;
            }

            if(x == 0 || x == width - 1)
            {
                x = 100;
            }
        }
    }
}
