using System;

namespace ExoCours
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(10, 12, "A");
            Point pointB = new Point(1, 5, "B");
            Console.WriteLine(pointA);
            Console.WriteLine(pointB);

            //float longeurAPasBien = Point.Longeur(pointA.x, pointA.y);
            float longeurABien = pointA.Longeur();
            Console.WriteLine("Longeur de A " + longeurABien);
            Console.WriteLine("Longeur de B " + pointB.Longeur());

            float distanceAB = Point.Distance(pointA, pointB);
            Console.WriteLine("Distance entre A et B " + distanceAB);
        }
    }
}
