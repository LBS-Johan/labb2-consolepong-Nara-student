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

        List<int> randomDirection = new List<int> {-1, 1};

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
            //bounce on y axis
            if(y == 0)
            {
                yVelocity = 1;
            }

            if(y == height - 1)
            {
                yVelocity = -1;
            }

            //checks if ball hits goal of player 1
            if(x == 0)
            {
                //puts it back in middle
                x = width / 2;

                //randomizes X direction
                Random random = new Random();
                xVelocity = randomDirection[random.Next(0, 2)];

                //adds points
                player2.AddPoints();
            }
            //checks if ball hits goal of player 2
            if (x == width - 1)
            {
                //puts it back in middle
                x = width / 2;

                //randomizes X direction
                Random random = new Random();
                xVelocity = randomDirection[random.Next(0, 2)];

                //adds points
                player1.AddPoints();
            }

            //collision with player 2
            if(x == player2.x && (y >= player2.y && y <= player2.y + player2.size))
            {
                xVelocity = -1;
            }

            //collision with player 1
            if (x == player1.x && (y >= player1.y && y <= player1.y + player1.size))
            {
                xVelocity = 1;
            }
        }
    }
}
