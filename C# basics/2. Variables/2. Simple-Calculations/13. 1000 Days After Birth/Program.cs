using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthDateInput = Console.ReadLine();
            //var format = "dd-MM-yyyy";
            var birthDate = DateTime.ParseExact(birthDateInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            birthDate = birthDate.AddDays(999);
            Console.WriteLine(birthDate.ToString("dd-MM-yyyy"));
        }
    }
}
