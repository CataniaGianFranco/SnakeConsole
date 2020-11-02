using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeConsole
{
    public class Snake
    {
        private bool alive = true;
        private List<Position> partsOfTheSnake = new List<Position>();
        private Direction direction = Direction.Right;
        private ConsoleKeyInfo keyPressed;
        private Position position;

        public Position Position{get => this.position;}
        public Snake(int x, int y)
        {
            position = new Position(x,y);
            partsOfTheSnake.Add(position);
        }        
        public void UpdateSnake()
        {                
                InputKeyBoard();
                DrawSnake();    
                Thread.Sleep(125);           
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
            Console.ForegroundColor = ConsoleColor.Green;
            Position positionAuxiliary = null;

            for (int index = 0; index < partsOfTheSnake.Count; index++)
            {
                Console.SetCursorPosition(partsOfTheSnake[index].X, partsOfTheSnake[index].Y);
                Console.Write(" ");
                if (index == 0)
                {
                    positionAuxiliary = new Position(partsOfTheSnake[0].X, partsOfTheSnake[0].Y);
                    SnakeDirection();
                }
                else
                {
                    Position positionAuxiliary2 = new Position(partsOfTheSnake[index].X, partsOfTheSnake[index].Y);
                    partsOfTheSnake[index] = new Position(positionAuxiliary.X, positionAuxiliary.Y);
                    positionAuxiliary = new Position(positionAuxiliary2.X, positionAuxiliary2.Y);
                }
                Console.SetCursorPosition(partsOfTheSnake[index].X, partsOfTheSnake[index].Y);
                Console.Write("♦");                
            }              
        }
    }
}