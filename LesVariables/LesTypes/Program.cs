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
        }
    }
}
