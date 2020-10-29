using System;

namespace SnakeConsole
{
    //Esto es para indicar una posicion. Por ejemplo indicar donde queremos dibujar dicho elemento o calcular donde se encuentra
    // ese elemento.
    public struct Position
    {
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        private int x;
        private int y;      
    }
}