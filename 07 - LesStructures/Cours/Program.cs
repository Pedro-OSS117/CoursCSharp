using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {            
            NomStructure.propStatic = 14;

            // On initialise une variable de type NomStructure.
            // On utilise le constructeur par defaut pour cela.
            NomStructure varStructure = new NomStructure();
            Console.WriteLine("Appel exterieur de la propriété : " + varStructure.prop1);

            varStructure.FonctionPublic();

            NomStructure varStructure2 = new NomStructure(1, 10.5f, true);

            // On accede aux propriétés public via le caractère "."
            varStructure2.prop2 = 10;
            // On ne peut pas acceder aux propriétés private à l'exterieur de la structure
            // faux => varStructure2.prop3 = false;

            // Appel fonction normale
            varStructure2.FonctionPublic();

            // Appel fonction static
            NomStructure.FonctionStaticPublic();
        }

        struct NomStructure
        {
            // Propriétés de la structure
            public int prop1;
            public float prop2;
            private bool prop3;

            public static int propStatic = 10;

            // Surcharge du Constructeur par defaut
            public NomStructure(int initProp1, float initProp2, bool prop3)
            {
                prop1 = initProp1;
                prop2 = initProp2;
                // this  est le mot clef pour acceder à l'objet courant
                this.prop3 = prop3;
            }

            // Autre Surcharge du Constructeur par defaut
            public NomStructure(int initProp1, float initProp2)
            {
                prop1 = initProp1;
                prop2 = initProp2;
                prop3 = true;
            }

            private void FonctionPrivate()
            {

            }

            public void FonctionPublic()
            {
                // On peut acceder aux fonctionx private de la structure
                // uniquement dans les fonctions de la structure
                FonctionPrivate();

                // Les fonctions non static permettent de travailler
                // sur les propriétés de l'instance appellante.
                Console.WriteLine($"{prop1}, {prop2}, {prop3} {propStatic}");
            }

            public static void FonctionStaticPublic()
            {

            }
        }
    }
}
