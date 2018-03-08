using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());

            var doctors = 7;
            var untreatedPatients = 0;
            var treatedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }
                if (doctors >= patients)
                {
                    treatedPatients += patients;
                }
                else
                {
                    untreatedPatients += (patients - doctors);
                    treatedPatients += doctors;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
