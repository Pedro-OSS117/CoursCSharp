using System;

namespace ExoCours
{
    public struct Point
    {
        public int x;
        public int y;
        public string name;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            name = "Omega";
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Le point {name} a comme coordonnées : ({x} , {y})";
        }

        public float Longeur()
        {
            return MathF.Sqrt(x * x + y * y);
        }

        public static float Distance(Point point1, Point point2)
        {
            float x = point2.x - point1.x;
            float y = point2.y - point1.y;
            return MathF.Sqrt(x * x + y * y);
        }
    }
}