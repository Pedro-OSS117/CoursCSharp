using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Quel est votre age ?");
            string message = Console.ReadLine();
            int age = int.Parse(message);
            DisplayAge(age);

            // Ici la variable age est differente de la variable ageTested.
            // Donc la modification de la variable ageTested dans la fonction
            // n'affecte pas la variable age.
            //Console.WriteLine("Votre age est de : " + age);

            Console.WriteLine("Quel est votre nom ?");
            string name = Console.ReadLine();
            DisplayAge(age, name);
            
            GetYearBitrh(age);
            GetYearBitrh(3000);*/

            int age = ReadAndDisplayAge();

            GetYearBitrh(age);
            GetYearBitrh(3000);

            byte ageB = (byte)age;
            float ageF = age;
            GetYearBitrh(ageB);
            
            GetYearBitrh((int)ageF);
        }

        static int ReadAndDisplayAge()
        {
            Console.WriteLine("Quel est votre age ?");
            string message = Console.ReadLine();
            int age = int.Parse(message);
            DisplayAge(age);
            return age;
        }

        static void DisplayAge(int ageTested)
        {
            // Ici on modifie l'age passé en parametre
            Console.WriteLine("Votre age est de : " + ageTested);
        }
        
        static void DisplayAge(int ageTested, string name)
        {
            Console.WriteLine(name + " votre age est de : " + ageTested);
        }

        static int GetYearBitrh(int age)
        {
            int year = 2020 - age;
            if(year < 0)
            {
                Console.WriteLine("Vous aurez donc " + -year +" charettes de bouses !");
            }
            else
            {
                Console.WriteLine("Vous aurez donc " + year +" pièces d'or !");
            }
            float yearF = year;
            byte yearB = (byte)year;
            return yearB;
        }

        // Fonction de la classe Program
        static void MaFonction()
        {
            Console.WriteLine("Je suis dans ma fonction");
        }

        // Fonction avec même identifiant mais signature differente
        static int MaFonction(int firstParameter)
        {
            Console.WriteLine("Je suis dans ma fonction");
            return 0;
        }          
        
        static void Replace(char oldChar, char newChar)
        {
        }
        
        static void Replace(string oldChar, string newChar)
        {
        }
        // Methode de la classe Program
        void MaMethod()
        {

        }
    }
}
