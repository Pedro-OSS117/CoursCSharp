using System;
using Helper;

namespace MonthToColor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = GetTextToDisplay();
            int valueChoosen = HelperInput.ReadInt(1, 12, text);
            Mois month = (Mois)valueChoosen;
            Saison season = GetSaisonFromMois(month);
            ColorSaison color = GetColorFromSaison(season);
            Console.WriteLine($"Le mois de {month} appartient à la saison {season} et sa couleur est le {color}");
        }

        public enum Mois
        {
            Janvier = 1,
            Fevrier,
            Mars,
            Avril,
            Mai,
            Juin,
            Juillet,
            Aout,
            Septembre,
            Octobre,
            Novembre,
            Decembre
        }

        public enum Saison
        {
            Hiver,
            Printemps,
            Ete,
            Automne,
        }

        public enum ColorSaison
        {
            Blanc,
            Vert,
            Jaune,
            Orange,
        }

        static string GetTextToDisplay()
        {
            string text = "Tapez un des nombres suivant pour choisir un mois :\n";
            foreach (Mois month in Enum.GetValues(typeof(Mois)))
            {
                text += $"{(int)month}: {month} - ";
            }
            return text;
        }

        static Mois GetMoisFromInt(int monthInt)
        {
            return (Mois)monthInt;
        }

        static Saison GetSaisonFromMois(Mois month)
        {
            switch (month)
            {
                case Mois.Decembre:
                case Mois.Janvier:
                case Mois.Fevrier:
                    return Saison.Hiver;
                case Mois.Mars:
                case Mois.Avril:
                case Mois.Mai:
                    return Saison.Printemps;
                case Mois.Juin:
                case Mois.Juillet:
                case Mois.Aout:
                    return Saison.Ete;
                default:
                    return Saison.Automne;
            }
        }

        static ColorSaison GetColorFromSaison(Saison season)
        {
            return (ColorSaison)(int)season;
        }
    }
}
