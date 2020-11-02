using System;
namespace SnakeConsole
{
    public class SnakeGame
    {
        private bool game = true;
        private const int width = 27;
        private const int height = 12;
        private int score = 0;
        private Snake snake = new Snake(5,5);
        private Food food = new Food();

        public void Start()
        {
           
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0,0);
            Console.Write("  Name: Chicho - Score: {0}  ", score);
            food.GenerateFood(width,height);
        }
        public void Update()
        {       
            
            while (game == true)
            {
                snake.UpdateSnake();

                if (snake.Position.X == food.Position.X && snake.Position.Y == food.Position.Y )
                {
                    food.GenerateFood(width,height);
                    score += 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0,0);
                    Console.Write("  Name: Chicho - Score: {0}  ", score);
                }
                    
            }
           
            
        }
    }
}