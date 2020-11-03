using System;

namespace SeasonalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string monthAsked = Console.ReadLine();
            string savedMonthAsked = monthAsked;

            monthAsked = monthAsked.ToLower();
            monthAsked = monthAsked.Replace('é', 'e');
            monthAsked = monthAsked.Replace('û', 'u');
            
            Console.WriteLine("Avant modifs : " + savedMonthAsked + " Après modifs : " + monthAsked);            

            if(monthAsked == "janvier" || monthAsked == "fevrier" || monthAsked == "decembre")
            {
                Console.WriteLine("Le mois " + savedMonthAsked + " est en Hiver!");
            }
            else if(monthAsked == "mars" || monthAsked == "avril" || monthAsked == "mai")
            {
                Console.WriteLine("Le mois " + savedMonthAsked + " est en Printemps!");
            }
            else if(monthAsked == "juin" || monthAsked == "juillet" || monthAsked == "aout")
            {
                Console.WriteLine("Le mois " + savedMonthAsked + " est en Ete!");
            }
            else if(monthAsked == "septembre" || monthAsked == "octobre" || monthAsked == "novembre")
            {
                Console.WriteLine("Le mois " + savedMonthAsked + " est en Automne!");
            }
            else
            {
                Console.WriteLine("Le mois " + savedMonthAsked + " n'est pas un mois sans deconner!");
            }

            string season = "";

            switch(monthAsked)
            {
                case "janvier":
                case "fevrier":
                case "decembre":
                    season = "Hiver";
                    break;
                case "mars":
                case "avril":
                case "mai":
                    season = "Printemps";
                    break;
                case "juin":
                case "juillet":
                case "aout":
                    season = "Ete";
                    break;
                case "septembre":
                case "octobre":
                case "novembre":
                    season = "Automne";
                    break;
                default:
                    Console.WriteLine("Le mois " + savedMonthAsked + " n'est pas un mois sans deconner!");
                    break;
                    
            }
            
            //if(!string.IsNullOrEmpty(season))
            if(season != "")
            {
                Console.WriteLine("Le mois " + savedMonthAsked + " est en " + season + "!");
            }
        }
    }
}
