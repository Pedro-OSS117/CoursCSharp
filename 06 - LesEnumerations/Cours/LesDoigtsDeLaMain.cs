using System;

namespace Cours
{
    public class LesDoigtsDeLaMain
    {
        public enum DoigtMain
        {
            Pouce,
            Index,
            Majeur,
            Annulaire,
            Auriculaire
        }

        public static bool EstCeQueUnSigneAvecUnSeulDoigtCestVulgaire(DoigtMain doigt)
        {
            switch (doigt)
            {
                case DoigtMain.Majeur:
                    Console.WriteLine($"{doigt} PAS BIEN!");
                    return true;
                default:
                    Console.WriteLine($"{doigt} BIEN!");
                    return false;
            }

            /*if (doigt == DoigtMain.Majeur)
            {
                Console.WriteLine("PAS BIEN!");
                return true;
            }
            else
            {
                Console.WriteLine("BIEN!");
                return false;
            }*/
        }
    }
}