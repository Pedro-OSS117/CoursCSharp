using System;

namespace Vector3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector1 = new Vector3(1, 5, 6);
            Vector3 vector2 = new Vector3(24, 15, -5);

            Console.WriteLine("Declaration :\n" + vector1);
            Console.WriteLine(vector2);

            vector1.Translate(1,8,0);
            vector2.Translate(15,0,6);
            
            Console.WriteLine("\nTranslate :\n" + vector1);
            Console.WriteLine(vector2);

            float longeur = vector1.Longueur();
            Console.WriteLine("\nLongueur :\nLongueur vector 1 : " + longeur);
            longeur = vector2.Longueur();
            Console.WriteLine("Longueur vector 2 : " + longeur);

            float distance = Vector3.Distance(vector1, vector2);
            Console.WriteLine("\nDistance entre vector 1 et vector 2 : " + distance);

            distance = Vector3.Distance(vector1, vector2);
            Console.WriteLine("\nDistance entre vector 1 et vector 2 : " + distance);
        }

        public struct Vector3
        {
            public float x;
            public float y;
            public float z;

            // Constructeur
            public Vector3(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public override string ToString()
            {
                return "{" + x + "," + y + "," + z + "}";
            }

            public void Translate(float x, float y, float z)
            {
                this.x += x;
                this.y += y;
                this.z += z;
            }

            public float Longueur()
            {
                return MathF.Sqrt(x*x + y*y + z*z);
            }

            /*
            public float Distance(Vector3 vectorToCalculate)
            {
                float valX = (vectorToCalculate.x - x);
                float valY = (vectorToCalculate.y - y);
                float valZ = (vectorToCalculate.z - z);

                return MathF.Sqrt(valX*valX + valY*valY + valZ*valZ);
            }*/

            public static float Distance(Vector3 v1, Vector3 v2)
            {
                float valX = (v2.x - v1.x);
                float valY = (v2.y - v1.y);
                float valZ = (v2.z - v1.z);
                return MathF.Sqrt(valX*valX + valY*valY + valZ*valZ);
            }
        }
    }
}