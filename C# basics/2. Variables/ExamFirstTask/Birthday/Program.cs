//давана като първа задача на 17 септември 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължина на аквариума в сантиметри: ");
            var length = int.Parse(Console.ReadLine());
            Console.Write("Въведете широчина на аквариума в сантиметри: ");
            var width = int.Parse(Console.ReadLine());
            Console.Write("Въведете височина на аквариума в сантиметри: ");
            var height = int.Parse(Console.ReadLine());
            Console.Write("Въведете процент от вместимостта му, която е заета от пясък, растения, нагревател и помпа: ");
            var percent = double.Parse(Console.ReadLine());
            var volume = length * width * height * 0.001;
            var litre = volume * (1 - percent * 0.01);
            Console.WriteLine("Литрите вода, които са необходими за напълването на аквариума са: {0:F3}", litre);
        }
    }
}
