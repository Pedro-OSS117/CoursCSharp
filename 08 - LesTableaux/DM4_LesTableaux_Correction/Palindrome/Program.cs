using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome("Tu l'as trop écrasé César ce Port-Salut");
            IsPalindrome("elle");
            IsPalindrome("coucou");
            IsPalindrome("Dogma I am God");
        }

        static bool IsPalindrome(string word)
        {
            string wordFormated = word.ToLower();
            wordFormated = wordFormated.Replace(" ", "");
            wordFormated = wordFormated.Replace("-", "");
            wordFormated = wordFormated.Replace("'", "");
            wordFormated = wordFormated.Replace("é", "e");
            wordFormated = wordFormated.Replace("è", "e");
            wordFormated = wordFormated.Replace("à", "a");
            wordFormated = wordFormated.Replace("ù", "u");

            char[] wordChar = wordFormated.ToCharArray();
            bool isPalindrome = true;
            for(int i = 0; i < wordChar.Length / 2; i++)
            {
                if(wordChar[i] != wordChar[wordChar.Length - (i + 1)])
                {
                    isPalindrome = false;
                    break;
                }
            }
            
            if(isPalindrome)
            {
                Console.WriteLine($"{wordFormated} est un palindrome");
            }
            else
            {
                Console.WriteLine($"{wordFormated} n'est pas un palindrome");
            }

            return isPalindrome;
        }
    }
}
