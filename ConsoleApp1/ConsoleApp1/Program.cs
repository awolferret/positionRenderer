using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(5,5);
            renderer.ShowPosition(player._xPosition,player._yPosition);
        }
    }

    class Player
    {
        public int _xPosition { get; private set; }
        public int _yPosition { get; private set; }

        public Player(int xPosition, int yPosition)
        {
            _xPosition = xPosition;
            _yPosition = yPosition;
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