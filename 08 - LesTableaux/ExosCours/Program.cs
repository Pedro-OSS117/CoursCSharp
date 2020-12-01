using System;

namespace ExosCours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randTab = CreateRandomIntTab(10);
            DisplayArray(randTab);
            SortTabIncrease(randTab);
            DisplayArray(randTab);

            Console.WriteLine("=========== INSERT ==========");
            int[] randTab2 = CreateRandomIntTab(5);
            DisplayArray(randTab);
            DisplayArray(randTab2);
            int[] insertTab = InsertTab(randTab, randTab2, 2);
            DisplayArray(insertTab);
        }

        static int[] InsertTab(int[] tab1, int[] tab2, int indexToAdd)
        {
            int[] newTab = new int[tab1.Length + tab2.Length];
            if (indexToAdd < tab1.Length)
            {
                int indexNew = 0;
                for(; indexNew < indexToAdd; indexNew++)
                {
                    newTab[indexNew] = tab1[indexNew];
                }
                for(int i = 0; i < tab2.Length; i++)
                {
                    newTab[indexNew] = tab2[i];
                    indexNew++;
                }
                for(int i = indexToAdd; i < tab1.Length; i++)
                {
                    newTab[indexNew] = tab1[i];
                    indexNew++;
                }
            }
            else
            {
                Console.WriteLine(" Error index ");
            }
            return newTab;
        }

        static int[] CreateRandomIntTab(int length)
        {
            if (length < 2)
            {
                length = 2;
            }
            Random rand = new Random();
            int[] newRandomTab = new int[length];
            for (int i = 0; i < length; i++)
            {
                newRandomTab[i] = rand.Next(-100, 100);
            }
            return newRandomTab;
        }

        static void DisplayArray(int[] tabValues)
        {
            string toDisplay = "{";
            for (int i = 0; i < tabValues.Length - 1; i++)
            {
                toDisplay += tabValues[i] + ",";
            }
            toDisplay += tabValues[tabValues.Length - 1] + "}";
            Console.WriteLine(toDisplay);
        }

        static void SortTabIncrease(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int saved = values[j + 1];
                        values[j + 1] = values[j];
                        values[j] = saved;
                    }
                }
            }
        }

        static void SortTabDecrease(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length - 1; j++)
                {
                    if (values[j] < values[j + 1])
                    {
                        int saved = values[j + 1];
                        values[j + 1] = values[j];
                        values[j] = saved;
                    }
                }
            }
        }

        static void SortInPlaceTab(int[] values)
        {

        }
    }
}
