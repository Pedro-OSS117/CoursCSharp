using System;

namespace LeCours
{
    class Program
    {
        static void Main(string[] args)
        {
            bool firstBool1 = true;
            bool firstBool2 = false;
            
            Console.WriteLine("firstBool1 : " + firstBool1);
            Console.WriteLine("firstBool2 : " + firstBool2);

            if(firstBool1)
            {
                Console.WriteLine("On execute ces instructions si firstBool1 est vrai (true) !");
            }
            
            if(firstBool2)
            {
                Console.WriteLine("On execute ces instructions si firstBool2 est vrai (true) !");
            }
            else
            {
                Console.WriteLine("On execute ces instructions si firstBool2 est faux (false) !");
            }

            firstBool2 = firstBool1;            
            if(firstBool2)
            {
                Console.WriteLine("On execute ces instructions si firstBool2 est vrai (true) !");
            }
            else
            {
                Console.WriteLine("On execute ces instructions si firstBool2 est faux (false) !");
            }

            // Instructions et Operateurs Conditionnels
            int a = 1;
            int b = 1;
            int c = 3;

            bool compareTwoVariable = (a == b);
            Console.WriteLine("compareTwoVariable, operation conditionnelle (a == b), result :" + compareTwoVariable );
            
            compareTwoVariable = a != b;
            Console.WriteLine("compareTwoVariable, operation conditionnelle (a != b), result :" + compareTwoVariable );

            bool testBoolImpossible = (a + b) == 2;

            string name1 = "Bob";
            string name2 = "Alice";
            bool isTheSameName = name1 == name2;
            
            // Utilisation des instructions conditionnelles dans les blocs conditionnels
            if(a == b)
            {
                Console.WriteLine("Les variables a et b sont égales !");
            }
            else
            {
                Console.WriteLine("Les variables a et b ne sont pas égales ! 2 ");
            }

            //if(!compareTwoVariable)
            if(!(a != b))
            {
                Console.WriteLine("Les variables a et b sont égales !");
            }
            else
            {
                Console.WriteLine("Les variables a et b ne sont pas égales ! 2 ");
            }

            if(a > c)
            {
                Console.WriteLine("Les variables a et b sont égales !");
            }
            else
            {
                Console.WriteLine("Les variables a et b ne sont pas égales ! 2 ");
            }

            a = 3;
            b = 27;

            if(a > b)
            {
                Console.WriteLine("a superieur à b !");
            }
            else if(a < b)
            {
                Console.WriteLine("a inferieur à b !");
            }
            else
            {
                Console.WriteLine("Les variables a et b sont égales !");
            }

            if(a < b || a > c)
            {

            }
            else if (a < b && a > c )
            {

            }

            // Programme Exo
            int life = 27;

            if(life <= 0)
            {
                Console.WriteLine("NOIR");
            }
            else if (life > 0 && life <= 20)
            {
                Console.WriteLine("ROUGE");
            }
        }
    }
}
