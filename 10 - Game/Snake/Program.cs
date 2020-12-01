using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Level level = new Level(10, 5);
            Console.WriteLine(level.ToStringLevel());
            level = new Level(25, 15);
            Console.WriteLine(level.ToStringLevel());
        }
    }
}
