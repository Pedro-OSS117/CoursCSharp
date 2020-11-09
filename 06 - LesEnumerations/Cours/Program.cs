using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Les jours de la semaine
            JourSemaine jour = JourSemaine.Lundi;
            EstCeQueJeTravail(jour);
            jour = JourSemaine.Mercredi;
            EstCeQueJeTravail(jour);
            jour = JourSemaine.Vendredi;
            EstCeQueJeTravail(jour);
            jour = JourSemaine.Samedi;
            EstCeQueJeTravail(jour);
            Console.WriteLine(jour);

            // Les 5 doigts de la main
            LesDoigtsDeLaMain.DoigtMain doigt = LesDoigtsDeLaMain.DoigtMain.Pouce;
            LesDoigtsDeLaMain.EstCeQueUnSigneAvecUnSeulDoigtCestVulgaire(doigt);
            doigt = LesDoigtsDeLaMain.DoigtMain.Majeur;
            LesDoigtsDeLaMain.EstCeQueUnSigneAvecUnSeulDoigtCestVulgaire(doigt);
        }

        enum JourSemaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void EstCeQueJeTravail(JourSemaine jour)
        {
            // On remplace le if et le esle par un switch,
            // pratique sur les enumerations.
            switch (jour)
            {
                case JourSemaine.Lundi:
                case JourSemaine.Mardi:
                case JourSemaine.Mercredi:
                case JourSemaine.Jeudi:
                case JourSemaine.Vendredi:
                    Console.WriteLine($"OUI JE TRAVAIL LE {jour.ToString().ToUpper()} :'( !");
                    break;
                default:
                    Console.WriteLine($"NON JE TRAVAIL PAS LE {jour.ToString().ToUpper()} :) !");
                    break;
            }

            
            /*if(jour == JourSemaine.Lundi || jour == JourSemaine.Mardi)
            {
                Console.WriteLine("OUI JE TRAVAIL :'( !");
            }
            else
            {
                Console.WriteLine("NON JE TRAVAIL PAS :) !");
            }*/
        }
    }
}
