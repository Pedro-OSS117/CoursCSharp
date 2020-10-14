using System;

namespace StateLifeEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            byte life = 100;

            bool isInvincible = false;
            bool isHurtable = true;

            byte damages = 50;

            Console.WriteLine("Life Bob is : " + life + " and his state invicible is : " + isInvincible);
            if( life > 0 && isHurtable)
            {
                life -= damages;
            }
            Console.WriteLine("Life Bob is : " + life + " and his state invicible is : " + isInvincible);

            isInvincible = true;            
            if( life > 0 && !isInvincible)
            {
                life -= damages;
            }
            Console.WriteLine("Life Bob is : " + life + " and his state invicible is : " + isInvincible);
        }
    }
}
