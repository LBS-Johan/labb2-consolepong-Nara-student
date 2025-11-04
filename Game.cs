using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        Paddle player1;
        Paddle player2;
        Ball ball;

        List<int> randomDirection = new List<int> { -1, 1 };
        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            //Random direction 
            Random random = new Random();

            //sets players and ball position
            player1 = new Paddle(10, 10, 5, 0, 0);
            player2 = new Paddle(width - 10, 10, 5, width - 10, 0);
            ball = new Ball(width/2, 0, randomDirection[random.Next(0, 2)], 1);
        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            //Console.Clear();
            player2.UnDraw();
            player1.UnDraw();

            //Players
            player1.DrawPoints();
            player2.DrawPoints();

            //Ball
            ball.UnDraw();
            ball.Move();
            ball.Draw();
            ball.CheckCollisions(player1, player2, width, height);

            //Player 2
            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
                player2.Move(-1);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
                player2.Move(1);
            }

            //Player 1
            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                player1.Move(-1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                player1.Move(1);
            }
            //draws paddles
            player1.Draw();
            player2.Draw();


            //Return true om spelet ska fortsätta
            if (player1.points == 5 || player2.points == 5)
            {
                Console.Clear();
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
