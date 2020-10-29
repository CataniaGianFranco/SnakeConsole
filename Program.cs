using System;

namespace SnakeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ■ <-- Wall
            // ☻ <-- Head
            // ÷ <-- Tail
            // @ <-- Apple
            Console.Title = "Snake";
            Snake snake = new Snake();
            snake.Update();

            Console.ReadKey();
        }
    }
}