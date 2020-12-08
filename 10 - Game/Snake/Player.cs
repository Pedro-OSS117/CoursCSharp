using System;

namespace Snake
{
    public struct Player
    {
        public enum Direction
        {
            Right,
            Left,
            Up,
            Bottom
        }

        // L'index dans le tableau de char grid
        private int position;

        private int[] positions;

        private char skinChar;

        private Direction dirMove;

        public Player(int startPosition)
        {
            position = startPosition;
            dirMove = Direction.Right;
            skinChar = 'O';

            positions = new int[3];
        }

        public int GetPosition()
        {
            return position;
        }

        public void SetPosition(int newPosition)
        {
            position = newPosition;
        }

        public char GetSkin()
        {
            return skinChar;
        }

        public Direction GetDirection()
        {
            return dirMove;
        }

        public void SetDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    dirMove = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    dirMove = Direction.Bottom;
                    break;
                case ConsoleKey.LeftArrow:
                    dirMove = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    dirMove = Direction.Right;
                    break;
            }
        }
    }
}