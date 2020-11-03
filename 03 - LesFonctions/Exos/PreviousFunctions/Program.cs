using System;

namespace PreviousFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ TVA
            Console.WriteLine( "------------ TVA");
            CalculTVA("Slipe", 10, 3);
            CalculTVA("Carte Graphique", 500, 2);
            // Changement du paramètre par defaut
            CalculTVA("Nourriture", 15, 10, 0.05f);
            
            // ------------ Character Value
            Console.WriteLine( "\n------------ Character Value");
            CharacterValue('a');
            CharacterValue('A');
            CharacterValue('v');
            CharacterValue('V');

            // ------------ Display Color
            Console.WriteLine( "\n------------ Display Color");
            DisplayColorFromValue(10);
            DisplayColorFromValue(35);
            DisplayColorFromValue(59);
            DisplayColorFromValue(86);

            // ------------ Season from Month
            Console.WriteLine( "\n------------ Season from Month");
            DisplaySeason("Bob");
            DisplaySeason("mars");
            DisplaySeason("Fevrier");
            DisplaySeason("DéCembRe");

            // ------------ Chinese Sign
            Console.WriteLine( "\n------------ Chinese Sign");
            ChineseSignFromYear(2020);
            ChineseSignFromYear(1986);
            ChineseSignFromYear(1987);
            ChineseSignFromYear(2045);
            ChineseSignFromYear(1918);
            ChineseSignFromYear(150);
        }

        // Ici j'ai mis un paramaètre avec une valeur par default : la TVA.
        // Je n'ai pas besoin de lui donner une valeur lors de l'appel de la fonction,
        // sauf si je veux changer la valeur par defaut.
        static float CalculTVA(string nameProduct, float priceProduct, int quantity, float tva = 0.20f)
        {
            float priceTTC = priceProduct * tva + priceProduct;
            float totalTTC = (priceTTC) * quantity;

            Console.WriteLine($"Pour le produit : {nameProduct}, prix de base : {priceProduct} euros, le total TTC est de {totalTTC} euros pour une quantité de {quantity}");
            return totalTTC;
        }

        static void CharacterValue(char character)
        {
            Console.WriteLine($"le caractère {character} a comme valeur numérique : {(int)character}");
        }

        static void DisplayColorFromValue(int life)
        {
            string color = "GREEN";
            if(life < 20)
            {
                color = "BLACK";
            }
            else if(life < 40)
            {
                color = "RED";
            }
            else if(life < 60)
            {
                color = "ORANGE";
            }
            else if(life < 80)
            {
                color = "YELLOW";
            }
            Console.WriteLine($"Pour une valeur de vie {life} la couleur est {color}");
        }

        static void DisplaySeason(string monthAsked)
        {
            string savedMonthAsked = monthAsked;
            monthAsked = monthAsked.ToLower();
            monthAsked = monthAsked.Replace('é', 'e');
            monthAsked = monthAsked.Replace('û', 'u');

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
                Console.WriteLine("Le mois de " + savedMonthAsked + " est en " + season + "!");
            }
        }

        static void ChineseSignFromYear(int year)
        {
            int res = 2020 - year;
            if(res < 0)
            {
                res *= -1;
            }
            res = res % 12;

            string sign = "";
            switch(res)
            {
                case 0: sign = "Rat"; break;
                case 1: sign = "Cochon"; break;
                case 2: sign = "Chien"; break;
                case 3: sign = "Coq"; break;
                case 4: sign = "Singe"; break;
                case 5: sign = "Mouton"; break;
                case 6: sign = "Cheval"; break;
                case 7: sign = "Serpent"; break;
                case 8: sign = "Dragon"; break;
                case 9: sign = "Lapin"; break;
                case 10: sign = "Tigre"; break;
                case 11: sign = "Bœuf"; break;
            }
            Console.WriteLine($"Une personne née l'année {year} est de signe chinois : {sign}");
        }
    }
}
