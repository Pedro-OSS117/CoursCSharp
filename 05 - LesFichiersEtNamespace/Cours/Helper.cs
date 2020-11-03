using System;

namespace Helper
{   
    public class HelperInput
    {
        public static int ReadIntInput(string displayContent = "Enter a integer : ")
        {
            int readInput = 0;
            bool notFinded = true;
            
            // 
            while(notFinded)
            {
                Console.Write(displayContent);
                string entry = Console.ReadLine();
                notFinded = false;

                // Un try catch permet de gérer une utilisation de fonction qui peut créer une Exception.
                // Ici si l'input dans ReadLine() n'est pas un int, par exemple si l'input
                // est "coucou" alors la fonction int.Parse(entry) créera une exception.
                // Le try permet d'empecher l'erreur du programme
                // Le catch permet d'executer des instructions spécifiques en cas d'exception 
		        // (on "catch" (attrape) l'exception pour la traiter).
                try
                {
                    readInput = int.Parse(entry);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{entry} is not valid for a integer. " + e.GetType());
                    notFinded = true;
                }
            }

            return readInput;
        }

        public static float ReadFloatInput(string displayContent = "Enter a float number : ")
        {
            float readInput = 0;
            bool notFinded = true;
            
            // 
            while(notFinded)
            {
                Console.Write(displayContent);
                string entry = Console.ReadLine();
                notFinded = false;

                try
                {
                    readInput = float.Parse(entry);
                }
                catch(Exception e)
                {
                    e.ToString();
                    IsNotGoodType(entry, typeof(float).ToString());
                    notFinded = true;
                }
            }

            return readInput;
        }
        public static double ReadDoubleInput(string displayContent = "Enter a double number : ")
        {
            double readInput = 0;
            bool notFinded = true;
            
            // 
            while(notFinded)
            {
                Console.Write(displayContent);
                string entry = Console.ReadLine();

                if(double.TryParse(entry, out readInput))
                {
                    notFinded = false;
                }
                else
                {
                    IsNotGoodType(entry, typeof(double).ToString());
                }
            }

            return readInput;
        }

        public static char ReadChar(string displayContent = "Enter a character : ")
        {
            char readInput = ' ';
            string entry = "";
            do
            {
                Console.Write(displayContent);
                entry = Console.ReadLine();
            }
            while(char.TryParse(entry, out readInput));

            return readInput;
        }
        private static void IsNotGoodType(string entry, string type)
        {
            Console.WriteLine($"{entry} is not valid for a {type}.");
        }
    }
}

// Namespace different
namespace Bob
{
    // Nom classe identique
    public class HelperInput
    {
        // Classe interne
        private class InClass
        {

        }
    }
}