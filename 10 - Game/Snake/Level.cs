using System;

namespace Snake
{
    public struct Level
    {
        private static char lineReturnChar = '\n';
        private static char emptyChar = ' ';

        private char skinWallHori;
        private char skinWallVert;

        private int width;
        private int height;
        private char[] grid;

        public Level(int width, int height)
        {
            this.width = width;
            this.height = height;
            grid = new char[width * height];

            skinWallHori = '-';
            skinWallVert = '|';

            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = emptyChar;
            }

            //InitTabRandom();
        }

        public int GetCenterLevelPosition()
        {
            int i = height / 2;
            int j = width / 2;
            return CalculIndexFromPos(i, j);
        }

        private int CalculIndexFromPos(int linePos, int rowPos)
        {
            return rowPos + linePos * width;
        }

        private int CalculPosHorizontalFromIndex(int index)        
        {
            return index % width;
        }

        private void InitTabRandom()
        {
            Random rand = new Random();
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = (char)rand.Next(33, 150);
            }
        }

        public string ToStringLevel()
        {
            string gridContent = "";

            // Affichage Wall Top
            gridContent += CreateLineWithChar(width + 2, skinWallHori);

            // Affichage Level
            for (int i = 0; i < height; i++)
            {
                gridContent += lineReturnChar.ToString() + skinWallVert;
                for (int j = 0; j < width; j++)
                {
                    int index = CalculIndexFromPos(i, j);
                    if (index < grid.Length)
                    {
                        gridContent += grid[index];
                    }
                    else
                    {
                        Console.WriteLine("Error access : " + index + ", length : " + grid.Length);
                    }
                }
                gridContent += skinWallVert;
            }

            // Affichage Wall Bottom
            gridContent += lineReturnChar + CreateLineWithChar(width + 2, skinWallHori);
            return gridContent;
        }

        private string CreateLineWithChar(int numberChar, char charToDisplay)
        {
            string line = "";
            for (int i = 0; i < numberChar; i++)
            {
                line += charToDisplay;
            }
            return line;
        }

        public void UpdateGrid(int indexPos, char charReplace)
        {
            if (indexPos < grid.Length)
            {
                grid[indexPos] = charReplace;
            }
        }

        public void CleanGrid(int indexPos)
        {
            if (indexPos < grid.Length)
            {
                grid[indexPos] = emptyChar;
            }
        }

        public bool ValidateNewPosition(int currentPos,  Player.Direction dir)
        {
            int posHoriCurrent = CalculPosHorizontalFromIndex(currentPos);
            int newPosition = currentPos;

            switch (dir)
            {
                case Player.Direction.Up:
                    newPosition -= width;
                    break;
                case Player.Direction.Bottom:
                    newPosition += width;
                    break;
                case Player.Direction.Left:
                    if(posHoriCurrent - 1 < 0)
                    {
                        return false;
                    }
                    newPosition -= 1;
                    break;
                case Player.Direction.Right:
                    if(posHoriCurrent + 1 >= width)
                    {
                        return false;
                    }
                    newPosition += 1;
                    break;
            }

            if (newPosition < 0)
            {
                return false;
            }

            if (newPosition >= grid.Length)
            {
                return false;
            }
            return true;
        }

        public int GetNewPosition(int currentPos,  Player.Direction dir)
        {
            int newPosition = currentPos;


            switch (dir)
            {
                case Player.Direction.Up:
                    newPosition -= width;
                    break;
                case Player.Direction.Bottom:
                    newPosition += width;
                    break;
                case Player.Direction.Left:
                    newPosition -= 1;
                    break;
                case Player.Direction.Right:
                    newPosition += 1;
                    break;
            }

            if (newPosition < 0)
            {
                newPosition = currentPos;
            }

            if (newPosition >= grid.Length)
            {
                newPosition = currentPos;
            }
            return newPosition;
        }
    }
}