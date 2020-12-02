using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Level level = new Level(10, 5);

            int startPos = level.GetCenterLevelPosition();

            Player player = new Player(startPos);

            ConsoleKey key = ConsoleKey.Spacebar;

            while(key != ConsoleKey.Q)
            {
                Console.Clear();

                // Recuperation de la position courante du player
                int currentPosition = player.GetPosition();

                // Update de la grid pour enregistrer la position du player
                level.UpdateGrid(currentPosition, player.GetSkin());

                // Affichage du niveau
                Console.WriteLine(level.ToStringLevel());
                
                // Recuperation des inputs du joueur
                key = Console.ReadKey().Key;

                // En fonction de l'input du joueur on récupère la nouvelle position du player
                int newPosition = level.GetNewPosition(currentPosition, key);

                // On applique la nouvelle position du player
                player.SetPosition(newPosition);
                
                // On supprime l'ancienne position du player
                level.CleanGrid(currentPosition);
            }
        }
    }
}
