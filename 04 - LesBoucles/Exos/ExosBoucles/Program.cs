using System;

namespace ExosBoucles
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ DisplayAllNumber
            Console.WriteLine( "------------ DisplayAllNumber");
            DisplayAllNumber(4);
            DisplayAllNumber(7);
            DisplayAllNumber(75);
            
            // ------------ DisplayAllCharacter
            Console.WriteLine( "\n------------ DisplayAllCharacter");
            DisplayAllCharacter(3);
            DisplayAllCharacter(18);
            DisplayAllCharacter(34);

            // ------------ DisplayAllPairNumber
            Console.WriteLine( "\n------------ DisplayAllPairNumber");
            DisplayAllPairNumber(11);
            DisplayAllPairNumber(28);
            DisplayAllPairNumber(63);

            // ------------ DisplayTriangle
            Console.WriteLine( "\n------------ DisplayTriangle");
            DisplayTriangle(4);
            DisplayTriangle(8);
            DisplayTriangle(11);

            // ------------ DisplayDiamond
            Console.WriteLine( "\n------------ DisplayDiamond");
            DisplayDiamond(2);
            DisplayDiamond(4);
            DisplayDiamond(5);
            DisplayDiamond(11);
        }

        static void DisplayAllNumber(int maxNumber)
        {
            string toDisplay = "";
            for(int i = 0; i <= maxNumber; i++)
            {
                toDisplay += i.ToString();
            }
            Console.WriteLine(toDisplay);
        }

        static void DisplayAllCharacter(int maxNumber)
        {
            maxNumber += 33;
            for(int i = 33; i <= maxNumber; i++)
            {
                Console.WriteLine((char)i);
            }
        }

        static void DisplayAllPairNumber(int maxNumber)
        {
            string toDisplay = "";
            for(int i = 0; i <= maxNumber; i +=2)
            {
                toDisplay += i.ToString();
            }
            Console.WriteLine(toDisplay);
        }

        static void DisplayTriangle(int maxNumber)
        {
            for(int i = 0; i <= maxNumber; i ++)
            {
                string toDisplay = "";
                for(int j = 0; j < i; j++)
                {
                    toDisplay += '*';
                }
                Console.WriteLine(toDisplay);
            }
        }

        static void DisplayDiamond(int maxNumber)
        {
            for(int i = 1; i <= maxNumber; i ++)
            {
                DisplayLineDiamond(maxNumber, i);
            }

            for(int i = maxNumber - 1; i >= 1; i--)
            {
                DisplayLineDiamond(maxNumber, i);
            }
        }

        static void DisplayLineDiamond(int maxNumber, int line)
        {
            string toDisplay = "";
            for(int j = 0; j < maxNumber - line; j++)
            {
                toDisplay += ' ';
            }

            for(int j = maxNumber - line; j < line + maxNumber - 1; j++)
            {
                toDisplay += '*';
            }

            for(int j = maxNumber + 1; j < line + maxNumber; j++)
            {
                toDisplay += ' ';
            }
            Console.WriteLine(toDisplay);
        }
    }
}
