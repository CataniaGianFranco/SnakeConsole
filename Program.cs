using System;

namespace SnakeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ■ <-- Wall
            // ☻ <-- Head
            // • <-- Tail
            // @ <-- Apple
            Console.Title = "Snake";
            Stage stage = new Stage();
            stage.ShowStage();
            Console.ReadKey();
        }
    }
}