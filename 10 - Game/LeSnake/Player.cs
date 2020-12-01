namespace LeSnake
{
    public struct Player
    {
        public static char playerChar = 'O';

        public enum MoveDir
        {
            Up,
            Down,
            Left,
            Right,
            None
        }
        
        // Tableau des positions courantes du joueur.
        // la première position correspond à la tête
        int[] positions;
        
        public MoveDir currentDir;

        public int nbrLoot;

        public Player(int startPos)
        {
            positions = new int[1] {startPos};
            currentDir = MoveDir.Right;
            nbrLoot = 0;
            AddPositionToQueue(startPos - 1);
            AddPositionToQueue(startPos - 2);
            /*AddPositionToQueue(startPos - 3);
            AddPositionToQueue(startPos - 4);
            AddPositionToQueue(startPos - 5);*/
        }

        public int[] GetAllPosPlayer()
        {
            return positions;
        }

        public int GetPosPlayer()
        {
            return positions[0];
        }

        public bool IsContainPosition(int posToTest)
        {
            for(int i = 0; i < positions.Length; i++)
            {
                if(posToTest == positions[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void AddPosition(int newPosition)
        {
            int[] savedPos = new int[positions.Length + 1];
            savedPos[0] = newPosition;
            for(int i = 0; i < positions.Length; i++)
            {
                savedPos[i + 1] = positions[i];
            }
            positions = savedPos;
        }

        public void AddPositionToQueue(int newPosition)
        {
            int[] savedPos = new int[positions.Length + 1];
            for(int i = 0; i < positions.Length; i++)
            {
                savedPos[i] = positions[i];
            }
            savedPos[savedPos.Length - 1] = newPosition;
            positions = savedPos;
        }

        public int MovePosition(int newPosition)
        {
            // On sauvegarde la position perdu (dernière position du snake)
            int losePos = positions[positions.Length - 1];
            
            // On Decale toutes les valeurs de 1
            for(int i = positions.Length - 1; i > 0; i--)
            {
                positions[i] = positions[i - 1];
            }

            // On ajoute la nouvelle valeur au debut du tableau
            positions[0] = newPosition;

            return losePos;
        }
    }
}