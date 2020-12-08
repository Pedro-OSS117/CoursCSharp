using System;
using System.Threading;

namespace LeSnake
{
    class Program
    {
        public static Grid gridLevel;
        public static Player player;
        public static int difficulty = 1;
        public static Timer timer, timerUpdate;
        public static int speed = 200;
        private static bool notGameOver = true;

        static void Main(string[] args)
        {
            bool play = true;
            while (play)
            {
                string title = "\n\n"
                + "************   ***      ***   ************   ***      ***   ************   \n"
                + "************   ****     ***   ************   ***     ***    ************   \n"
                + "*****          *****    ***   ****    ****   ***    ***     *****          \n"
                + "*****          ******   ***   ****    ****   ***   ***      *****          \n"
                + "************   ************   ************   ********       *********      \n"
                + "************   ************   ************   ********       *********      \n"
                + "        ****   ***   ******   ****    ****   ***   ***      *****          \n"
                + "        ****   ***    *****   ****    ****   ***    ***     *****          \n"
                + "************   ***     ****   ****    ****   ***     ***    ************   \n"
                + "************   ***      ***   ****    ****   ***      ***   ************   ";

                // Affichage du titre
                Console.WriteLine(title);
                Console.WriteLine("\nSTART TO PLAY : PRESS ANY KEY - QUIT : Q");
                // Instruction pour lancer le jeu
                Console.WriteLine("\n>>>> PRESS KEY >>>>  1 ==> EASY  -  2 ==> NORMAL  -  3 => HARD  -  Q => QUIT");
                ClearKey();

                // Traitement du choix du joueur
                ConsoleKey key = Console.ReadKey().Key;
                play = key != ConsoleKey.Q;
                difficulty = GetDifficulty(key);

                if (play)
                {
                    if (difficulty != -1)
                    {
                        InitGame();

                        UpdateGame();

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }
        }

        static int GetDifficulty(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    return 3;
            }
            return -1;
        }

        static void InitGame()
        {
            switch (difficulty)
            {
                case 1:
                    gridLevel = new Grid(30, 10);
                    speed = 200;
                    break;
                case 2:
                    gridLevel = new Grid(15, 10);
                    speed = 200;
                    break;
                case 3:
                    gridLevel = new Grid(15, 10);
                    speed = 150;
                    break;
            }
            player = new Player(gridLevel.GetStartPosPlayer());
            timer = new Timer(GenerateLoot, null, 0, 5000);
            timerUpdate = new Timer(UpdatePlayer, null, 0, speed);
        }

        static void UpdateGame()
        {
            bool continueGame = true;

            while (continueGame)
            {
                // Attente pour update 
                Thread.Sleep(42);

                // Clear console avant de réafficer
                try
                {
                    Console.Clear();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                
                //notGameOver = gridLevel.UpdatePlayerPos();

                // Affichage du niveau
                Console.WriteLine(gridLevel.ToStringLevel());
                if (notGameOver)
                {
                    // Ask for input
                    Console.WriteLine("Hit key please => Move : Left Arrow, Up Arrow, Down Arrow, Right Arrow ---- Quit : Q ");
                    continueGame = ProcessInput();
                }
                else
                {
                    Console.WriteLine("GAME OVER - Points : " + player.nbrLoot * 100);
                    continueGame = false;
                }
            }
        }

        static void UpdatePlayer(Object o)
        {
            // Update de la position du player
            notGameOver = gridLevel.UpdatePlayerPos();
        }

        static void GenerateLoot(Object o)
        {
            gridLevel.GenerateLoot();
            GC.Collect();
        }

        static void ClearKey()
        {
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }

        static bool ProcessInput()
        {
            if (!Console.KeyAvailable)
            {
                return true;
            }

            ConsoleKey key = ConsoleKey.Spacebar;
            try
            {
                ConsoleKeyInfo info = Console.ReadKey();
                key = info.Key;
                ClearKey();
            }
            catch (Exception e)
            {
                key = ConsoleKey.Spacebar;
                e.ToString();
            }

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    player.currentDir = Player.MoveDir.Up;
                    break;
                case ConsoleKey.DownArrow:
                    player.currentDir = Player.MoveDir.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    player.currentDir = Player.MoveDir.Left;
                    break;
                case ConsoleKey.RightArrow:
                    player.currentDir = Player.MoveDir.Right;
                    break;
                case ConsoleKey.Q:
                    return false;
            }
            return true;
        }
    }
}
