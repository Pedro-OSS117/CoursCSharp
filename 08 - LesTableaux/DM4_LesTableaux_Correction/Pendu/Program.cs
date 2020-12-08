using System;

namespace Pendu
{
    class Program
    {
        static string[] wordBaseEasy = new string[] { "Zelda", "Isaac", "Skyrim", "Journey" };
        static string[] wordBaseHard = new string[] { "TheLastOfUs", "", "BreathToTheWild", "OriAndTheBlindForest", "BindigOfIsaac" };

        static string originalWord;
        static string currentWord;
        static char[] currentLetterFinded;
        static int nbrCoup;

        static void Main(string[] args)
        {
            int chooseDiff = -1;
            while (chooseDiff == -1)
            {
                Console.WriteLine("Choose a difficulty => 1 : Easy  ---  2 : Hard");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.D1)
                {
                    chooseDiff = 0;
                }
                else if (key == ConsoleKey.D2)
                {
                    chooseDiff = 1;
                }
            }

            InitGame(chooseDiff);

            bool gameContinue = true;
            bool isWin = false;
            while (gameContinue && !isWin)
            {
                Console.Write("\nNumber remain hit : " + nbrCoup + ", Current state word : ");
                Console.WriteLine(currentLetterFinded);
                Console.WriteLine("Enter a new letter or a the complete word");
                string content = Console.ReadLine();
                if (content.Length == 1)
                {
                    UpdateWord(content[0]);

                    isWin = ValidateWord();
                }
                else
                {
                    if (ValidateWordProposal(content))
                    {
                        isWin = true;
                    }
                }

                nbrCoup--;
                if (nbrCoup <= 0)
                {
                    gameContinue = false;
                }
            }

            if (isWin)
            {
                Console.WriteLine("You Win ! You find the word : " + originalWord);
            }
            else
            {
                Console.WriteLine("You LOOSE !");
            }
        }

        static void InitGame(int diff)
        {
            Random rand = new Random();
            if (diff == 0)
            {
                nbrCoup = 15;
                currentWord = wordBaseEasy[rand.Next(0, wordBaseEasy.Length)];
            }
            else
            {
                nbrCoup = 12;
                currentWord = wordBaseHard[rand.Next(0, wordBaseHard.Length)];
            }

            originalWord = currentWord;
            currentWord = currentWord.ToLower();
            currentLetterFinded = new char[currentWord.Length];
            for (int i = 0; i < currentLetterFinded.Length; i++)
            {
                currentLetterFinded[i] = '*';
            }
        }

        static void UpdateWord(char newLetter)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (newLetter == currentWord[i])
                {
                    currentLetterFinded[i] = newLetter;
                }
            }
        }

        static bool ValidateWord()
        {
            string toTest = currentWord.ToLower();
            for (int i = 0; i < currentLetterFinded.Length; i++)
            {
                if (currentLetterFinded[i] != currentWord[i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidateWordProposal(string wordProposed)
        {
            string toTest = wordProposed.ToLower();

            if (toTest.Length != currentWord.Length)
            {
                return false;
            }

            for (int i = 0; i < currentWord.Length; i++)
            {
                if (toTest[i] != currentWord[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
