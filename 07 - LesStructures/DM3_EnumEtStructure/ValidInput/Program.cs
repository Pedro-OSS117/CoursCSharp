using System;

namespace ValidInput
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            do
            {
                Console.WriteLine("\nAppuyez sur une des touches suivantes : Flèche de droite, de gauche, du haut ou du bas.");
                key = Console.ReadKey().Key;
            }
            while(!IsValidInputArrow(key));

            Console.WriteLine("Bravo vous savez appuyer sur les touches autorisées :)!");
        }

        static bool IsValidInputArrow(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.RightArrow:
                case ConsoleKey.LeftArrow:
                    return true;
            }
            return false;
        }
    }
}

