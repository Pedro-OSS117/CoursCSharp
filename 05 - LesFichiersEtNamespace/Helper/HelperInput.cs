using System;

namespace Helper
{
    public class HelperInput
    {
        public static int ReadInt(string displayContent = "Enter a integer : ")
        {
            int readInput = 0; 
            bool isInputNotValid = true;

            while(isInputNotValid)
            {
                Console.WriteLine(displayContent);
                string entry = Console.ReadLine();

                try
                {
                    readInput = int.Parse(entry);
                    isInputNotValid = false;
                }
                catch(Exception exception)
                {
                    isInputNotValid = true;
                    Console.WriteLine($"{entry} is not valid for a integer ! Error : {exception.GetType()} ");
                }
            }

            return readInput;
        }

        
        public static int ReadInt(int min, int max)
        {
            int entry = 0;
            bool isOutOfRange = true;

            while(isOutOfRange)
            {
                entry = ReadInt($"Enter a integer between {min} and {max}");

                if(entry <= max && entry >= min)
                {
                    isOutOfRange = false;
                }
                else
                {
                    isOutOfRange = true;
                    Console.WriteLine($"{entry} is not between {min} and {max}");
                }

            }
            return entry;
        }


        public static float ReadFloat(string displayContent = "Enter a float : ")
        {            
            float readFloat = 0.1f;
            bool floatIsNotValid = true;

            while(floatIsNotValid)
            {
                Console.WriteLine(displayContent);
                string entry = Console.ReadLine();

                if (!float.TryParse(entry, out readFloat))
                {
                    Console.WriteLine($"{entry} is not valid.");
                }
                else
                {
                    floatIsNotValid = false;
                }  
            }
            return readFloat;        
        }

        public static double ReadDouble(string displayContent = "Enter a double : ")        
        {
            double readDouble = 0;
            string entry = "";
            do
            {
                Console.WriteLine(displayContent);
                entry = Console.ReadLine();
            }
            while(!double.TryParse(entry, out readDouble));

            return readDouble;
        }
    }
}