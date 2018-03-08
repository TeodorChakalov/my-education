using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var necessaryHours = int.Parse(Console.ReadLine());
            var employee = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());

            var work = employee * workingDays * 8;

            if(work >= necessaryHours)
            {
                Console.WriteLine("{0} hours left", work - necessaryHours);
            }
            else
            {
                var neustoiki = (necessaryHours - work) * workingDays;
                Console.WriteLine("{0} overtime", necessaryHours - work);
                Console.WriteLine("Penalties: {0} ",neustoiki);
            }
        }
    }
}
