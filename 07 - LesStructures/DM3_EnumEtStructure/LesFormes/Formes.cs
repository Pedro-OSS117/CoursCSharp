namespace LesFormes
{
    public struct Forme
    {
        public static char defaultMainChar = '*';

        public enum TypeForme
        {
            TriangleRectangle,
            TriangleIsocele,
            Diamant,
            FauxCarre,
            VraiCarre,
            DiamantCarre
        }

        private int taille;
        private TypeForme typeForm;
        private char mainChar;
        
        public Forme(int taille, TypeForme typeForme)
        {
            this.taille = taille;
            if (taille < 1)
            {
                taille = 1;
            }

            this.typeForm = typeForme;
            mainChar = defaultMainChar;
        }

        public void SetMainChar(char newMainChar)
        {
            if(newMainChar == ' ')
            {
                mainChar = defaultMainChar;
            }
            else
            {
                mainChar = newMainChar;
            }
        }

        public override string ToString()
        {
            string toDisplay = typeForm.ToString();
            switch (typeForm)
            {
                case TypeForme.TriangleIsocele:
                    toDisplay += ToStringTriangleIsocele();
                    break;
                case TypeForme.Diamant:
                    toDisplay += ToStringDiamant();
                    break;
                case TypeForme.FauxCarre:
                    toDisplay += ToStringFauxCarre();
                    break;
                case TypeForme.VraiCarre:
                    toDisplay += ToStringVraiCarre();
                    break;
                case TypeForme.DiamantCarre:
                    toDisplay += ToStringDiamantCarre();
                    break;
                default:
                    toDisplay += ToStringTriangleRectangle();
                    break;
            }
            return toDisplay;
        }

        // Fonction generique de creation de ligne avec le même caractère.
        private string ToStringLineChar(int numberLineChar, char symbol)
        {
            string line = "";
            for (int i = 0; i < numberLineChar; i++)
            {
                line += symbol;
            }
            return line;
        }

        // TriangleRectangle
        private string ToStringTriangleRectangle()
        {
            // Première ligne
            string toDisplay = "\n" + mainChar;
            // Lignes du milieu
            for (int i = 2; i < taille; i++)
            {
                toDisplay += "\n" + mainChar + ToStringLineChar(i - 1, ' ') + mainChar;
            }
            if (taille > 1)
            {
                // Dernière ligne
                toDisplay += "\n" + ToStringLineChar(taille + 1, mainChar);
            }
            return toDisplay;
        }

        // TriangleIsocele
        private string ToStringTriangleIsocele()
        {
            string toDisplay = "";

            for (int i = 1; i < taille; i++)
            {
                toDisplay += "\n" + DisplayLineTriangleWithHole(taille, i);
            }

            // Dernière ligne
            if (taille > 1)
            {
                toDisplay += "\n" + ToStringLineChar(taille * 2 - 1, mainChar);
            }
            return toDisplay;
        }

        // Diamant
        private string ToStringDiamant()
        {
            string toDisplay = "";

            for (int i = 1; i <= taille; i++)
            {
                toDisplay += "\n" + DisplayLineTriangleWithHole(taille, i);
            }

            for (int i = taille - 1; i > 0; i--)
            {
                toDisplay += "\n" + DisplayLineTriangleWithHole(taille, i);
            }
            return toDisplay;
        }

        private string DisplayLineTriangleWithHole(int maxNumber, int line)
        {
            string toDisplay = ToStringLineChar(maxNumber - line, ' ');

            int startIndex = maxNumber - line;
            int endIndex = line + maxNumber - 1;
            for (int j = startIndex; j < endIndex; j++)
            {
                if (j == startIndex || j == endIndex - 1)
                {
                    toDisplay += mainChar;
                }
                else
                {
                    toDisplay += ' ';
                }
            }

            toDisplay += ToStringLineChar(maxNumber - line, ' ');
            return toDisplay;
        }

        // FauxCarre
        private string ToStringFauxCarre()
        {
            string toDisplay = "";
            toDisplay += "\n" + ToStringLineChar(taille + 2, mainChar);
            for (int i = 1; i <= taille; i++)
            {
                toDisplay += "\n" + mainChar + ToStringLineChar(taille, ' ') + mainChar;
            }
            toDisplay += "\n" + ToStringLineChar(taille + 2, mainChar);
            return toDisplay;
        }

        // VraiCarre
        private string ToStringVraiCarre()
        {
            string toDisplay = "";
            toDisplay += "\n" + DisplayLineVraiCarre(taille);
            for (int i = 1; i <= taille; i++)
            {
                toDisplay += "\n" + mainChar + ToStringLineChar(taille * 2 + 1, ' ') + mainChar;
            }
            toDisplay += "\n" + DisplayLineVraiCarre(taille);
            return toDisplay;
        }

        private string DisplayLineVraiCarre(int sizeLine)
        {
            string toDisplay = mainChar.ToString();
            for (int j = 1; j <= sizeLine + 1; j++)
            {
                toDisplay += " " + mainChar;
            }
            return toDisplay;
        }

        // DiamantCarre
        private string ToStringDiamantCarre()
        {
            string toDisplay = "";
            toDisplay += "\n" + ToStringLineChar(taille * 2 - 1, mainChar);

            for (int i = 2; i < taille; i++)
            {
                toDisplay += "\n" + ToStringDiamantCarreLine(taille - 1, i);
            }
            
            toDisplay += "\n" + DisplayLineTriangleWithHole(taille, taille);

            for (int i = taille - 1; i > 1; i--)
            {
                toDisplay += "\n" + ToStringDiamantCarreLine(taille - 1, i);
            }

            toDisplay += "\n" + ToStringLineChar(taille * 2 - 1, mainChar);
            return toDisplay;
        }

        private string ToStringDiamantCarreLine(int size, int indexLine)
        {
                string toModify = DisplayLineTriangleWithHole(size, indexLine);
                toModify = toModify.Remove(0, 0);
                toModify = toModify.Remove(toModify.Length - 1, 0);
                toModify = mainChar + toModify + mainChar;
                return toModify;
        }
    }
}