using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le cours sur les boucles !");

            Console.WriteLine("Boucle For !");
            int i = 0;
            for(i = 0; i < 2; i++)
            {
                // Corps de la boucle 
                Console.WriteLine(i);
            }
            
            Console.WriteLine(i);
        
            // I -Premier tour de boucle :

            // Declaration et Initialisation de i à 0 .

            // On teste si la condition (l'instruction conditionnelle) 
            // pour continuer la boucle est egale à true.
            // i est egal à 0 donc i est bien strictement inferieur à 2 => true

            // On execute le corps.
            // Ici le programme affiche 0.

            // On execute la troisième instruction.
            // ici i++; donc la variable i est egal à 1

            // II - Deuxieme tour de boucle
            // On teste si la condition i < 2 est vrai => true
            // On execute le corps.
            // Ici le programme affiche 1.
            // On execute la troisième instruction => i est egal à 2

            // III - Troisieme tour de boucle
            // On teste si la condition i < 2 est vrai => false
            // Donc on sort de la boucle.

            // Exemple de boucle infinie
            /*for(int b = 5; b > 2; b++)
            {
                Console.WriteLine(b);
            }

            for(int j = 0; j < 2 || j >= 2; j++)
            {
                Console.WriteLine(j);
            }

            for(;;)
            {
                // Corps de la boucle infinie
            }*/

            Console.WriteLine("Boucle While !");
            int index = 0;
            while(index < 2)
            {
                Console.WriteLine(index);
                index += 1;
            }

            Console.WriteLine("Exo 1");
            index = 1;
            DisplayAllNumbers(index);
            DisplayAllNumbers(25);
            DisplayAllNumbers(12);

            Console.WriteLine("Exo 2");
            int numberToShoBy3 = 250;
            DisplayBy3(3);
            DisplayBy3(7);
            DisplayBy3(23);
            DisplayBy3(numberToShoBy3);
            numberToShoBy3 = 76;
            DisplayBy3(numberToShoBy3);

            DisplayBy3Bis(7);

            Console.WriteLine("Exo 3");
            IsPairOrImpair(10);
            IsPairOrImpair(52);

        }

        static void DisplayAllNumbers(int number)
        {
            for (int index = 0; index <= number; index++)
            {
                Console.WriteLine(index);
            }
        }

        static void DisplayBy3(int number)
        {
            for (int index = 0; index <= number; index += 3)
            {
                Console.WriteLine(index);
            }
        }

        // même fonction que DisplayBy3 mais moins optimisée
        // Si on appel la fonction avec 7 en parametre.
        // Il y a 3 tours de boucle pour DisplayBy3 et 7 tours de boucle pour DisplayBy3Bis 
        static void DisplayBy3Bis(int number)
        {
            for (int index = 0; index <= number; index++)
            {
                if(index % 3 == 0)
                {
                    Console.WriteLine(index);
                }
            }
        }
        
        static void IsPairOrImpair(int pair)
        {
            for(int index = 1; index <= pair; index++)
            {
                //if(index % 2 == 0)
                if(IsPair(index))
                {
                    Console.WriteLine(index + " est un nombre pair !");
                }
                else
                {
                    Console.WriteLine(index + " est un nombre impair !");
                }
            }

        }

        static bool IsPair(int number)
        {
            return number % 2 == 0;
        }
    }
}
 