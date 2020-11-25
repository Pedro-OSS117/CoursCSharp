using System;

namespace ExoCoursSuite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exo 6 
            Console.WriteLine("============== Exo 6 Prébis ================");
            int[] tabValeur = new int[] { 1, 7, 12, 20, 4 };
            ExosTableaux.DisplayIntArray(tabValeur);

            int[] tabAdd = ExosTableaux.InsertValueInArray(tabValeur, 9, 3);
            ExosTableaux.DisplayIntArray(tabAdd);

            tabAdd = ExosTableaux.InsertValueInArray(tabValeur, 45, 5);
            ExosTableaux.DisplayIntArray(tabAdd);

            Console.WriteLine("============== Exo 6 ================");
            int[] tabValeur2 = new int[] { -31, 17, -5, 2 };
            ExosTableaux.DisplayIntArray(tabValeur);
            ExosTableaux.DisplayIntArray(tabValeur2);
            int[] tabInsert = ExosTableaux.InsertArrayInArrayAtIndex(tabValeur, tabValeur2, 3);
            ExosTableaux.DisplayIntArray(tabInsert);
            
            Console.WriteLine("============== Exo 7 ================");
        }
    }
}
