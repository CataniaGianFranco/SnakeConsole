using System;
namespace SnakeConsole
{
    public class SnakeGame
    {
        private bool game = true;
        private const int width = 15;
        private const int height = 10;
        private Snake snake = new Snake(5,5);
        private Food food = new Food();

        public void Start()
        {
            food.GenerateFood(width,height);
        }
        public void Update()
        {       
            
            while (game == true)
            {
                snake.UpdateSnake();

                if (snake.Position.X == food.Position.X && snake.Position.Y == food.Position.Y )
                    food.GenerateFood(width,height);
            }
           
            
        }
    }
}