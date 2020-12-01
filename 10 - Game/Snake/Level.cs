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
            
            for(int i = 0; i < grid.Length; i++)
            {
                grid[i] = emptyChar;
            }

            //InitTabRandom();
        }

        private void InitTabRandom()
        {
            Random rand = new Random();
            for(int i = 0; i < grid.Length; i++)
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
            for(int i = 0; i < height; i++)
            {
                gridContent += lineReturnChar.ToString() + skinWallVert;
                for(int j = 0; j < width; j++)
                {
                    gridContent += grid[j + i * width];
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
            for(int i = 0; i < numberChar; i++)
            {
                line += charToDisplay;
            }
            return line;
        }
    }
}