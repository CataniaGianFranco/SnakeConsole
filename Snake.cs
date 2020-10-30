using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeConsole
{
    public class Snake
    {
        private bool alive = true;
        private List<Position> partsOfTheSnake = new List<Position>();
        private Position headPosition;
        private Position bodyPosition;
        private Position tailPosition;
        private Direction direction = Direction.Down;
        private ConsoleKeyInfo keyPressed;        
        public void UpdateSnake()
        {
            CreateSnake(5,2);
            do
            {
                InputKeyBoard();
                DrawSnake();            
                Thread.Sleep(250);
            }while (alive);           
        }

        private void CreateSnake(int x, int y)
        {
            headPosition = new Position(x,y);
            bodyPosition = new Position(4,2);
            tailPosition = new Position(3,2);
            partsOfTheSnake.Add(headPosition);
            partsOfTheSnake.Add(new Position());
            partsOfTheSnake.Add(new Position());
            partsOfTheSnake.Add(new Position());
            partsOfTheSnake.Add(new Position());
            partsOfTheSnake.Add(new Position());
            partsOfTheSnake.Add(new Position());
        }
        
        private void InputKeyBoard()
        {
            if (Console.KeyAvailable)
            {
                keyPressed = Console.ReadKey(true);

                switch (keyPressed.Key)
                {
                    case ConsoleKey.W:
                        if (direction != Direction.Down)
                            direction = Direction.Up;
                        break;
                    case ConsoleKey.S:
                        if (direction != Direction.Up)
                            direction = Direction.Down;
                        break;
                    case ConsoleKey.D:
                        if (direction != Direction.Left)
                            direction = Direction.Right;
                        break;
                    case ConsoleKey.A:
                        if (direction != Direction.Right)
                            direction = Direction.Left;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private void SnakeDirection()
        {
            if (direction == Direction.Up)
                partsOfTheSnake[0].Y -=  1;
            else if (direction == Direction.Down)
                partsOfTheSnake[0].Y += 1;
            else if (direction == Direction.Left)
                partsOfTheSnake[0].X -=  1;
            else if (direction == Direction.Right)
                partsOfTheSnake[0].X +=  1;
        }

        private void DrawSnake()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Position positionTemporary1 = null;
            for (int i = 0; i < partsOfTheSnake.Count; i++)
            {
                if ( i == 0)
                {
                    positionTemporary1 = new Position(partsOfTheSnake[0].X, partsOfTheSnake[0].Y);
                    SnakeDirection();
                }
                else
                {
                    Position positionTemporary2 = new Position(positionTemporary1.X, positionTemporary1.Y);
                    positionTemporary1 = new Position(partsOfTheSnake[i].X, partsOfTheSnake[i].Y);
                    partsOfTheSnake[i] = new Position(positionTemporary2.X, positionTemporary2.Y);
                }
                
                Console.SetCursorPosition(partsOfTheSnake[i].X, partsOfTheSnake[i].Y);                
                Console.Write("♥");
            }                               
        }
    }
}