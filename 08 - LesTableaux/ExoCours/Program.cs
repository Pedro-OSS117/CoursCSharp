using System;

namespace ExoCours
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(0, 10));

            Console.WriteLine("============== Exo 1 ================");
            int[] tabExo1 = new int[] { 4, 6, 8, 2, 12 };
            TableauExos.DisplayIntArray(tabExo1);

            int[] tabExo12 = new int[1];
            TableauExos.DisplayIntArray(tabExo12);

            int[] tabExo2 = new int[3] { 5, 14, 7 };

            Console.WriteLine("============== Exo 2 ================");
            string tabDisplay = TableauExos.ToStringIntArray(tabExo2);
            int result = TableauExos.TotalIntArray(tabExo2);
            Console.WriteLine($"Le total du tableau {tabDisplay} a pour total {result}");
            Console.WriteLine($"Le total du tableau {TableauExos.ToStringIntArray(tabExo2)} a pour total {TableauExos.TotalIntArray(tabExo2)}");

            Console.WriteLine("============== Exo 2 Bis ================");
            int[] tabExo2B = new int[] { 5, 7, 9, 2, 8 };
            string tabDisplay2 = TableauExos.ToStringIntArray(tabExo2B);
            float resultMid = TableauExos.AverageIntArray(tabExo2B);
            Console.WriteLine($"La moyenne du tableau {tabDisplay2} est de {resultMid}");

            Console.WriteLine("============== Exo 3 ================");
            int[] tabExo3 = new int[] { 7, 9, 6, 4, 13, 42 };
            int index = TableauExos.SearchValue(tabExo3, 42);
            DisplayIsContain(index, tabExo3, 42);
            index = TableauExos.SearchValue(tabExo3, 1);
            DisplayIsContain(index, tabExo3, 1);


        }

        public static void DisplayIsContain(int index, int[] tab, int value)
        {
            string tabDisplay3 = TableauExos.ToStringIntArray(tab);
            if (index >= 0)
            {
                Console.WriteLine($"Le tableau {tabDisplay3} contient la valeur {value} a l'index {index}");
            }
            else
            {
                Console.WriteLine($"Le tableau {tabDisplay3} ne contient pas la valeur {value}");
            }
        }
    }
}
