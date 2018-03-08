using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(' ');
                Sale sale = new Sale { Town = array[0], Product = array[1], Price = decimal.Parse(array[2]), Quantity = double.Parse(array[3]) };
                sales.Add(sale);
            }

            var towns = sales.Select(s => s.Town).Distinct().OrderBy(x => x);

            foreach (var town in towns)
            {
                var salesByTown = sales.Where(s => s.Town == town).Select(s => s.Price * (decimal)s.Quantity);
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown.Sum());
            }

        }
    }
}