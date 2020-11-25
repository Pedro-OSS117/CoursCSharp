using System;

namespace ExoCours
{
    public class TableauExos
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

        public static int TotalIntArray(int[] arrayToSum)
        {
            int result = 0;
            for (int i = 0; i < arrayToSum.Length; i++)
            {
                result += arrayToSum[i];
            }
            return result;
        }

        public static float AverageIntArray(int[] arrayToMid)
        {
            // Recupérer le total des valeurs du tableau arrayToMid
            // via la fonction TotalIntArray.
            int result = TotalIntArray(arrayToMid);

            // Diviser ce total par la longueur du tableau.
            float middle = (float)result / arrayToMid.Length;

            return middle;
        }

        public static int SearchValue(int[] arrayValue, int valueToSearch)
        {
            //parcourir le tableau, en cherchant la valeur.
            for (int i = 0; i < arrayValue.Length; i++)
            {
                if(valueToSearch == arrayValue[i])
                {
                    return i;
                }
            }
            return -1;
        }

    }
}