namespace Snake
{
    public struct Player
    {
        // L'index dans le tableau de char grid
        private int position;

        private char skinChar;

        public Player(int startPosition)
        {
            position = startPosition;
            skinChar = 'O';
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
    }
}