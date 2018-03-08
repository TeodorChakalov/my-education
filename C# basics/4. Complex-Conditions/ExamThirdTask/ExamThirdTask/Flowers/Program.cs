
using System;
        class Program
        {
            public static void Main()
            {
                var chrysanthemum = double.Parse(Console.ReadLine());
                var rose = double.Parse(Console.ReadLine());
                var tulip = double.Parse(Console.ReadLine());
                var season = Console.ReadLine();
                var holiday = Console.ReadLine();

                var total = 0.0;

                if (season == "Spring")
                {
                    total = chrysanthemum * 2.00 + rose * 4.10 + tulip * 2.5;

                    if (holiday == "Y")
                    {
                        total *= 1.15;
                    }
                    if (tulip > 7)
                    {
                        total *= 0.95;
                    }
                    if (chrysanthemum + rose + tulip > 20)
                    {
                        total *= 0.8;
                    }
                }
                else if (season == "Winter")
                {
                    total = chrysanthemum * 3.75 + rose * 4.5 + tulip * 4.15;

                    if (holiday == "Y")
                    {
                        total *= 1.15;
                    }
                    if (rose > 10)
                    {
                        total *= 0.9;
                    }
                    if (chrysanthemum + rose + tulip > 20)
                    {
                        total *= 0.8;
                    }
                }
                else if (season == "Autumn")
                {
                    total = chrysanthemum * 3.75 + rose * 4.5 + tulip * 4.15;

                    if (holiday == "Y")
                    {
                        total *= 1.15;
                    }
                    if (chrysanthemum + rose + tulip > 20)
                    {
                        total *= 0.8;
                    }
                }
                else
                {
                    total = chrysanthemum * 2.00 + rose * 4.10 + tulip * 2.5;

                    if (holiday == "Y")
                    {
                        total *= 1.15;
                    }
                    if (chrysanthemum + rose + tulip > 20)
                    {
                        total *= 0.8;
                    }
                }
                Console.WriteLine("{0:f2}", total + 2);
            }
        }