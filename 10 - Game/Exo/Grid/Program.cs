using System;

namespace Grid
{
    class Program
    {
        //static Grid gridGame;

        static void Main(string[] args)
        {
            //Console.Write("\nc\ncoucou");
            Update();
        }

        private static void Update()
        {
            bool continueGame = true;
            Grid gridGame = new Grid(30, 10);
            Console.Clear();
            while (continueGame)
            {
                gridGame.DisplayGrid();
                Console.WriteLine("Hit key please => Move : Left Arrow, Up Arrow, Down Arrow, Right Arrow ---- Quit : Q ");
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        gridGame.TranslatePlayer(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        gridGame.TranslatePlayer(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        gridGame.TranslatePlayer(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        gridGame.TranslatePlayer(1, 0);
                        break;
                    case ConsoleKey.Q:
                        continueGame = false;
                        break;
                }                
                Console.Clear();
            }
        }
    }
}
