using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            var countDays = 0;
            bool isHoliday = false;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    isHoliday = true;
                }
                for (int j = 0; j < holidays.Count; j++)
                {
                    if (i.Month == holidays[j].Month && i.Day == holidays[j].Day)
                    {
                        isHoliday = true;
                    }
                }
                if (!isHoliday)
                {
                    countDays++;
                }
                isHoliday = false;
            }
            Console.WriteLine(countDays);

        //    var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        //    var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);


        //    List<DateTime> holidays = new List<DateTime>();
        //    holidays.Add(new DateTime(2016, 1, 1));
        //    holidays.Add(new DateTime(2016, 3, 3));
        //    holidays.Add(new DateTime(2016, 5, 1));
        //    holidays.Add(new DateTime(2016, 5, 6));
        //    holidays.Add(new DateTime(2016, 5, 24));
        //    holidays.Add(new DateTime(2016, 9, 6));
        //    holidays.Add(new DateTime(2016, 9, 22));
        //    holidays.Add(new DateTime(2016, 11, 1));
        //    holidays.Add(new DateTime(2016, 12, 24));
        //    holidays.Add(new DateTime(2016, 12, 25));
        //    holidays.Add(new DateTime(2016, 12, 26));

        //    var countWorkingDays = 0;
        //    for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        //    {
        //        if(!holidays.Any(d => d.Day == currentDate.Day && d.Month == currentDate.Month) && !currentDate.DayOfWeek.Equals(DayOfWeek.Saturday) && !currentDate.DayOfWeek.Equals(DayOfWeek.Sunday))
        //        {
        //            countWorkingDays++;
        //        }
        //    }

        //    Console.WriteLine(countWorkingDays);
        }
    }
}