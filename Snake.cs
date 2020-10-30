using System;
using System.Collections.Generic;

namespace SnakeConsole
{
    public class Snake
    {
        private List<Position> partsOfTheSnake = new List<Position>();
        private Position headPosition;
        private Direction direction = Direction.Right;
        private ConsoleKeyInfo keyPressed;
        
        public void UpdateSnake()
        {
            CreateSnake(5,2);
            DrawSnake();
            Input();
        }

        private void CreateSnake(int x, int y)
        {
            headPosition = new Position();
            headPosition.X = x;
            headPosition.Y = y;
            partsOfTheSnake.Add(headPosition);
        }
        private void DrawSnake()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(headPosition.X, headPosition.Y);
            Console.Write("♦");
        }

        private void Input()
        {
            if (Console.KeyAvailable)
            {
                keyPressed = Console.ReadKey(true);

                switch (keyPressed.Key)
                {
                    case ConsoleKey.W:
                        direction = Direction.Up;
                        break;
                    case ConsoleKey.S:
                        direction = Direction.Down;
                        break;
                    case ConsoleKey.D:
                        direction = Direction.Right;
                        break;
                    case ConsoleKey.A:
                        direction = Direction.Left;
                        break;
                }
            }
        }

        private void DirectionSnake()
        {
            if (direction == Direction.Up)
                partsOfTheSnake[0].Y -= 1;
            else if (direction == Direction.Down)
                partsOfTheSnake[0].Y += 1;
            else if (direction == Direction.Left)
                partsOfTheSnake[0].X -= 1;
            else if (direction == Direction.Right)
                partsOfTheSnake[0].X += 1;
        }
    }
}