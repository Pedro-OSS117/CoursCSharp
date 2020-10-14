using System;

namespace CharacterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Appuyer sur une touche : ");       
            ConsoleKeyInfo consoleKeyInf = Console.ReadKey();
            char characterRead = consoleKeyInf.KeyChar;
            int valCaracter = characterRead;
            Console.WriteLine("Vous avez appuyé sur la touche : " + characterRead + " de valeur " + valCaracter);
        }
    }
}
