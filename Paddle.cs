using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        //only acessed by ball class
        public int x;
        public int y;
        public int size;

        //only acessed by game class
        public int points = 0;

        private int pointX;
        private int pointY;

        public Paddle(int x, int y, int size, int pointX, int pointY)
        {
            this.x = x;
            this.y = y;
            this.size = size;

            this.pointX = pointX;
            this.pointY = pointY;
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

        public void UnDraw()
        {
            for (int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(" ");
            }
        }
        public void DrawPoints()
        {
            Console.SetCursorPosition(pointX, pointY);
            Console.Write("Points:" + points);
        }

        public void AddPoints()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            points++;
        }
    }
}
