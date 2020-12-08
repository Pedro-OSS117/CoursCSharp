using System;

namespace TriAlphabetique
{
    class Program
    {
        static char[] alphabetTab = new char[]{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','y', 'z'};

        static void Main(string[] args)
        {
            DisplayCharArray(alphabetTab);
            char[] desordreAlphabet = TabAlphabetDesordre();
            DisplayCharArray(desordreAlphabet);
            SortArrayCharIncrease(desordreAlphabet);
            DisplayCharArray(desordreAlphabet);
        }

        static char[] TabAlphabetDesordre()
        {
            char[] copyTab = new char[alphabetTab.Length];
            for(int i = 0; i < copyTab.Length; i++)
            {
                copyTab[i] = alphabetTab[i]; 
            }

            Random rand = new Random();
            for(int i = 0; i < copyTab.Length; i++)
            {
                int randPos = rand.Next(0, copyTab.Length);
                char temp = copyTab[i];
                copyTab[i] = copyTab[randPos];
                copyTab[randPos] = temp;
            }

            return copyTab;
        }

        public static void SortArrayCharIncrease(char[] tabToSort)
        {
            for(int i = 0; i < tabToSort.Length; i++)
            {
                for(int j = 0; j < tabToSort.Length - 1; j++)
                {
                    if(tabToSort[j] > tabToSort[j+1])
                    {
                        char tmp = tabToSort[j + 1];
                        tabToSort[j + 1] = tabToSort[j];
                        tabToSort[j] = tmp;
                    }
                }
            }
        }

        public static void DisplayCharArray(char[] arrayToDisplay)
        {
            Console.WriteLine(ToStringCharArray(arrayToDisplay));
        }

        public static string ToStringCharArray(char[] arrayToDisplay)
        {
            string toDisplay = "{";

            for (int i = 0; i < arrayToDisplay.Length - 1; i++)
            {
                toDisplay += arrayToDisplay[i] + ", ";
            }

            toDisplay += arrayToDisplay[arrayToDisplay.Length - 1] + "}";
            return toDisplay;
        }
    }
}
