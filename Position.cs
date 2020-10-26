using System;

namespace SnakeConsole
{
    public struct Position
    {
        private int x;
        private int y;
        
        public int X { get => this.x; set => this.x = value;}
        
        public int Y {get => this.y; set => this.y = value;}
    }
}