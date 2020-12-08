using System;

namespace LeSnake
{
    public struct Grid
    {
        private static char horiWallChar = '-';
        private static char vertWallChar = '|';
        private static char emptyChar = ' ';
        private static char returnLineChar = '\n';
        private static char lootChar = 'X';

        private int width;
        private int height;
        private char[] grid;

        // string precalculée pour optimisation
        private string horiLineBorder;
        private string horiWallEndLine;

        Random rand;

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;

            grid = new char[width * height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    grid[i + j] = emptyChar;
                }
            }
            
            this.horiLineBorder = "";
            this.horiWallEndLine = emptyChar + "" + horiWallChar;
            rand = new Random();

            this.horiLineBorder = horiWallChar + ToStringLineChar(width, horiWallEndLine) + horiWallEndLine;
        }

        public void GenerateLoot()
        {
            int newLoot = rand.Next(0, grid.Length);
            grid[newLoot] = lootChar;
        }

        #region  Player
        public int GetStartPosPlayer()
        {
            return width / 2 + width * (height / 2);
        }

        public bool UpdatePlayerPos()
        {
            // manage previous pos
            int currentPosPlayer = Program.player.GetPosPlayer();
            int newPosPlayer = GetNewPosPlayer(currentPosPlayer, Program.player.currentDir);
            
            if (!ValidateNextPosPlayer(currentPosPlayer, newPosPlayer))
            {
                return false;
            }

            bool thereIsLoot = grid[newPosPlayer] == lootChar;

            int posLosed = Program.player.MovePosition(newPosPlayer);                
            if(thereIsLoot)
            {
                Program.player.AddPositionToQueue(posLosed);
                Program.player.nbrLoot++;
            }
            else
            {
                grid[posLosed] = emptyChar;
            }

            // update next pos
            int[] posPlayer = Program.player.GetAllPosPlayer();
            for (int i = 0; i < posPlayer.Length; i++)
            {
                grid[posPlayer[i]] = Player.playerChar;
            }
            return true;
        }

        public int GetNewPosPlayer(int currentPlayerPos, Player.MoveDir moveDir)
        {
            switch (moveDir)
            {
                case Player.MoveDir.Right:
                    return currentPlayerPos + 1;
                case Player.MoveDir.Left:
                    return currentPlayerPos - 1;
                case Player.MoveDir.Up:
                    return currentPlayerPos - width;
                case Player.MoveDir.Down:
                    return currentPlayerPos + width;
                default:
                    return currentPlayerPos;
            }
        }

        private bool ValidateNextPosPlayer(int currentPosPlayer, int nextPosPlayer)
        {
            // On recupère la position en largeur et en hauteur du player
            int currentHoriPos = currentPosPlayer % width;
            int currentVertPos = currentPosPlayer / width;

            // On verifie que la position est bien valide par rapport
            // aux bords du niveau.
            switch (Program.player.currentDir)
            {
                case Player.MoveDir.Right:
                    if (currentHoriPos + 1 >= width)
                    {
                        return false;
                    }
                    break;
                case Player.MoveDir.Left:
                    if (currentHoriPos - 1 < 0)
                    {
                        return false;
                    }
                    break;
                case Player.MoveDir.Up:
                    if (currentVertPos - 1 < 0)
                    {
                        return false;
                    }
                    break;
                case Player.MoveDir.Down:
                    if (currentVertPos + 1 >= height)
                    {
                        return false;
                    }
                    break;
            }

            // Test si les positions du player contiennent la nouvelle position
            if(Program.player.IsContainPosition(nextPosPlayer))
            {
                return false;
            }
            
            // si on arrive ici la position est valide.
            return true;
        }
        #endregion  Player

        #region  Display Level
        public string ToStringLevel()
        {
            string level = horiLineBorder + returnLineChar;
            for (int i = 0; i < height; i++)
            {
                level += ToStringLineGrid(i);
            }
            level += horiLineBorder + returnLineChar;
            return level;
        }

        // Fonction generique de creation de ligne avec le même caractère.
        private string ToStringLineChar(int numberLineChar, string symbol)
        {
            string line = "";
            for (int i = 0; i < numberLineChar; i++)
            {
                line += symbol;
            }
            return line;
        }

        private string ToStringLineGrid(int lineIndex)
        {
            string line = vertWallChar.ToString();
            int index = width * lineIndex;
            for (int i = index; i < index + width; i++)
            {
                line += emptyChar + grid[i].ToString();
            }
            line += emptyChar + vertWallChar.ToString() + returnLineChar;
            return line;
        }
    }
    #endregion  Display Level
}