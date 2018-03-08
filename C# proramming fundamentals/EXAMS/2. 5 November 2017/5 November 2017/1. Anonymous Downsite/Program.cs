using System;
using System.Linq;
using System.Numerics;

namespace _1.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int countAffectedWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal siteLoss = 0;

            for (int i = 0; i < countAffectedWebsites; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string siteName = data[0];
                decimal siteVisits = decimal.Parse(data[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(data[2]);

                siteLoss += siteVisits * siteCommercialPricePerVisit;

                Console.WriteLine(siteName);
            }
            Console.WriteLine("Total Loss: {0:F20}", siteLoss);
            Console.WriteLine("Security Token: {0}", BigInteger.Pow(securityKey, countAffectedWebsites));
        }
    }
}