using System;

namespace _2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            
            if(profession == "Athlete")
            {
                Console.WriteLine("The Athlete has to pay {0:F2}.", quantity * 0.70);
            }
            else if(profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 1);
            }
            else if(profession == "SoftUni Student")
            {
                Console.WriteLine("The SoftUni Student has to pay {0:F2}.", quantity * 1.70);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 1.20);
            }
        }
    }
}