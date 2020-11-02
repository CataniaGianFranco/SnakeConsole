using System;
namespace SnakeConsole
{
    public class SnakeGame
    {
        private bool game = true;
        private const int width = 26;
        private const int height = 12;
        private int score = 0;
        private Snake snake = new Snake(5,5);
        private Scene scene = new Scene();
        private Food food = new Food();

        public void Start()
        {    
            scene.Draw();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0,0);
            Console.Write("  Name: Chicho - Food: {0} ", score);
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
                    Console.Write("  Name: Chicho - Food: {0}  ", score);
                }

                if (snake.Position.X == 0 || snake.Position.X == width || snake.Position.Y == 1 || snake.Position.Y == height)
                {
                    game = false;
                }
                    
            }
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("GameOver");
           Console.Write("Name: Chicho\nFood: {0}", score);
            
        }
    }
}