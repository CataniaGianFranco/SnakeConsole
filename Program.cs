using System;

namespace SnakeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            snake.UpdateSnake();
            Console.ReadKey();
        }
    }
}