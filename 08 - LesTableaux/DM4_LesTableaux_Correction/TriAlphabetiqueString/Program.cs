using System;

namespace TriAlphabetiqueString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tabStringTosSort = new string[]{"roger","bobby","alphonse","rémi", "zoé", "areta","altair", "zelda", "Bob"};
            //string[] tabStringTosSort = new string[] { "bobby", "Bob" };
            DisplayCharArray(tabStringTosSort);
            SortArrayCharIncrease(tabStringTosSort);
            DisplayCharArray(tabStringTosSort);

        }

        public static void DisplayCharArray(string[] arrayToDisplay)
        {
            Console.WriteLine(ToStringCharArray(arrayToDisplay));
        }

        public static string ToStringCharArray(string[] arrayToDisplay)
        {
            string toDisplay = "{";

            for (int i = 0; i < arrayToDisplay.Length - 1; i++)
            {
                toDisplay += arrayToDisplay[i] + ", ";
            }

            toDisplay += arrayToDisplay[arrayToDisplay.Length - 1] + "}";
            return toDisplay;
        }

        public static void SortArrayCharIncrease(string[] tabToSort)
        {
            for (int i = 0; i < tabToSort.Length; i++)
            {
                for (int j = 0; j < tabToSort.Length - 1; j++)
                {
                    string toTest1 = tabToSort[j].ToLower();
                    string toTest2 = tabToSort[j + 1].ToLower();
                    if (IsWordInfToAnotherWord(toTest1, toTest2, 0))
                    {
                        string tmp = tabToSort[j + 1];
                        tabToSort[j + 1] = tabToSort[j];
                        tabToSort[j] = tmp;
                    }
                }
            }
        }

        // Fonction recursive pour parser deux mots qui ont un début commun
        private static bool IsWordInfToAnotherWord(string word1, string word2, int index)
        {
            // Si le premier mot est plus cours alors qu'ils ont le même début
            if (!(index < word1.Length))
            {
                // Et si le deuxième mot est plus long
                if (word2.Length >= index)
                {
                    // alors il ne faut pas changer de place
                    return false;
                }
            }
            // Si le deuxième mot est plus cours alors qu'ils ont le même début
            else if (!(index < word2.Length))
            {
                // Et si le premier mot est plus long
                if (word1.Length >= index)
                {
                    // alors il faut changer de place
                    return true;
                }
            }
            // Si la lettre à l'index 'index' est la même on rapelle
            // la fonction avec l'index suivant
            else if (word1[index] == word2[index])
            {
                // Ici il y a appel récursif car on rappelle la même fonction
                // mais avec des paramètres différents pour avancer dans la récursion.
                // Lors d'appel récursif il faut bien faire attention d'avoir bien tjrs
                // un moment où on va sortir de la fonction.
                return IsWordInfToAnotherWord(word1, word2, index + 1);
            }
            // Sinon on test de manière classique si le caractère est inferieur ou non
            else if (word1[index] > word2[index])
            {
                return true;
            }
            return false;
        }
    }
}
