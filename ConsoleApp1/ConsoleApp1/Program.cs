using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(5,5);
            renderer.ShowPosition(player.XPosition,player.YPosition);
        }
    }

    class Player
    {
        public int XPosition { get; private set; }
        public int YPosition { get; private set; }

        public Player(int xPosition, int yPosition)
        {
            XPosition = xPosition;
            YPosition = yPosition;
        }
    }
    class Renderer
    {
        public void ShowPosition(int xPosition, int yPosition, char character = '*')
        {
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(character);
        }
    }
}