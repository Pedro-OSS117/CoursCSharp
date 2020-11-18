using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------ Declaration
            int[] tabDeValeurs;
            float[] tabDeValeursDecimal;
            string[] tabDeChaineDecaractere;
            MonEnum[] tabDeMonEnum;
            Vector3[] tabVector3;

            // ------ Initialisation 
            // A l'intialisation on decide la taille du tableau.
            // On ne peut plus la changer.
            tabDeValeurs = new int[3];
            tabDeValeurs = new int[] { 5, 12, 4 };

            tabDeValeursDecimal = new float[]{3.4f, 4, 12.1f, 6.04f};
            tabDeChaineDecaractere = new string[]{"bobby", "lola"};

            tabDeMonEnum = new MonEnum[2];
            tabDeMonEnum[0] = MonEnum.Val2;
            tabDeMonEnum[1] = MonEnum.Val1;
            tabDeMonEnum = new MonEnum[]{ MonEnum.Val1, MonEnum.Val2};

            tabVector3 = new Vector3[]{ new Vector3(10, 12, 3), new Vector3(3.4f, 4, 12.1f) };
            tabVector3[0] = new Vector3(13, -12.0f, 1);

            // ------ Accès valeurs
            int retrieveVal = tabDeValeurs[0];
            Console.WriteLine($"{retrieveVal} - {tabDeValeurs[0]} ");

            tabDeValeurs = new int[3];
            Console.WriteLine($"{retrieveVal} - {tabDeValeurs[0]} ");

            // Comment affecter le deuxième élément du tableau avec la valeur 7
            tabDeValeurs[1] = 7;
            Console.WriteLine($"Deuxième élément du tableau {tabDeValeurs[1]} ");

            // Accès à une valeur en dehors du range des index => IndexOutOfRangeException
            // Interdit
            // tabDeValeurs[7] = 3;
            // Console.WriteLine($"Deuxième élément du tableau {tabDeValeurs[7]} ");

            // ------ Taille et Parcours
            Console.WriteLine($"La longeur du tableau {tabDeValeurs.Length} ");
            for (int i = 0; i < tabDeValeurs.Length; i++)
            {
                Console.WriteLine($"à l'index : {i}, la valeur est : {tabDeValeurs[i]} ");
            }

            // ------ Type Valeur VS Type Reference
            int var = 13;
            IncrementAndShowValue(var);
            Console.WriteLine(var);

            Vector3 v = new Vector3(10,1,4);
            IncrementAndShowVector(v);
            Console.WriteLine(v);

            int[] tabValues =new int[]{1, 3, 7};
            IncrementArrayAllValues(tabValues);
            DisplayArray(tabValues);
        }

        static void IncrementArrayAllValues(int[] tabValues)
        {
            for(int i = 0; i < tabValues.Length; i++)
            {
                tabValues[i]++;
            }
            DisplayArray(tabValues);
        }

        static void DisplayArray(int[] tabValues)
        {
            string toDisplay = "{";
            for (int i = 0; i < tabValues.Length; i++)
            {
                toDisplay += tabValues[i] + ",";
            }
            toDisplay += "}";
            Console.WriteLine(toDisplay);
        }

        static void IncrementAndShowValue(int var)
        {
            var++;
            Console.WriteLine(var);
        } 

        static void IncrementAndShowVector(Vector3 v)
        {
            v.x++;
            v.y = 2;
            v.z--;
            Console.WriteLine(v);
        } 

        public enum MonEnum
        {
            Val1,
            Val2
        }

        public struct Vector3
        {
            public float x;
            public float y;
            public float z;

            public Vector3(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public override string ToString()
            {
                return "{" + x + "," + y + "," + z + "}";
            }
        }
    }
}
