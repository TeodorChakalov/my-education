using System;

namespace _2.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalMoney = double.Parse(Console.ReadLine());
            var currentMoney = totalMoney;
            var nameOfTheGame = Console.ReadLine();

            while (nameOfTheGame != "Game Time")
            {
                switch (nameOfTheGame)
                {
                    case "OutFall 4":
                        if (currentMoney >= 39.99)
                        {
                            currentMoney -= 39.99;
                            Console.WriteLine($"Bought OutFall 4"); 
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if(currentMoney >= 15.99)
                        {
                            currentMoney -= 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if(currentMoney >= 19.99)
                        {
                            currentMoney -= 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentMoney >= 59.99)
                        {
                            currentMoney -= 59.99;
                            Console.WriteLine($"Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentMoney >= 29.99)
                        {
                            currentMoney -= 29.99;
                            Console.WriteLine($"Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (currentMoney >= 39.99)
                        {
                            currentMoney -= 39.99;
                            Console.WriteLine($"Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                         default: Console.WriteLine("Not Found"); break;
                }

                if(currentMoney <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                nameOfTheGame = Console.ReadLine();
            }

            var remainMoney = totalMoney - currentMoney;
            Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", remainMoney, currentMoney);
        }
    }
}