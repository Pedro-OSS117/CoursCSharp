using System;

namespace Grid
{
    public struct Grid
    {
        static int padding = 2;
        public int width;
        public int height;

        public PointGrid posPlayer;

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            posPlayer = new PointGrid(width / 2, height / 2);
        }

        public void SetPosPlayer(int x, int y)
        {
            posPlayer.x = ValidateXValue(x);
            posPlayer.y = ValidateXValue(y);
        }

        public void TranslatePlayer(int xToAdd, int yToAdd)
        {
            posPlayer.x += xToAdd;
            posPlayer.x = ValidateXValue(posPlayer.x);
            posPlayer.y += yToAdd;
            posPlayer.y = ValidateYValue(posPlayer.y);
        }

        private int ValidateXValue(int x)
        {
            if (x < 1)
            {
                return 1;
            }
            else if (x > width)
            {
                return width;
            }
            return x;
        }
        private int ValidateYValue(int y)
        {
            if (y < 1)
            {
                return 1;
            }
            else if (y > height)
            {
                return height;

            }
            return y;
        }

        public void DisplayGrid()
        {
            DisplayTopBottomLine();

            for (int i = 1; i <= height; i++)
            {
                string toDisplay = " ";
                for (int j = 0; j <= width + 1; j++)
                {
                    toDisplay += GetSymbole(j, i);
                }
                Console.WriteLine(toDisplay);
            }

            DisplayTopBottomLine();
        }

        private void DisplayTopBottomLine()
        {
            string toDisplay = "  ";
            for (int j = 1; j <= width; j++)
            {
                toDisplay += "-";
            }
            toDisplay += " ";
            Console.WriteLine(toDisplay);
        }

        private char GetSymbole(int x, int y)
        {
            if (x == 0 || x == width + 1)
            {
                return '|';
            }
            else if (posPlayer.x == x && posPlayer.y == y)
            {
                return '*';
            }
            return ' ';
        }
    }

    public struct PointGrid
    {
        public int x;
        public int y;

        public PointGrid(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}