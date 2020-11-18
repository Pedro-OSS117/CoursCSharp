using System;

namespace LesFormes
{
    class Program
    {
        static void Main(string[] args)
        {
            Forme triangleRectangle = new Forme(7, Forme.TypeForme.TriangleRectangle);
            Console.WriteLine(triangleRectangle);

            Forme.defaultMainChar = 'v';
            
            Forme triangleIsocele = new Forme(8, Forme.TypeForme.TriangleIsocele);
            triangleIsocele.SetMainChar('0');
            Console.WriteLine(triangleIsocele);

            
            Forme diamant = new Forme(7, Forme.TypeForme.Diamant);
            Console.WriteLine(diamant);

            
            Forme fauxCarre = new Forme(7, Forme.TypeForme.FauxCarre);
            Console.WriteLine(fauxCarre);

            
            Forme vraiCarre = new Forme(12, Forme.TypeForme.VraiCarre);
            Console.WriteLine(vraiCarre);

            
            Forme diamandCarre = new Forme(9, Forme.TypeForme.DiamantCarre);
            Console.WriteLine(diamandCarre);
        }
    }
}
