using System;

namespace LesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = a + b;

            // Declaration
            char testCaracter = 'a';
            Console.WriteLine("testcaracter : " + testCaracter);
            // Intialisation et Assignation
            testCaracter = 'b';
            Console.WriteLine("testcaracter : " + testCaracter);
            // Assignation
            testCaracter = 'c';
            Console.WriteLine("testcaracter : " + testCaracter);

            int value = 0;
            Console.WriteLine("value : " + value);

            // Portée d'une variable
            if(a == 1 )
            {
                int value3 = 1;
                Console.WriteLine("value3 : " + value3);
            }
            // Portée non valide
            // Console.WriteLine("value3 : " + value3);


            // Cast et Transtypage
            int value1 = 10;
            // Cast (Conversion) implicite
            float value1Float = value1 + 1.75f;
            Console.WriteLine("value1 : " + value1 + " value1Float : " + value1Float);

            // Cast (Conversion) explicite
            value1 = (int)value1Float;
            Console.WriteLine("value1 : " + value1 + " value1Float : " + value1Float);

            int valueToByte = 355;
            byte byteValue = (byte)valueToByte;
            Console.WriteLine("valueToByte : " + valueToByte + " byteValue : " + byteValue);
            
            int valueChar = 'v';
            Console.WriteLine("valueChar : " + valueChar);

            // Les operateurs numeriques : +, -, /, *, %
            int testOperateur1Int = 10; 
            int testOperateur2Int = 15; 
            float testOperateur2Float = 15.6f; 
            double testOperateur2Double = 15.6;

            int resultOperation = testOperateur1Int + testOperateur2Int;  
            resultOperation = testOperateur1Int + (int)testOperateur2Float+ (int)testOperateur2Float;  
            Console.WriteLine("resultOperation : " + resultOperation);
            resultOperation = (int)(testOperateur1Int + testOperateur2Float+ testOperateur2Float);  
            Console.WriteLine("resultOperation : " + resultOperation);


            int resulatOperationDiv = testOperateur1Int / testOperateur2Int;
            Console.WriteLine("resulatOperationDiv : " + resulatOperationDiv);

            resulatOperationDiv = (int)((testOperateur2Float + testOperateur1Int) / testOperateur2Int);

            // Exemple de decoupage d'instruction => les 5 lignes en dessous representent
            // l'instruction au dessus mais découpée.
            float tmp = testOperateur2Float;
            tmp = tmp + testOperateur1Int;
            tmp = tmp / testOperateur2Int;
            int tmpInt = (int)tmp;
            resulatOperationDiv = tmpInt;
            
            tmp = testOperateur2Float;
            tmp += testOperateur1Int;
            tmp /= testOperateur2Int;
            tmpInt = (int)tmp;
            resulatOperationDiv = tmpInt;

            Console.WriteLine("resulatOperationDiv : " + resulatOperationDiv);

            resulatOperationDiv = (int)testOperateur2Float / testOperateur1Int;
            Console.WriteLine("resulatOperationDiv : " + resulatOperationDiv);
            resulatOperationDiv = (int)(testOperateur2Float / testOperateur1Int);
            Console.WriteLine("resulatOperationDiv : " + resulatOperationDiv);

            float resulatOperationDivFloat = testOperateur1Int / testOperateur2Int;
            Console.WriteLine("resulatOperationDivFloat : " + resulatOperationDivFloat);

            int time = 450;
            int minutes = time / 60;
            //int secondes = time - minutes * 60;
            int secondes = time % 60;
            Console.WriteLine("time : " + minutes + " : " + secondes);

            string line = "Je declare et initialise ma string comme ça !";
            string line2 = "J'ai concatené cette partie là.";

            // Concatenation
            // \n dans le contenu dans la string permet de faire un retour à la ligne 
            Console.WriteLine(line + line2);
            line += line2;
            Console.WriteLine(line + line2);
            line = line2;
            Console.WriteLine(line + line2);
        }
    }
}
