using System;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char characterForFirstBoat = char.Parse(Console.ReadLine());
            char characterForSecondBoat = char.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());
            var tilesForFirstBoat = 0;
            var tilesForSecondBoat = 0;

            for (int i = 1; i <= number; i++)
            {
                var text = Console.ReadLine();
                var lenghtText = text.Length;

                if (i % 2 != 0 && text != "UPGRADE")
                {
                    tilesForFirstBoat += lenghtText;
                }
                else if (i % 2 == 0 && text != "UPGRADE")
                {
                    tilesForSecondBoat += lenghtText;
                }
                else if(i % 2 != 0 && text == "UPGRADE")
                {
                    characterForFirstBoat += (char)3;
                    characterForSecondBoat += (char)3;
                }
                else if (i % 2 == 0 && text == "UPGRADE")
                {
                    characterForFirstBoat += (char)3;
                    characterForSecondBoat += (char)3;
                }
                if(tilesForFirstBoat >= 50 || tilesForSecondBoat >= 50)
                {
                    break;
                }
            }
            if(tilesForFirstBoat >= tilesForSecondBoat)
            {
                Console.WriteLine("{0}", characterForFirstBoat);
            }
            else
            {
                Console.WriteLine("{0}", characterForSecondBoat);
            }
        }
    }
}