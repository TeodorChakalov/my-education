using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var kilometres = double.Parse(Console.ReadLine());
            var sum = kilometres;
            var total = 0.0;

            for (int i = 0; i < days; i++)
            {
                var percent = double.Parse(Console.ReadLine());

                sum = sum + (percent / 100) * sum;
                total += sum;
            }
            total = total + kilometres;
            if(total<1000)
            {
                Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", Math.Ceiling(1000 - total));
            }
            else
            {
                Console.WriteLine("You've done a great job running {0} more kilometers!", Math.Ceiling(total - 1000));
            }
        }
    }
}
