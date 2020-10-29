using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeConsole
{
    public class Snake
    {
        private bool GameOver = false;
        private List<Position> position = new List<Position>();
        Position currentPosition;
        Direction direction = Direction.Left;
        ConsoleKeyInfo keyInfo;
        
        private void CreateSnake()
        {          
            if (position.Count != 0)
                currentPosition = position.Last<Position>();
            else
                currentPosition = GetStartPosition();

            position.Add(currentPosition);                
        }

        public void Update()
        {
            CreateSnake();
            do
            {
                KeyPressed();  
                Move();
                Thread.Sleep(350);
            }while(!GameOver);
        }

        private Position GetStartPosition()
        {
            return new Position()
            {
                X = 5, Y = 2
            };
        }
        private void KeyPressed()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        direction = Direction.Up;
                        break;
                    case ConsoleKey.S:
                        direction = Direction.Down;
                        break;
                    case ConsoleKey.A:
                        direction = Direction.Left;
                        break;
                    case ConsoleKey.D:
                        direction = Direction.Right;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }   
        }

        private void Move()
        {
            for (int i = 0; i < position.Count; i++)
            {                             
                if (direction == Direction.Up)
                    position[i] = new Position(position[i].X, position[i].Y -1);
                else if (direction == Direction.Down)
                    position[i] = new Position(position[i].X, position[i].Y + 1);
                else if (direction == Direction.Left)
                    position[i] = new Position(position[i].X - 1, position[i].Y);
                else if (direction == Direction.Right)
                    position[i] = new Position(position[i].X + 1, position[i].Y);
                    
                Console.Clear();
                Console.SetCursorPosition(position[i].X, position[i].Y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("#");                   
            }            
        }
    }
}