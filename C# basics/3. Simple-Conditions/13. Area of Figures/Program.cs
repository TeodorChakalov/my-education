using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if(figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var area = a * a;
                Console.WriteLine("{0}", area);
            }
            if(figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = a * b;
                Console.WriteLine("{0}",area);
            }
            if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;
                Console.WriteLine("{0}", area);
            }
            if(figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var area = a * h / 2;
                Console.WriteLine("{0}", area);
            }
        }
    }
}
