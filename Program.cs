using System;

namespace SnakeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake game";
            Console.CursorVisible = false;
            Game game = new Game();            
            game.Update();
            Console.ReadKey();
        }
    }
}