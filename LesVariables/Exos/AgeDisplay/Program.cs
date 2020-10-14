using System;

namespace AgeDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur notre programme, tapez votre nom :");
            string nomUtilisateur = Console.ReadLine();
            Console.WriteLine("Bonjour " + nomUtilisateur + "!");
            Console.WriteLine("Tapez votre age svp : ");
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);
            Console.WriteLine("Vous êtes né l'année : " + (2020 - ageInt) + " et vous avez " + ageInt + ".");
        }
    }
}
