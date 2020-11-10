using System;

namespace FicheIdentite
{
    class Program
    {
        static void Main(string[] args)
        {
            // On change la majorité pour tout le programme
            FicheIdentite.majority = 21;
            
            // On initialise la variable avec le constructeur par defaut  
            FicheIdentite personne1 = new FicheIdentite();

            string displayPersonne = personne1.ToString();
            Console.WriteLine(displayPersonne);
            personne1.prenom = "Pepin";
            personne1.nom = "LeBref";
            personne1.SetAge(10);
            Console.WriteLine(personne1);

            // On initialise la variable avec la surcharge du constructeur  qu'on a implementer
            FicheIdentite personne2 = new FicheIdentite(20, "Bob", "Morane", "Aventurier", Jour.Mardi, 10, Mois.Juillet, 1959);
            Console.WriteLine(personne2);

            if (personne1.IsMajor())
            {
                Console.WriteLine($"{personne1.nom} tu peux voter !");
            }

            if (personne2.IsMajor())
            {
                Console.WriteLine($"{personne2.nom} tu peux voter !");
            }

            if (FicheIdentite.IsOlderThan(personne1, personne2))
            {
                Console.WriteLine($"{personne1.nom} est plus agé que {personne2.nom}");
            }
            else
            {
                Console.WriteLine($"{personne2.nom} est plus agé que {personne1.nom}");
            }
        }

        public enum Jour
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        public enum Mois
        {
            Janvier,
            Fevrier,
            Mars,
            Avril,
            Mais,
            Juin,
            Juillet,
            Aout,
            Septembre,
            Octobre,
            Novembre,
            Decembre
        }

        public struct FicheIdentite
        {
            // Les propriétés de la structure sont
            // toujours declarées avant les fonctions.
            private int age;
            public string prenom;
            public string nom;
            public string profession;
            public Jour jourDenaissance;
            public int valeurJour;
            public Mois moisDeNaissance;
            public int anneeDeNaissance;
            private int howManyBeforeMajor;

            public static int majority = 18;

            // Constructeur de la structure
            // Le construceur doit obligatoirement initialiser toutes les propriétés
            public FicheIdentite(int age, string prenom, string nom, string profession, Jour jour, int valeurJour, Mois mois, int annee)
            {
                // Initialisation de toutes les propriétés
                this.age = age;
                this.prenom = prenom;
                this.nom = nom;
                this.profession = profession;
                jourDenaissance = jour;
                this.valeurJour = valeurJour;
                moisDeNaissance = mois;
                anneeDeNaissance = annee;
                howManyBeforeMajor = 0;

                CalculateHowManyBeforeMajor();
            }

            public void SetAge(int newAge)
            {
                age = newAge;
                if(age < 0)
                {
                    age = 0;
                }

                CalculateHowManyBeforeMajor();
            }

            private void CalculateHowManyBeforeMajor()
            {
                howManyBeforeMajor = FicheIdentite.majority - age;
                if (howManyBeforeMajor < 0)
                {
                    howManyBeforeMajor = 0;
                }
            }

            public bool IsMajor()
            {
                if (howManyBeforeMajor <= 0)
                {
                    Console.WriteLine($"{prenom} est majeur.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{prenom} n'est pas majeur.");
                    return false;
                }
            }

            public int HowManyTimeNeedToBeMajor()
            {
                return howManyBeforeMajor;
            }

            public bool DidHaveAJob()
            {
                return profession != "";
            }

            // Override de la fonction ToString pour avoir un meilleur affichage
            public override string ToString()
            {
                string toDisplay = $"{nom} {prenom}";
                toDisplay += $"\nAge : {age}";
                toDisplay += $"\nProfession : {profession}";
                toDisplay += $"\nDate de naissance le {jourDenaissance} {valeurJour} {moisDeNaissance} {anneeDeNaissance}\n";
                return toDisplay;
            }

            public static bool IsOlderThan(FicheIdentite personne1, FicheIdentite personne2)
            {
                return personne1.age > personne2.age;
            }
        }
    }
}
