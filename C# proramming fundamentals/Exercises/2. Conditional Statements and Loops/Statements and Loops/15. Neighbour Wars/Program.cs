using System;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var damagePesho = int.Parse(Console.ReadLine());
            var damageGosho = int.Parse(Console.ReadLine());

            var healthPesho = 100;
            var healthGosho = 100;
            var rund = 1;
            var flag = 0;

            while (healthPesho > 0 && healthGosho > 0)
            {
                if (rund % 2 != 0)
                {
                    healthGosho = healthGosho - damagePesho;
                    if (healthGosho <= 0)
                    {
                        flag = 1;
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", healthGosho);
                }
                
                else if (rund % 2 == 0)
                {
                    healthPesho = healthPesho - damageGosho;
                    if (healthPesho <= 0)
                    {
                        flag = 2;
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", healthPesho);
                }
                if(rund % 3 == 0)
                {
                    healthPesho = healthPesho + 10;
                    healthGosho = healthGosho + 10;
                }
                rund++;
            }
            if(flag == 1)
            {
                Console.WriteLine("Pesho won in {0}th round.", rund);
            }
            if (flag == 2)
            {
                Console.WriteLine("Gosho won in {0}th round.", rund);
            }
        }
    }
}
