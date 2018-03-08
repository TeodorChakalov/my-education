using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хореография
{
    class Program
    {
        static void Main(string[] args)
        {
            var stepCount = double.Parse(Console.ReadLine());
            var DancerCount = double.Parse(Console.ReadLine());
            var learningDays = double.Parse(Console.ReadLine());

            var stepPerDay = Math.Ceiling(((stepCount / learningDays) / stepCount) * 100);
            var percentDancerSteps = stepPerDay / DancerCount;

            if (stepPerDay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:F2}%.", percentDancerSteps);
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:F2}% steps to be learned per day.", percentDancerSteps);
            }
        }
    }
}
