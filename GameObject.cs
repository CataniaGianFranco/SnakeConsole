using System;

namespace SnakeConsole
{
    public class GameObject
    {
        private Position position;
        
        public void MyPosition(int x, int y )
        {
           this.position.X = x;
           this.position.Y = y;
        }

        public virtual char Element()
        {
            return ' ';
        }
    }
}