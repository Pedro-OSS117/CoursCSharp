using System;

namespace ExoCoursSuite
{
    public class ExosTableaux
    {
        public static void DisplayIntArray(int[] arrayToDisplay)
        {
            Console.WriteLine(ToStringIntArray(arrayToDisplay));
        }

        public static string ToStringIntArray(int[] arrayToDisplay)
        {
            string toDisplay = "{";

            for (int i = 0; i < arrayToDisplay.Length - 1; i++)
            {
                toDisplay += arrayToDisplay[i] + ", ";
            }

            toDisplay += arrayToDisplay[arrayToDisplay.Length - 1] + "}";
            return toDisplay;
        }

        public static int[] AddValues(int[] tabValues, int val, int indice)
        {
            int[] tabAdd;
            tabAdd = new int[tabValues.Length + 1];

            for (int i = 0; i < tabValues.Length; i++)
            {
                tabAdd[i] = tabValues[i];
            }

            tabAdd[indice] = val;

            for (int i = indice + 1; i < tabAdd.Length; i++)
            {
                tabAdd[i] = tabValues[i - 1];
            }


            return tabAdd;
        }

        public static int[] InsertValueInArray(int[] tabValues, int val, int index)
        {
            int[] tabAdd = new int[tabValues.Length + 1];

            for (int i = 0; i < index; i++)
            {
                tabAdd[i] = tabValues[i];
            }

            tabAdd[index] = val;

            for (int i = index + 1; i < tabAdd.Length; i++)
            {
                tabAdd[i] = tabValues[i - 1];
            }
            return tabAdd;
        }
        
        public static int[] InsertArrayInArrayAtIndex(int[] tabValues1, int[] tabValues2, int index)
        {
            int[] tabInsert = new int[tabValues1.Length + tabValues2.Length];

            int indexGlobal = 0;
            for (indexGlobal = 0; indexGlobal < index; indexGlobal++)
            {
                tabInsert[indexGlobal] = tabValues1[indexGlobal];
            }

            for(int i = 0; i < tabValues2.Length; i++)
            {
                tabInsert[indexGlobal] = tabValues2[i];
                indexGlobal++;
            }

            for(int i = index; i < tabValues1.Length; i++)
            {
                tabInsert[indexGlobal] = tabValues1[i];
                indexGlobal++;
            }

            return tabInsert;
        }

        public static void SortArrayIncrease(int[] tabToSort)
        {
            for(int i = 0; i < tabToSort.Length; i++)
            {
                for(int j = 0; j < tabToSort.Length - 1; j++)
                {
                    if(tabToSort[j] > tabToSort[j+1])
                    {
                        int tmp = tabToSort[j + 1];
                        tabToSort[j + 1] = tabToSort[j];
                        tabToSort[j] = tmp;
                    }
                }
            }
        }
    }
}