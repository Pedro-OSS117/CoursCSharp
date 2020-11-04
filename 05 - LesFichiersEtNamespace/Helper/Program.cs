using System;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int readInt = HelperInput.ReadInt();
            // Console.WriteLine($"La valeur est : {readInt}");

            // readInt = HelperInput.ReadInt("Donnez un entier : ");
            // Console.WriteLine($"La valeur est : {readInt}")

            //int readInt = HelperInput.ReadInt(5, 14);
            //Console.WriteLine($"La valeur est {readInt} est entre 5 et 14");

            //float readFloat = HelperInput.ReadFloat();
            //Console.WriteLine($"{readFloat} est un float");
            
            double readDouble = HelperInput.ReadDouble();
            Console.WriteLine($"{readDouble} est un double");
        }
    }
}
