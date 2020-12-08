using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Level level = new Level(20, 10);

            int startPos = level.GetCenterLevelPosition();

            Player player = new Player(startPos);

            ConsoleKey key = ConsoleKey.Spacebar;

            bool isAlive = true;

            while (key != ConsoleKey.Q && isAlive)
            {
                Thread.Sleep(233);

                Console.Clear();

                // Recuperation de la position courante du player
                int currentPosition = player.GetPosition();

                // Update de la grid pour enregistrer la position du player
                level.UpdateGrid(currentPosition, player.GetSkin());

                // Affichage du niveau
                Console.WriteLine(level.ToStringLevel());

                if (Console.KeyAvailable)
                {
                    // Recuperation des inputs du joueur
                    key = Console.ReadKey().Key;

                    player.SetDirection(key);
                }
                else
                {
                    key = ConsoleKey.Spacebar;
                }

                isAlive = level.ValidateNewPosition(currentPosition, player.GetDirection());

                if (isAlive)
                {
                    // En fonction de l'input du joueur on récupère la nouvelle position du player
                    int newPosition = level.GetNewPosition(currentPosition, player.GetDirection());

                    // On applique la nouvelle position du player
                    player.SetPosition(newPosition);

                    // On supprime l'ancienne position du player
                    level.CleanGrid(currentPosition);
                }
            }

            Console.WriteLine("YOU LOOOSSEE!!!");
        }
    }
}
