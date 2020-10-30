namespace SnakeConsole
{
    public class Game
    {
        private Snake snake = new Snake();

        public void Update()
        {
            snake.UpdateSnake();    
        }
    }
}