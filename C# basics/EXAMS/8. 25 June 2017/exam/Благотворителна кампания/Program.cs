using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var sweets = int.Parse(Console.ReadLine());
            var cakes = int.Parse(Console.ReadLine());
            var gofreti = int.Parse(Console.ReadLine());
            var palachinki = int.Parse(Console.ReadLine());

            var cake = cakes * 45;
            var gofreta = gofreti * 5.80;
            var palachinka = palachinki * 3.20;

            var sum = (cake + gofreta + palachinka) * sweets;
            var sumCompany = sum * days;
            var sumAfter = (sumCompany - 0.125 * sumCompany);

            Console.WriteLine("{0:F2}", sumAfter);
        }
    }
}
