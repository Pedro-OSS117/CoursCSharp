using System;

namespace ExosCours
{


    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = Operation.Addition;
            /*Console.WriteLine($"Cast operation en int {(int)operation} pour {operation}");
            operation++;
            Console.WriteLine($"Cast operation en int {(int)operation} pour {operation}");
            operation = (Operation)5;
            Console.WriteLine($"Cast operation en int {(int)operation} pour {operation}");*/


            int operand1 = 10;
            int operand2 = 5;
            int resultat = Calculate(operation, operand1, operand2);
            Console.WriteLine($"LE RESULTAT EST {resultat} pour l'{operation} entre les valeurs : {operand1} et {operand2}");

            operation = Operation.Division;
            operand1 = 11;
            operand2 = 2;
            resultat = Calculate(operation, operand1, operand2);
            Console.WriteLine($"LE RESULTAT EST {resultat} pour l'{operation} entre les valeurs : {operand1} et {operand2}");

            // Exemple d'utilisation de l'enum ConsoleKey
            ConsoleKeyInfo info = Console.ReadKey();

            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    // Do Something
                    break;
                default:
                    // Do Nothing, Reask
                    break;
            }
        }

        enum Operation
        {
            Addition,
            Soustraction,
            Multiplication,
            Division,
            Modulo
        }

        static int Calculate(Operation operation, int valx, int valy)
        {
            switch (operation)
            {
                case Operation.Addition:
                    return valx + valy;

                case Operation.Soustraction:
                    return valx - valy;

                case Operation.Multiplication:
                    return valx * valy;

                case Operation.Division:
                    return CalculateDivision(valx, valy);

                default:
                    return valx % valy;
            }
        }

        static int CalculateDivision(int valx, int valy)
        {
            if (valy == 0)
            {
                Console.WriteLine("Division par zero impossible !");
                return valx;
            }
            return valx / valy;
        }
    }
}
