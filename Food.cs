using System;
namespace SnakeConsole
{
    public class Food
    {
        private Position position = new Position();
        private Random random = new Random();

        public Position Position {get => this.position;}
        public void GenerateFood(int width, int height)
        {
            this.position.X = random.Next(1, width);
            this.position.Y = random.Next(2, height); 

            Draw();
        }
        private void Draw()
        {
            Console.SetCursorPosition(this.position.X, this.position.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("■");
        }
    }
}