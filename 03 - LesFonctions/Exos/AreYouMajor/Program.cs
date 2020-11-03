using System;

namespace AreYouMajor
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = -1;
            // 
            while(year == -1)
            {
                Console.WriteLine("Enter a year between 1900 et 2020 :");
                string entry = Console.ReadLine();

                // Un try catch permet de gérer une utilisation de fonction qui peut créer une Exception.
                // Ici si l'input dans ReadLine() n'est pas un int, par exemple si l'input
                // est "coucou" alors la fonction int.Parse(entry) créera une exception.
                // Le try permet d'empecher l'erreur du programme
                // Le catch permet d'executer des instructions spécifiques en cas d'exception 
		        // (on "catch" (attrape) l'exception pour la traiter).
                try
                {
                    year = int.Parse(entry);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{entry} : {e.ToString()}");
                    year = -1;
                }

                if(year == -1)
                {
                    Console.WriteLine($"{entry} is not valid for a birth year !");
                    continue;
                }
                else
                {
                    if(year > 2020 || year < 1900)
                    { 
                        Console.WriteLine($"{year} is not between 1900 and 2020 !");
                        year = -1;
                        continue;
                    }
                }
            }

            int age = CalculeAge(year);
            if(DetermineMajorite(age))
            {
                Console.WriteLine($"With an age : {age} you are Major !");
            }
            else
            {
                Console.WriteLine($"With an age : {age} you aren't Major !");
            }
        }

        static int CalculeAge(int year)
        {
            return 2020 - year;
        }

        static bool DetermineMajorite(int age, int majority = 18)
        {
            return age >= majority;
        }
    }
}
