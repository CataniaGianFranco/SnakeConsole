using System;

namespace SnakeConsole
{
    public class Position
    {    
        private int x, y;

        public int X 
        {
            get { return this.x;}
            set { this.x = value;}
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}