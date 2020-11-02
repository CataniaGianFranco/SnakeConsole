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

                DetectCollision();        
            }
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("GameOver");
           Console.Write("Name: Chicho\nFood: {0}", score);
            
        }
        private void DetectCollision()
        {
            Position headPosition = snake.PartsOfTheSnake[0];
            if (headPosition.X == food.Position.X && headPosition.Y == food.Position.Y )
            {
                if (snake.PartsOfTheSnake.Count == 1)
                {
                    if (snake.Direction == Direction.Up)
                        snake.AddBody(headPosition.X, headPosition.Y + 1);
                    else if (snake.Direction == Direction.Down)
                        snake.AddBody(headPosition.X, headPosition.Y - 1);
                    else if (snake.Direction == Direction.Left)
                        snake.AddBody(headPosition.X + 1, headPosition.Y);
                    else if (snake.Direction == Direction.Right)
                        snake.AddBody(headPosition.X - 1, headPosition.Y);
                }
                food.GenerateFood(width,height);
                score += 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0,0);
                Console.Write("  Name: Chicho - Food: {0}  ", score);
            }
            if (headPosition.X == 0 || headPosition.X == width || headPosition.Y == 1 || headPosition.Y == height)
                {
                    game = false;
                }
        }
    }
}