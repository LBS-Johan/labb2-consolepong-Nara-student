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
        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            player1 = new Paddle(0, 10, 5);
            player2 = new Paddle(100, 10, 5);
        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            player1.Draw();
            player2.Draw();

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



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
