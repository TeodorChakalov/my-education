using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumeSwimmingPool = int.Parse(Console.ReadLine());
            var debitFirstPipe = int.Parse(Console.ReadLine());
            var debitSecondPipe = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var firstPipe = debitFirstPipe * hours;
            var secondPipe = debitSecondPipe * hours;
            var total = firstPipe + secondPipe;

            var firstPipeFull = firstPipe / total * 100;
            var secondPipeFull = secondPipe / total * 100;
            var totalFull = total / volumeSwimmingPool * 100;

            if(total > volumeSwimmingPool)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:F1} liters.", hours, total - volumeSwimmingPool);
            }
            else
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Floor(totalFull) , Math.Floor(firstPipeFull), Math.Floor(secondPipeFull));
            }
        }
    }
}
