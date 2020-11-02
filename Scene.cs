using System;
namespace SnakeConsole
{
    public class Scene
    {
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int column = 1; column < 27; column++)
            {
                Console.SetCursorPosition(column, 1);
                Console.Write("·");      
            }
            for (int column = 1; column < 27; column++)
            {
                Console.SetCursorPosition(column, 12);
                Console.Write("·");
            }
            for (int row = 1; row < 13; row++)
            {
                Console.SetCursorPosition(0, row);
                Console.Write("·");
            }
            for (int row = 1; row < 13; row++)
            {
                Console.SetCursorPosition(26, row);
                Console.Write("·");
            }
        }
    }
}