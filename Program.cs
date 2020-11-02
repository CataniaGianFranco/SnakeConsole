using System;

namespace SnakeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake game";
            Console.CursorVisible = false;
            SnakeGame game = new SnakeGame();
            game.Start();            
            game.Update();
            Console.ReadKey();
        }
    }
}