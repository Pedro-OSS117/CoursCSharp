using System;

namespace UseReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ Calcule Moyenne
            Console.WriteLine( "------------ Calcule Moyenne");
            float moyenne = CalculeMoyenne(150, 12);
            Console.WriteLine($"La moyenne pour un total de 150 avec 12 éléments est de : {moyenne}");
            moyenne = CalculeMoyenne(3600, 60);
            Console.WriteLine($"La moyenne pour un total de 3600 avec 60 éléments est de : {moyenne}");
            
            // ------------ Calcule Rect Surface
            Console.WriteLine( "\n------------ Calcule Rect Surface");
            int surface = CalculeRectSurface(10, 5);
            Console.WriteLine($"Un rectangle de largeur 10 et de hauteur 5 a pour surface : {surface}");
            surface = CalculeRectSurface(32, 14);
            Console.WriteLine($"Un rectangle de largeur 34 et de hauteur 14 a pour surface : {surface}");

            // ------------ Calcule Percent
            Console.WriteLine( "\n------------ Calcule Percent");
            float percent = CalculePercent(63, 350);
            Console.WriteLine($"63 represente {percent}% de 350");
            percent = CalculePercent(168, 245);
            Console.WriteLine($"168 represente {percent}% de 245");
        }

        static float CalculeMoyenne(int total, int numberElement)
        {
            return (float)total / numberElement;
        }

        static int CalculeRectSurface(int largeur, int hauteur)
        {
            return largeur * hauteur;
        }

        static float CalculePercent(float value, float valueMax)
        {
            if(value > valueMax)
            {
                value = valueMax;
            }
            return value * 100 / valueMax;
        }
    }
}
