using System;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int readInt = HelperInput.ReadInt();
            Console.WriteLine($"La valeur est : {readInt}");

            readInt = HelperInput.ReadInt("Donnez un entier : ");
            Console.WriteLine($"La valeur est : {readInt}");
        }
    }
}
