using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacityStadium = double.Parse(Console.ReadLine());
            var countFans = double.Parse(Console.ReadLine());
            var countInA = 0.0;
            var countInB = 0.0;
            var countInV = 0.0;
            var countInG = 0.0;

            for (int i = 0; i < countFans; i++)
            {
                var sector = Console.ReadLine();

                if(sector == "A")
                {
                    countInA++;
                }
                else if(sector == "B")
                {
                    countInB++;
                }
                else if(sector == "V")
                {
                    countInV++;
                }
                else if(sector == "G")
                {
                    countInG++;
                }

            }

            Console.WriteLine("{0:F2}%",countInA / countFans * 100);
            Console.WriteLine("{0:F2}%",countInB / countFans * 100);
            Console.WriteLine("{0:F2}%",countInV / countFans * 100);
            Console.WriteLine("{0:F2}%",countInG / countFans * 100);
            Console.WriteLine("{0:F2}%",countFans / capacityStadium * 100);
        }
    }
}
